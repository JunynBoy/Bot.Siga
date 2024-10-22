using AngleSharp.Html.Dom;
using Bot.Core.Model;
using Bot.Core.Service;
using Bot.Core.src.Helper;
using Bot.Siga.src.ColetaModular.Interface;
using Microsoft.IdentityModel.Tokens;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V114.Network;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Bot.Siga.src.ColetaModular
{
    public class ColetorNotas : ColetorSiga, IColetaModular
    {
        private string _homeUrl;
        private MateriaService _materiaService;
        private NotasService _notasService;

        public ColetorNotas()
        {
            this._materiaService = new MateriaService();
            this._homeUrl = ConfigurationManager.AppSettings["urlHome"]!;
        }

        public void ColetarDados(Estudante estudante)
        {
            string patternCodigoMateria = @"([A-Z]{3}\d{3})";
            string patternNomeMateria = @"^\w+\s+(.+?)\r?\n";
            string patternP1 = @"P1 / / (\d+\.\d+)";
            string patternP2 = @"P2 / / (\d+\.\d+)";
            string patternP3 = @"P3 / / (\d+\.\d+)";
            string patternMediaFinal = @"Média Final\(\*\*\) (\d+\.\d+)";
            bool contemAtributosDiferentesDoBanco = false;

            try
            {

                StringHelper.ConsoleColoredLog(ConsoleColor.Cyan, "Iniciando Coleta de Notas...");

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
                        string nomeMateria = RegexHelper.GetText(headerNota.Text, patternNomeMateria ,1).Trim();
                        Materia? materia = materiaMatriculados.FirstOrDefault(mm => mm.Codigo == codigoMateria);
                        if(materia == null)
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
                            if (float.TryParse(RegexHelper.GetText(notaCorrespondente.Text, pattern).Trim(), out notas[index]) && notasBanco[index] != notas[index])
                            {
                                contemAtributosDiferentesDoBanco = true;
                                notasBanco[index] = notas[index];
                            }
                            index++;
                        }
                        //contemAtributosDiferentesDoBanco

                        if (true)
                        {
                            materia.Notas.P1 = notasBanco[0];
                            materia.Notas.P2 = notasBanco[1];
                            materia.Notas.P3 = notasBanco[2];
                            materia.Notas.MediaFinal = float.TryParse(RegexHelper.GetText(notaCorrespondente.Text, patternMediaFinal).Trim(), out float mediaFinal) ? mediaFinal : 0.0f;
                            this._materiaService.Save(materia);

                          this.EnviarEmail(estudante, new List<Materia> { materia });
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
                StringHelper.ConsoleColoredLog(ConsoleColor.Yellow, $"ERRO: {e.Message}");
            }

            StringHelper.ConsoleColoredLog(ConsoleColor.Cyan, "Finalizando Coleta de Notas...");
        }

        private void EnviarEmail(Estudante estudante, List<Materia> materias)
        {
            while (true){
                EmailService emailService = new EmailService("smtp.gmail.com", "robozinhodosiga@gmail.com", "smir wvtd uuee odvl", 587);
                List<string> emailsTo = new List<string> { "marcos.gasparini13@gmail.com" };
                var dictionary = emailService.BuildarEnvioDeAutalizacaoDeNotas(estudante, materias);
                try
                {
                    emailService.sendEmail(emailsTo, dictionary["subject"], dictionary["body"], new List<string>());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao enviar o e-mail: " + ex.Message);
                }
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
