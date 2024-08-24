using Bot.Core.Model;
using Bot.Core.src.Helper;
using Bot.Siga.src.ColetaModular.Interface;
using Microsoft.IdentityModel.Tokens;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Configuration;

namespace Bot.Siga.src.ColetaModular
{
    public class ColetorFaltas : ColetorSiga , IColetaModular
    {
        private string? _homeUrl;

        public ColetorFaltas()
        {
            this._homeUrl = ConfigurationManager.AppSettings["urlHome"];
        }

        public void ColetarDados(Estudante estudante)
        {
            StringHelper.ConsoleColoredLog(ConsoleColor.Cyan, "Iniciando Coleta de Faltas...");

            if (ValidarPaginaParaExecucao())
            {
                try
                {

                    IWebElement btnNotas = _driver!.FindElement(By.XPath("//span[@id = 'ygtvlabelel10Span']"));
                    btnNotas.Click();
                    this.Aguardar(1);

                    IList<IWebElement> listaDeNomesNotas = _driver.FindElements(By.XPath("//table[@id = 'Grid4ContainerTbl']/tbody/tr/td/table | //table[@id = 'Grid4ContainerTbl']/tbody/tr/td/div[contains(@id, 'Grid')]"));
                    int num = listaDeNomesNotas.Count() / 2;
                    //div[@id = 'Grid1ContainerDiv_0008']x
                    //tr[@id = 'Grid4ContainerRow_0008']

                    foreach (IWebElement NomeNota in listaDeNomesNotas)
                    {
                        Console.WriteLine(NomeNota.Text);
                    }

                }
                catch (Exception e)
                {
                    StringHelper.ConsoleColoredLog(ConsoleColor.Yellow, $"Não foi encontrado nada:{e.Message}");
                }

            }
            else
            {
                StringHelper.ConsoleColoredLog(ConsoleColor.Red, "Página inválida para execução da coleta!");
            }

            StringHelper.ConsoleColoredLog(ConsoleColor.Cyan, "Finalizando Coleta de Faltas...");
        }

        public bool ValidarPaginaParaExecucao()
        {
            string teste = _driver!.Url;
            if (!teste.Equals(_homeUrl))
            {
                return true;
            }
            else
            {
                return false;
            }


        }



    }
}
