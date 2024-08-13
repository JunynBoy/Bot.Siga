using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using WebDriverManager.Helpers;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;

namespace Bot.Core.src.Service
{
    public class SigaSeleniumBot
    {

        protected WebDriver _driver;
        protected Action _action;

        public SigaSeleniumBot()
        {
            this.CreateChromeWithDriverManager(false);
        }

        protected void CreateChromeWithDriverManager(bool headless = false)
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            ChromeOptions options = new ChromeOptions();

            if (headless)
                options.AddArguments("--headless");

            options.AddArguments("--start-maximized");
           
            this._driver = new ChromeDriver(options);
        }

        protected bool VerificarElementoPresente(string xpath)
        {
            try
            {
                IWebElement elemento = this._driver!.FindElement(By.XPath(xpath));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        protected bool IsElementPresentInElement(IWebElement element, string xpath)
        {
            try
            {
                IWebElement childElement = element.FindElement(By.XPath(xpath));
                return childElement.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        protected void Aguardar(int segundos)
        {
            Thread.Sleep(segundos * 1000);
        }

        protected void ScrollToElementByScript(string xpath)
        {
            string scriptScrollIntoView = "arguments[0].scrollIntoView(true);";

            IWebElement elem = this._driver!.FindElement(By.XPath(xpath));

            if (elem != null)
                ((IJavaScriptExecutor)this._driver).ExecuteScript(scriptScrollIntoView, elem);
        }

        protected void ClickOnElementByScript(string xpath)
        {
            string scriptClick = "arguments[0].click();";

            IWebElement elem = this._driver!.FindElement(By.XPath(xpath));

            if (elem != null)
                ((IJavaScriptExecutor)this._driver).ExecuteScript(scriptClick, elem);
        }


        protected void AguardarElementoExistir(string xpathElement, int duration = 120)
        {
            WebDriverWait wait = new WebDriverWait(this._driver, TimeSpan.FromSeconds(duration));
            wait.Until(d => d.FindElements(By.XPath(xpathElement)).Count > 0);
            this.Aguardar(2);
        }

        protected void AguardarElementoDesaparecer(string xpathElement, int duration = 120)
        {
            WebDriverWait wait = new WebDriverWait(this._driver, TimeSpan.FromSeconds(duration));
            wait.Until(d => d.FindElements(By.XPath(xpathElement)).Count == 0);
            this.Aguardar(2);
        }

        public String? ExtrairTextoPorXPath(string xpath)
        {
            try
            {
                IWebElement elemento = this._driver!.FindElement(By.XPath(xpath));
                return elemento.Text;
            }
            catch (NoSuchElementException)
            {
                throw new Exception($"ERRO!: nenhum elemento encontrado no xpath = {xpath}");
            }
        }

        protected void FecharNavegador()
        {
            if (_driver != null)
            {
                this._driver.Quit();
            }
        }


    }
}
