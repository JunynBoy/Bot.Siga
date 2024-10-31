using Bot.Core.Model;
using Bot.Core.Service;
using Bot.Core.src.Helper;
using Bot.Core.src.Service.Http;
using Bot.Siga.src.ColetaModular.Interface;
using Microsoft.IdentityModel.Tokens;
using OpenQA.Selenium;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Globalization;

namespace Bot.Siga.src.ColetaModular
{
    public class ColetorNotas : IniciadorColeta, IColetaModular
    {
        private string _homeUrl;
        private MateriaService _materiaService;
        private WhatsapMessageHttpService _messageHttpService;
        private EmailService _emailService;


        public ColetorNotas()
        {
            this._emailService = new EmailService();
            this._materiaService = new MateriaService();
            this._messageHttpService = new WhatsapMessageHttpService();
            this._homeUrl = ConfigurationManager.AppSettings["urlHome"]!;
        }

        public void ColetarDados(Estudante estudante)
        {
            string patternCodigoMateria = @"([A-Z]{3}\d{3})";
            string patternNomeMateria = @"^\w+\s+(.+?)\r?\n";
            string patternP1 = @"P1\s.*?\s*(\d+,\d+)";
            string patternP2 = @"P2\s.*?\s*(\d+,\d+)";
            string patternP3 = @"P3\s.*?\s*(\d+,\d+)";
            string patternMediaFinal = @"Média Final\(\*\*\)\s+(\d+,\d+)";
            bool contemAtributosDiferentesDoBanco = false;

            try
            {

                this.Log( "Iniciando Coleta de Notas");

                this.ClicarNoBotaoNotas();

                String? textoDaPagina = this.ExtrairTextoPorXPath("//div [@id = 'Grid4ContainerDiv']");

                ReadOnlyCollection<IWebElement> headersNotasElements = _driver.FindElements(By.XPath("//td[contains(@valign, 'top') and ancestor::*[contains(@id,'Grid4ContainerRow_')]]/.."));
                ReadOnlyCollection<IWebElement> notasElements = _driver.FindElements(By.XPath("//div[contains(@id, 'Grid1ContainerDiv_')]"));

                
                if (headersNotasElements.Count == notasElements.Count)
                {
                    List<Materia> materiaMatriculados = this._materiaService.GetByEstudanteId(estudante.Id);
                    if (materiaMatriculados.IsNullOrEmpty())
                    {
                        materiaMatriculados = new List<Materia>();
                    }


                    for (int i = 0; i < headersNotasElements.Count; i++)
                    {
                        IWebElement headerNota = headersNotasElements[i];

                        string codigoMateria = RegexHelper.GetText(headerNota.Text, patternCodigoMateria).Trim();
                        string nomeMateria = RegexHelper.GetText(headerNota.Text, patternNomeMateria, 1)!.Trim();

                        string mediaFinalText = RegexHelper.GetText(headerNota.Text, patternMediaFinal, 1)!;
                        float mediaFinal = 0.0f;

                        if (!string.IsNullOrEmpty(mediaFinalText))
                        {
                            mediaFinalText = mediaFinalText.Replace(',', '.'); 
                            float.TryParse(mediaFinalText, NumberStyles.Float, CultureInfo.InvariantCulture, out mediaFinal);
                        }

                        Materia? materia = materiaMatriculados
                        ?.FirstOrDefault(mm => mm.Codigo?.ToUpper().Equals(codigoMateria?.ToUpper()) == true);
                        if (materia == null)
                            materia = new Materia();

                        materia.Codigo = codigoMateria;
                        materia.Nome = nomeMateria;
                        materia.EstudanteId = estudante.Id;


                        IWebElement notaCorrespondente = notasElements[i];
                        if(materia.Notas == null)
                        {
                            materia.Notas =  new Notas();
                        }


                        float[] notas = new float[3];
                        string[] patterns = { patternP1, patternP2, patternP3 };
                        float?[] notasBanco =
                        {
                            materia.Notas.P1,
                            materia.Notas.P2,
                            materia.Notas.P3
                        };

                        int index = 0;
                        foreach (var pattern in patterns)
                        {
                            float numeroConvertido = 0.0f;
                            string numeroString = RegexHelper.GetText(notaCorrespondente.Text, pattern, 1)!.Replace(",", ".");
                            float.TryParse(numeroString, NumberStyles.Float, CultureInfo.InvariantCulture, out numeroConvertido);

                            notas[index] = numeroConvertido;

                            if (numeroConvertido != notasBanco[index])
                            {
                                contemAtributosDiferentesDoBanco = true;
                            }
                            index++;
                        }

                        materia.Notas.P1 = notas[0];
                        materia.Notas.P2 = notas[1];
                        materia.Notas.P3 = notas[2];
                        materia.Notas.MediaFinal = mediaFinal;

                        this._materiaService.Save(materia);

                        if (estudante.Preferencia != null )
                        {
                            if (contemAtributosDiferentesDoBanco)
                            {
                                try{
                                    if (estudante.Preferencia.IsAtualizarPorEmail)
                                    {
                                        this.EnviarEmail(estudante, new List<Materia> { materia });
                                    }

                                    if (estudante.Preferencia.IsAtualizarPorWhatsapp)
                                    {
                                        string mensagemDeAtualizacao = $"*O Robôzinho do Siga identificou alterações nas suas notas!*\n\n" +
                                            $"Matéria: {materia.Nome} - {materia.Codigo} - {materia.Professor ?? "Professor Não Definido"}\n" +
                                            $"P1 -> {materia.Notas.P1}\n" +
                                            $"P2 -> {materia.Notas.P2}\n" +
                                            $"P3 -> {materia.Notas.P3}";
                                        var response = this._messageHttpService.EnviarMensagem(estudante.Preferencia!.Whatsapp!, mensagemDeAtualizacao);
                                        if (!response)
                                        {
                                            Log("Não foi possível enviar mensagem pelo whatsapp");
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    throw new Exception($"Não foi possível notificar corretamente\n Message:{ex.Message}");
                                }
                                
                            }
                            
                        }
                        else
                        {
                            throw new Exception("Configure as preferencias do estudante!");
                        }

                    }
                }
                else
                {
                    throw new Exception("Não foi encontrado um índice correspondente de matérias e notas");
                }


                
            }
            catch (Exception e)
            {
                Log($"ERRO: {e.Message}");
                Console.WriteLine(e.Message.ToString());
            }

            Log( "Finalizando Coleta de Notas...");
        }

        private void EnviarEmail(Estudante estudante, List<Materia> materias)
        {
            List<string> emailsTo = new List<string>();

            if (!string.IsNullOrEmpty(estudante.EmailInstitucional))
                emailsTo.Add(estudante.EmailInstitucional);

            if (estudante.Preferencia != null && !string.IsNullOrEmpty(estudante.Preferencia.Email))
                emailsTo.Add(estudante.Preferencia.Email);

            var dictionary = _emailService.BuildarEnvioDeAutalizacaoDeNotas(estudante, materias);
            try
            {
                _emailService.sendEmail(emailsTo, dictionary["subject"], dictionary["body"], new List<string>());
            }
            catch (Exception ex)
            {
                Log("Erro ao enviar o e-mail: " + ex.Message);
            }
           
        }

        private void ClicarNoBotaoNotas()
        {
            string xpathNotas = "//span[@class='NodeTextDecoration' and contains(text(),'Notas Parciais')]";

            try
            {
                this.ClickOnElementByXpath(xpathNotas);
            }
            catch(Exception e)
            {
                throw new Exception($"Não foi possível clicar no botão das notas: {e.Message}");
            }
        }

        public bool ValidarPaginaParaExecucao()
        {
            if (_driver!.Url.Equals(_homeUrl))
                return true;
            else
                return false;
        }



        








    }
}
