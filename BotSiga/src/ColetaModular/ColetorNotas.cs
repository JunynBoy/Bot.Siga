using AngleSharp.Html.Dom;
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
using System.Net;
using System.Text.RegularExpressions;

namespace Bot.Siga.src.ColetaModular
{
    public class ColetorNotas : ColetorSiga, IColetaModular
    {
        private string _homeUrl;
        private MateriaMatriculadoService _materiaService;
        private NotasService _notasService;

        public ColetorNotas()
        {
            this._materiaService = new MateriaMatriculadoService();
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


            try
            {

                StringHelper.ConsoleColoredLog(ConsoleColor.Cyan, "Iniciando Coleta de Notas...");

                this.ClicarNoBotaoNotas();

                String? textoDaPagina = this.ExtrairTextoPorXPath("//div [@id = 'Grid4ContainerDiv']");

                ReadOnlyCollection<IWebElement> headersNotasElements = _driver.FindElements(By.XPath("//td[contains(@valign, 'top') and ancestor::*[contains(@id,'Grid4ContainerRow_')]]/.."));
                ReadOnlyCollection<IWebElement> notasElements = _driver.FindElements(By.XPath("//div[contains(@id, 'Grid1ContainerDiv_')]"));

                
                if (headersNotasElements.Count == notasElements.Count)
                {
                    List<MateriaMatriculado> materiaMatriculados = this._materiaService.GetByEstudanteId(estudante.Id);
                    if (materiaMatriculados.IsNullOrEmpty())
                    {
                        materiaMatriculados = new List<MateriaMatriculado>();
                    }


                    for (int i = 0; i < headersNotasElements.Count; i++)
                    {
                        IWebElement headerNota = headersNotasElements[i];

                        string codigoMateria = RegexHelper.GetText(headerNota.Text, patternCodigoMateria).Trim();
                        string nomeMateria = RegexHelper.GetText(headerNota.Text, patternNomeMateria ,1).Trim();
                        MateriaMatriculado? materia = materiaMatriculados.FirstOrDefault(mm => mm.Codigo == codigoMateria);
                        if(materia == null)
                            materia = new MateriaMatriculado();

                        materia.Codigo = codigoMateria;
                        materia.Nome = nomeMateria;
                        materia.EstudanteId = estudante.Id;


                        IWebElement notaCorrespondente = notasElements[i];
                        if(materia.Notas == null)
                        {
                            materia.Notas =  new Notas();
                        }

                        materia.Notas.P1 = float.TryParse(RegexHelper.GetText(notaCorrespondente.Text, patternP1).Trim(), out float p1) ? p1 : 0.0f; 
                        materia.Notas.P2 = float.TryParse(RegexHelper.GetText(notaCorrespondente.Text, patternP2).Trim(), out float p2) ? p2 : 0.0f;
                        materia.Notas.P3 = float.TryParse(RegexHelper.GetText(notaCorrespondente.Text, patternP3).Trim(), out float p3) ? p3 : 0.0f;
                        materia.Notas.MediaFinal = float.TryParse(RegexHelper.GetText(notaCorrespondente.Text, patternMediaFinal).Trim(), out float mediaFinal) ? mediaFinal : 0.0f;

                        this._materiaService.Save(materia);
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
