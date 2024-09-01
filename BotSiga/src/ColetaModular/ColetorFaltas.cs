using Bot.Core.Model;
using Bot.Core.Service;
using Bot.Core.src.Helper;
using Bot.Siga.src.ColetaModular.Interface;
using Microsoft.IdentityModel.Tokens;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
using System.Configuration;

namespace Bot.Siga.src.ColetaModular
{
    public class ColetorFaltas : ColetorSiga , IColetaModular
    {
        private string? _homeUrl;
        private MateriaService _materiaService;


        public ColetorFaltas()
        {
            this._materiaService = new MateriaService();
            this._homeUrl = ConfigurationManager.AppSettings["urlHome"];
        }

        public void ColetarDados(Estudante estudante)
        {
            StringHelper.ConsoleColoredLog(ConsoleColor.Cyan, "Iniciando Coleta de Faltas...");

                try
                {

                    this.ClicarBotaoFaltas();

                    List<Materia> materiaMatriculados = this._materiaService.GetByEstudanteId(estudante.Id);
                    if (materiaMatriculados.IsNullOrEmpty())
                    {
                        materiaMatriculados = new List<Materia>();
                    }


                    ReadOnlyCollection<IWebElement> linhasElement = _driver.FindElements(By.XPath("//tr[contains(@id,'Grid1ContainerRow_')]"));


                foreach (IWebElement linha in linhasElement)
                {
                    ReadOnlyCollection<IWebElement> colunas = linha.FindElements(By.TagName("td"));

                    string codigoMateria = colunas[0].Text.Trim();
                    string nomeMateria = colunas[1].Text.Trim();
                    string presencas = colunas[2].Text.Trim();
                    string ausencias = colunas[3].Text.Trim();

                    Materia? materia = materiaMatriculados.FirstOrDefault(mm => mm.Codigo == codigoMateria);
                    if (materia == null)
                    {
                        materia = new Materia
                        {
                            Codigo = codigoMateria,
                            Nome = nomeMateria,
                            EstudanteId = estudante.Id
                        };
                        materiaMatriculados.Add(materia);
                    }
                    else
                    {
                        materia.Nome = nomeMateria;
                    }



                    //materia.Notas.P1 = float.TryParse(presencas, out float p1) ? p1 : 0.0f;
                    //materia.Notas.P2 = float.TryParse(ausencias, out float p2) ? p2 : 0.0f;
                }

            }
                catch (Exception e)
                {
                    StringHelper.ConsoleColoredLog(ConsoleColor.Yellow, $"Não foi encontrado nada:{e.Message}");
                }

            StringHelper.ConsoleColoredLog(ConsoleColor.Cyan, "Finalizando Coleta de Faltas...");
        }

        private void ClicarBotaoFaltas()
        {
            string xpathFaltas = "//span[@class='NodeTextDecoration' and contains(text(),'Faltas Parciais')]";

            try
            {
                this.ClickOnElementByXpath(xpathFaltas);
            }
            catch (Exception e)
            {
                throw new Exception($"Não foi possível clicar no botão das faltas: {e.Message}");
            }
        }


    }
}
