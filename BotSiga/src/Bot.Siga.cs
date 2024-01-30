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
        private string _cpf;
        private string _senha;
        private IWebDriver _driver;
        private WebDriverWait _wait;
        private Action _action;

        private string urlBase = "https://siga.cps.sp.gov.br/aluno/login.aspx?";

        public BotSiga(bool headless = false)
        {
            this._cpf = "48710133836";
            this._senha = "Mg131730";
            IniciarNavegador(headless);
        }

        /*
            ROTINAS DE EXECUÇÃO: --------------------------------------------------------------
            -Parte do código responsável por navegar, clicar me botões e etc....
         */

        public void NavegarCompleto()
        {

            try
            {
                bool validado = this.FazerLogin(this._cpf, this._senha);
                if (!validado)
                {
                    throw new Exception("O nao foi validado corretamente! Usuário ou senha podem estar incorretos");
                }
                Thread.Sleep(2000);
                this.ColetarNotas();
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
        public bool FazerLogin(string login, string senha, bool headless = true)
        {

            //atributos booleanos que dizem se o aluno vai querer coletar 
            //notas
            //faltas

            
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
            return true;

        }



        public void ColetarNotas()
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

            }catch (Exception e)
            {
                Console.WriteLine("Nao foi encontrado nenhuma nota!!!!" , e.Message);
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
