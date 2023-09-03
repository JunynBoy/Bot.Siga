using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




/*
#LOGIN
//input[@id = 'vSIS_USUARIOID']

#SENHA
//input[@id = 'vSIS_USUARIOSENHA']

#NOTAS
//span[@id = 'ygtvlabelel10Span']
//tr[contains(@id, 'ContainerRow')]

#para pegar as médias:
//table[@id = 'Grid4ContainerTbl']/tbody/tr/td/table

#para pegar as notas em detalhes:
//table[@id = 'Grid4ContainerTbl']/tbody/tr/td/div[contains(@id, 'Grid')]


#para pegar o nome das matérias:
//table[@id = 'Grid4ContainerTbl']/tbody/tr/td/table/tbody/tr/td/span[contains(@id,'span_vACD_DISCIPLINANOME')]

#Para pegar os dois ( Notas e disciplina ) :
//table[@id = 'Grid4ContainerTbl']/tbody/tr/td/div[contains(@id, 'Grid')] | //table[@id = 'Grid4ContainerTbl']/tbody/tr/td/table/tbody/tr/td/span[contains(@id,'span_vACD_DISCIPLINANOME')]

#Para pegar os dois ( tudo ):
//table[@id = 'Grid4ContainerTbl']/tbody/tr/td/table | //table[@id = 'Grid4ContainerTbl']/tbody/tr/td/div[contains(@id, 'Grid')]





*/

namespace Bot.Siga.src
{
    internal class Siga
    {

        public IWebDriver driver;
        public WebDriverWait wait;
        public Action action;

        public string urlBase = "https://siga.cps.sp.gov.br/aluno/login.aspx?";



        public void Navegar()
        {

            //CONFIGURANDO NAVEGADOR
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--window-position=1920,0"); 


            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(urlBase);
            this.FazerLogin("48710133836","Mg131730");

            Thread.Sleep(2000);

            this.ColetarNotas();

        }


        public void FazerLogin(string login, string senha)
        {
    
            IWebElement Login = driver.FindElement(By.XPath("//input [@id='vSIS_USUARIOID']"));
            Login.SendKeys(login);


            IWebElement Senha = driver.FindElement(By.XPath("//input [@id='vSIS_USUARIOSENHA']"));
            Senha.SendKeys(senha);

            Thread.Sleep(1000);

            IWebElement Confirmar = driver.FindElement(By.XPath("//input [@value='Confirmar']"));
            Confirmar.Click();

        }

        public void ColetarNotas() 
        {

            IWebElement btnNotas = driver.FindElement(By.XPath("//span[@id = 'ygtvlabelel10Span']"));
            btnNotas.Click();
            Thread.Sleep(1000);

            IList<IWebElement> listaDeNomesNotas = driver.FindElements(By.XPath("//table[@id = 'Grid4ContainerTbl']/tbody/tr/td/table | //table[@id = 'Grid4ContainerTbl']/tbody/tr/td/div[contains(@id, 'Grid')]"));
            foreach (IWebElement NomeNota in listaDeNomesNotas)
            {
                Console.WriteLine(NomeNota.Text);
                //NomeNota.FindElement(By.XPath(""));
            }
            








        }


        





    }
}
