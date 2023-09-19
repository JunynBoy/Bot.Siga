using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;




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

namespace Bot.Siga
{
    public class BotSiga
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        private Action _action;

        private string urlBase = "https://siga.cps.sp.gov.br/aluno/login.aspx?";

        public BotSiga()
        {

        }

        /*
            ROTINAS DE EXECUÇÃO: --------------------------------------------------------------
            -Parte do código responsável por navegar, clicar me botões e etc....
         */


        public void Navegar()
        {

        }
        public void NavegarCompleto(bool headleass = true)
        {

            try
            {
                IniciarNavegador();
                bool validado = this.FazerLogin("48710133836", "Mg131730", true);
                if (!validado)
                {
                    throw new Exception("O nao foi validado corretamente! Usuário ou senha podem estar incorretos");
                }
                Thread.Sleep(2000);
                this.ColetarNotas(true);
                FecharNavegador();
            }
            catch (Exception ex)
            {
                ConsoleColoredLog(ConsoleColor.Red,
                    "Um erro inesperado ocorreu",
                    $"Detalhes do ERRO:{ex.Message}");
                FecharNavegador();

            }
        }

        //rotina inteira = true quer dizer o método saberá que a rotina inteira está sendo executada então ela dá continuidade
        public bool FazerLogin(string login, string senha, bool RotinaInteira = false , bool headless = true)
        {
            if (!RotinaInteira)
                IniciarNavegador();

            Thread.Sleep(2000);

            IWebElement Login = _driver.FindElement(By.XPath("//input [@id='vSIS_USUARIOID']"));
            Login.SendKeys(login);


            IWebElement Senha = _driver.FindElement(By.XPath("//input [@id='vSIS_USUARIOSENHA']"));
            Senha.SendKeys(senha);

            Thread.Sleep(1000);

            IWebElement Confirmar = _driver.FindElement(By.XPath("//input [@value='Confirmar']"));
            Confirmar.Click();


            if (VerificarElementoPresente(this._driver, "//text[text()='Não confere Login e Senha']"))
            {
                ConsoleColoredLog(ConsoleColor.Yellow, "A Senha está incorreta!!",
                    "Fechando o programa...");
                return false;
            }
            else if (!RotinaInteira)
            {
               FecharNavegador();
               return true;
            }

            return true;




        }

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

        public void ColetarNotas(bool rotinaInteira = false)
        {
            if (!rotinaInteira)
            {
                //iniciar navegador e Logar antes
            }
            IWebElement btnNotas = _driver.FindElement(By.XPath("//span[@id = 'ygtvlabelel10Span']"));
            btnNotas.Click();
            Thread.Sleep(1000);

            IList<IWebElement> listaDeNomesNotas = _driver.FindElements(By.XPath("//table[@id = 'Grid4ContainerTbl']/tbody/tr/td/table | //table[@id = 'Grid4ContainerTbl']/tbody/tr/td/div[contains(@id, 'Grid')]"));
            foreach (IWebElement NomeNota in listaDeNomesNotas)
            {
                Console.WriteLine(NomeNota.Text);
                //NomeNota.FindElement(By.XPath(""));
            }

        }














        /*
            MÉTODOS PARA FACILITAR O DESENVOLVIMENTO
        --------------------------------------------------------------------
         
         
         */





        private void IniciarNavegador(bool headless = false)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--window-position=1920,0");
            if (headless)
            {
                options.AddArgument("-headless");
            }
            _driver = new ChromeDriver(options);
            this._driver.Manage().Window.Maximize();
            this._driver.Navigate().GoToUrl(urlBase);
        }

        private void FecharNavegador()
        {
            if (_driver != null)
            {
                this._driver.Quit();
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
