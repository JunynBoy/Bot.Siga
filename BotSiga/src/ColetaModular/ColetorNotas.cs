using AngleSharp.Html.Dom;
using Bot.Core.Model;
using Bot.Core.Service;
using Bot.Core.src.Helper;
using Bot.Siga.src.ColetaModular.Interface;
using Microsoft.IdentityModel.Tokens;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Configuration;
using System.Text.RegularExpressions;

namespace Bot.Siga.src.ColetaModular
{
    public class ColetorNotas : ColetorSiga, IColetaModular
    {
        private string _homeUrl;
        private MateriaMatriculadoService _materiaService;

        public ColetorNotas()
        {
            this._materiaService = new MateriaMatriculadoService();
            this._homeUrl = ConfigurationManager.AppSettings["urlHome"]!;
        }

        public void ColetarDados(Estudante estudante)
        {
            string patternCodigoMateria = @"([A-Z]{3}\d{3})";
            string patternNomeMateria = @"(?<codigo>\w+)\s+(?<nome>.+)\s+Média Final\(\*\*\) \d+,\d+";
            string patternFaltas = @"Faltas\(Após finalização da disciplina\) (\d+)";
            string patternFrequencia = @"% Frequência (\d+\.\d+)";
            string patternP1 = @"P1 / / (\d+\.\d+)";
            string patternP2 = @"P2 / / (\d+\.\d+)";
            string patternP3 = @"P3 / / (\d+\.\d+)";
            string patternMediaFinal = @"Média Final\(\*\*\) (\d+\.\d+)";


            try
            {

                StringHelper.ConsoleColoredLog(ConsoleColor.Cyan, "Iniciando Coleta de Notas...");

                this.ClicarNoBotaoNotas();

                String? textoDaPagina = this.ExtrairTextoPorXPath("//div [@id = 'Grid4ContainerDiv']");

                if (!String.IsNullOrEmpty(textoDaPagina)){

                    MatchCollection matchesMaterias = Regex.Matches(textoDaPagina, patternCodigoMateria);

                    foreach (Match match in matchesMaterias)
                    {
                        string codigo = match.Groups["codigo"].Value;
                        string nome = match.Groups["nome"].Value;

                        Console.WriteLine("Código: " + codigo);
                        Console.WriteLine("Nome: " + nome);
                    }
                }
                else
                {
                    throw new Exception("Não há notas para coletar no momento!");
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
