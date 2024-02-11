using Bot.Siga.src.Interface;
using Microsoft.IdentityModel.Tokens;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Configuration;

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


                    IList<IWebElement> listaDeNomesNotas = _driver.FindElements(By.XPath("//table[@id = 'Grid4ContainerTbl']/tbody/tr/td/table | //table[@id = 'Grid4ContainerTbl']/tbody/tr/td/div[contains(@id, 'Grid')]"));
                    int num = listaDeNomesNotas.Count() / 2;
                    //div[@id = 'Grid1ContainerDiv_0008']
                    //tr[@id = 'Grid4ContainerRow_0008']

                    foreach (IWebElement NomeNota in listaDeNomesNotas)
                    {
                        Console.WriteLine(NomeNota.Text);
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
            string teste = _driver.Url;
            if (teste.Equals(_homeUrl))
            {
                return true;
            }
            else
            {
                return false;
            }


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
