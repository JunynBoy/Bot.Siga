using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace Bot.Core.src.Service
{
    public abstract class SigaSeleniumBot
    {

        protected static WebDriver? _driver;
        protected static Action? _action;

        protected void CreateChromeWithDriverManager(bool headless = false)
        {
            if (_driver != null)
            {
                return;
            }

            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            ChromeOptions options = new ChromeOptions();

            if (headless)
            {
                options.AddArgument("--headless");
                options.AddArgument("--no-sandbox");
                options.AddArgument("--disable-dev-shm-usage");
                options.AddArgument("--disable-gpu"); 
            }

            options.AddArguments("--start-maximized");

            _driver = new ChromeDriver(options);
        }

        protected void ClickOnElementByXpath(string xpath)
        {
            IWebElement elem = _driver!.FindElement(By.XPath(xpath));
            elem.Click();
        }

        protected bool VerificarElementoPresente(string xpath)
        {
            try
            {
                IWebElement elemento = _driver!.FindElement(By.XPath(xpath));
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

        protected String? GetTextEçementByXpath(string xPath)
        {
            try
            {
                IWebElement childElement = _driver!.FindElement(By.XPath(xPath));
                return childElement.Text;
            }
            catch (NoSuchElementException)
            {
                return null;
            }
        }

        protected void Aguardar(int segundos)
        {
            Thread.Sleep(segundos * 1000);
        }

        protected void ScrollToElementByScript(string xpath)
        {
            string scriptScrollIntoView = "arguments[0].scrollIntoView(true);";

            IWebElement elem = _driver!.FindElement(By.XPath(xpath));

            if (elem != null)
                ((IJavaScriptExecutor)_driver).ExecuteScript(scriptScrollIntoView, elem);
        }

        protected void ClickOnElementByScript(string xpath)
        {
            string scriptClick = "arguments[0].click();";

            IWebElement elem = _driver!.FindElement(By.XPath(xpath));

            if (elem != null)
                ((IJavaScriptExecutor)_driver).ExecuteScript(scriptClick, elem);
        }


        protected void AguardarElementoExistir(string xpathElement, int duration = 120)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(duration));
            wait.Until(d => d.FindElements(By.XPath(xpathElement)).Count > 0);
            this.Aguardar(2);
        }

        protected void AguardarElementoDesaparecer(string xpathElement, int duration = 120)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(duration));
            wait.Until(d => d.FindElements(By.XPath(xpathElement)).Count == 0);
            this.Aguardar(2);
        }

        public String? ExtrairTextoPorXPath(string xpath)
        {
            try
            {
                IWebElement elemento = _driver!.FindElement(By.XPath(xpath));
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
                _driver.Quit();
            }
        }


    }
}
