using Bot.Core.Model;
using Bot.Siga.src.ColetaModular.Interface;
using Microsoft.IdentityModel.Tokens;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Configuration;
using System.Text.RegularExpressions;

namespace Bot.Siga.src.ColetaModular
{
    public class ColetorNotas : IColetaModular
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        private Action _action;
        private string _homeUrl;

        public ColetorNotas(IWebDriver driver)
        {
            _driver = driver;
            _homeUrl = ConfigurationManager.AppSettings["urlHome"]!;

        }


        public void ColetarDados()
        {
            ConsoleColoredLog(ConsoleColor.Cyan, "Iniciando Coleta de Notas...");

            if (ValidarPaginaParaExecucao())
            {

                try
                {


                    IWebElement btnNotas = _driver.FindElement(By.XPath("//span[@id = 'ygtvlabelel10Span']"));
                    btnNotas.Click();
                    Thread.Sleep(1000);

                    String texto = _driver.FindElement(By.XPath("//div [@id = 'Grid4ContainerDiv']")).Text;

                    string patternCodigoMateria = @"([A-Z]{3}\d{3})";
                    string patternNomeMateria = @"(?<codigo>\w+)\s+(?<nome>.+)\s+Média Final\(\*\*\) \d+,\d+";
                    string patternFaltas = @"Faltas\(Após finalização da disciplina\) (\d+)";
                    string patternFrequencia = @"% Frequência (\d+\.\d+)";
                    string patternP1 = @"P1 / / (\d+\.\d+)";
                    string patternP2 = @"P2 / / (\d+\.\d+)";
                    string patternP3 = @"P3 / / (\d+\.\d+)";
                    string patternMediaFinal = @"Média Final\(\*\*\) (\d+\.\d+)";

                    MatchCollection matchesMaterias = Regex.Matches(texto, patternCodigoMateria);

                    foreach (Match match in matchesMaterias)
                    {
                        string codigo = match.Groups["codigo"].Value;
                        string nome = match.Groups["nome"].Value;

                        // Exibe os dados da matéria
                        Console.WriteLine("Código: " + codigo);
                        Console.WriteLine("Nome: " + nome);
                    }


                }
                catch (Exception e)
                {
                    ConsoleColoredLog(ConsoleColor.Yellow, "Não foi encontrado nada!");
                }

            }
            else
            {
                ConsoleColoredLog(ConsoleColor.Red, "Página inválida para execução da coleta!");
            }

            ConsoleColoredLog(ConsoleColor.Cyan, "Finalizando Coleta de Notas...");
        }

        public bool ValidarPaginaParaExecucao()
        {
            if (_driver.Url.Equals(_homeUrl))
                return true;
            else
                return false;
        }





        /*
            MÉTODOS PARA FACILITAR O DESENVOLVIMENTO
        --------------------------------------------------------------------
         
         */

        private bool VerificarElementoPresente(IWebDriver driver, string xpath)
        {
            try
            {
                IWebElement elemento = driver.FindElement(By.XPath(xpath));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }


        private void ConsoleColoredLog(ConsoleColor color, params string[] args)
        {

            Console.ForegroundColor = color;

            foreach (string text in args)
            {
                Console.WriteLine(text);
            }

            Console.ResetColor();

        }








    }
}
