using Bot.Core.Model;
using Bot.Core.Service;
using Bot.Core.src.Helper;
using Bot.Core.src.Service.Http;
using Bot.Siga.src.ColetaModular.Interface;
using Microsoft.IdentityModel.Tokens;
using OpenQA.Selenium;
using System.Collections.ObjectModel;
using System.Configuration;

namespace Bot.Siga.src.ColetaModular
{
    public class ColetorMaterias : IniciadorColeta , IColetaModular
    {
        private string? _homeUrl;
        private MateriaService _materiaService;
        private WhatsapMessageHttpService _messageService;


        public ColetorMaterias()
        {
            this._materiaService = new MateriaService();
            this._homeUrl = ConfigurationManager.AppSettings["urlHome"];
        }

        public void ColetarDados(Estudante estudante)
        {
           Log( "Iniciando Coleta de Matérias...");

            try
            {

                this.ClicarBotaoHorarios();

                List<Materia> materiaMatriculados = this._materiaService.GetByEstudanteId(estudante.Id);
                if (materiaMatriculados.IsNullOrEmpty())
                {
                    materiaMatriculados = new List<Materia>();
                }


                ReadOnlyCollection<IWebElement> linhasElement = _driver!.FindElements(By.XPath("//tr[contains(@id,'Grid1ContainerRow_')]"));


                foreach (IWebElement linha in linhasElement)
                {
                    ReadOnlyCollection<IWebElement> colunas = linha.FindElements(By.TagName("td"));

                    string codigoMateria = colunas[0].Text.Trim();
                    string? hrsAula = RegexHelper.GetText(colunas[1].Text.Trim(), @"-\s*(\d+)", 1);
                    int? horasAula = !string.IsNullOrEmpty(hrsAula) ? int.Parse(hrsAula) : (int?)null;
                    string nomeMateria = colunas[1].Text.Split('-')[0].Trim();
                    string professor = colunas[3].Text.Trim();

                    Materia? materia = materiaMatriculados
                        ?.FirstOrDefault(mm => mm.Codigo?.ToUpper().Equals(codigoMateria?.ToUpper()) == true);
                    if (materia == null)
                    {
                        materia = new Materia
                        {
                            Codigo = codigoMateria,
                            Nome = nomeMateria,
                            HrsAula = horasAula,
                            Professor = professor,
                            EstudanteId = estudante.Id
                        };
                        materiaMatriculados!.Add(materia);
                    }
                    else
                    {
                        materia.Codigo = codigoMateria;
                        materia.Nome = nomeMateria;
                        materia.Professor = professor;
                        materia.HrsAula = horasAula;

                        if (materia.Faltas != null && materia.HrsAula != null)
                        {
                            if (materia.HrsAula >= 4)
                                materia.Faltas.MaximoAusencia = 20;
                            else
                                materia.Faltas.MaximoAusencia = 10;
                        }

                    }

                    this._materiaService.Save(materia);


                    Log($"Coletaado dados da materia: {materia.Nome}");


                }

                Log( $"Coleta de dados completa");


            }
            catch (Exception e)
            {
                Log( $"Não foi encontrado nada:{e.Message}");
            }

           Log( "Finalizando Coleta de Faltas...");
        }

        private void ClicarBotaoHorarios()
        {
            string xpathFaltas = "//span[@class='NodeTextDecoration' and contains(text(),'Horário')]";

            try
            {
                this.ClickOnElementByXpath(xpathFaltas);
            }
            catch (Exception e)
            {
                throw new Exception($"Não foi possível clicar no botão Horário: {e.Message}");
            }
        }


    }
}
