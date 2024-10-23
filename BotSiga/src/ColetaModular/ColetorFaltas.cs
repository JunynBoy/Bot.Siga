using Bot.Core.Model;
using Bot.Core.Service;
using Bot.Core.src.Helper;
using Bot.Siga.src.ColetaModular.Interface;
using Microsoft.IdentityModel.Tokens;
using OpenQA.Selenium;
using System.Collections.ObjectModel;
using System.Configuration;

namespace Bot.Siga.src.ColetaModular
{
    public class ColetorFaltas : IniciadorColeta , IColetaModular
    {
        private string? _homeUrl;
        private MateriaService _materiaService;


        public ColetorFaltas()
        {
            this._materiaService = new MateriaService();
            this._homeUrl = ConfigurationManager.AppSettings["urlHome"];
        }

        public async Task ColetarDados(Estudante estudante)
        {
            StringHelper.ConsoleColoredLog(ConsoleColor.Cyan, "Iniciando Coleta de Faltas...");

                try
                {

                    this.ClicarBotaoFaltas();

                    List<Materia> materias = this._materiaService.GetByEstudanteId(estudante.Id);
                    if (materias.IsNullOrEmpty())
                    {
                        materias = new List<Materia>();
                    }


                    ReadOnlyCollection<IWebElement> linhasElement = _driver.FindElements(By.XPath("//tr[contains(@id,'Grid1ContainerRow_')]"));


                foreach (IWebElement linha in linhasElement)
                {
                    ReadOnlyCollection<IWebElement> colunas = linha.FindElements(By.TagName("td"));

                    string codigoMateria = colunas[0].Text.Trim();
                    string nomeMateria = colunas[1].Text.Trim();
                    Faltas faltas = new Faltas();
                    faltas.Presencas = int.Parse(colunas[2].Text.Trim());
                    faltas.Ausencias = int.Parse(colunas[3].Text.Trim());

                    Materia? materia = materias.FirstOrDefault(mm => mm.Codigo == codigoMateria);
                    if (materia == null)
                    {

                        materia = new Materia
                        {
                            Codigo = codigoMateria,
                            Nome = nomeMateria,
                            EstudanteId = estudante.Id,
                            Faltas = faltas,
                        };
                        materias.Add(materia);
                    }
                    else
                    {
                        if (materia.Faltas != null)
                        {
                            materia.Faltas.Presencas = faltas.Presencas;
                            materia.Faltas.Ausencias = faltas.Ausencias;
                        }
                        else
                        {
                            materia.Faltas = faltas;
                        }
                    }
                    this._materiaService.Save(materia);
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
