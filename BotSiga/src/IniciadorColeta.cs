using Bot.Core.Model;
using Bot.Core.Service;
using Bot.Core.src.Helper;
using Bot.Core.src.Model.Enum;
using Bot.Core.src.Service;
using Bot.Siga.src.ColetaModular;
using Bot.Siga.src.ColetaModular.Interface;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Configuration;
using static System.Net.Mime.MediaTypeNames;


namespace Bot.Siga
{
    public class IniciadorColeta: SigaSeleniumBot
    {

        private String? _urlLogin;
        public String? statusAtualDoBot;
        protected Dictionary<EnumTipoDeExecucao, IColetaModular>? _estrategias;
        private EstrategiaColeta? _estrategiaColeta;

        private EstudanteService _estudanteService;



        public IniciadorColeta()
        {
            this._estudanteService = new EstudanteService();
            this._urlLogin = ConfigurationManager.AppSettings["urlLogin"];
        }

        public void IniciarColeta(Estudante estudante, List<EnumTipoDeExecucao> tipoExecucao, bool headless = true)
        {

            if (estudante != null)
            {
                this.CreateChromeWithDriverManager(headless);
                this.statusAtualDoBot = "Criando Navegador...";
                this.Executar(tipoExecucao, estudante);

            }
            else
            {
                this.FecharNavegador();
                throw new Exception("Usuário não encontrado");
            }
        }


        public bool ValidarLoginSiga(Estudante estudante,bool headless = true)
        {

            if (estudante != null)
            {
                this.CreateChromeWithDriverManager(headless);
                StringHelper.ConsoleColoredLog(ConsoleColor.Blue,"Iniciando sistema do SIGA para validar o usuário inserido......");
                if (this.FazerLogin(estudante))
                {
                    this.FecharNavegador();
                    return true;
                }
                else
                {
                    this.FecharNavegador();
                    return false;
                }
            }
            else
            {
                this.FecharNavegador();
                throw new Exception("Usuário não encontrado");
            }
        }

        private async void Executar(List<EnumTipoDeExecucao> TiposExecucao, Estudante estudante)
        {

            this.statusAtualDoBot = "Coletando Dados...";

            try
            {
                if (!this.FazerLogin(estudante))
                    throw new Exception("O não foi validado no siga corretamente! Usuário ou senha podem estar incorretos");

                this.Aguardar(2);

                this._estrategiaColeta = new EstrategiaColeta();

                foreach (EnumTipoDeExecucao tipoExecucao in TiposExecucao)
                {
                    var rotina =  this._estrategiaColeta!.ObterEstrategia(tipoExecucao);
                    await rotina.ColetarDados(estudante);
                }

                this.FecharNavegador();
            }
            catch (Exception ex)
            {
                StringHelper.ConsoleColoredLog(ConsoleColor.Red,
                    "Um erro inesperado ocorreu",
                    $"Detalhes do ERRO:{ex.Message}");
                this.FecharNavegador();
            }
        }

        private bool FazerLogin(Estudante estudante)
        {
            string xpathConfirmarLogin = "//input [@value='Confirmar']";
            string xpathLoginInvalido = "//span[@class='ReadonlyAttribute']/text";
            string xpathPopUp = "//div[@class='PopupBorder' and contains(@style, 'visibility: visible')]";
            string xpathFecharPopUp = "//span[@class='PopupHeaderButton']";

            this.statusAtualDoBot = "Fazendo Login...";

            _driver!.Navigate().GoToUrl(this._urlLogin);

            this.Aguardar(2);

            this.PreencherLogin(estudante.Cpf);

            this.PreencherSenha(estudante.Senha);

            this.Aguardar(1);

            IWebElement Confirmar = _driver!.FindElement(By.XPath(xpathConfirmarLogin));
            Confirmar.Click();

            this.Aguardar(3);


            if (this.VerificarElementoPresente(xpathLoginInvalido))
            {
                this.statusAtualDoBot = _driver!.FindElement(By.XPath(xpathLoginInvalido)).Text;
                StringHelper.ConsoleColoredLog(ConsoleColor.Red,
                    $"ERRO: {statusAtualDoBot}",
                    "Fechando o programa...");
                return false;
            }

            if (this.VerificarElementoPresente(xpathPopUp))
            {
                _driver!.FindElement(By.XPath(xpathFecharPopUp)).Click();
                this.Aguardar(1);
            }

            this.ValidarAtributosDoEstudante(estudante);

            return true;
        }

        private void ValidarAtributosDoEstudante(Estudante estudante)
        {
            estudante.Nome = this.GetTextEçementByXpath("(//span[contains(@id, 'PESSOALNOME')])[1]")?.Replace("-", "").Trim();

            estudante.PP = this.GetTextEçementByXpath("(//span[contains(@id, 'ALUNOCURSOINDICEPP')])[1]") + "%";

            estudante.PR = this.GetTextEçementByXpath("(//span[contains(@id, 'ALUNOCURSOINDICEPR')])[1]");

            estudante.Ciclo = this.GetTextEçementByXpath("(//span[contains(@id, 'ALUNOCURSOCICLOATUAL')])[1]");

            estudante.Ra = this.GetTextEçementByXpath("(//span[contains(@id, 'ALUNOCURSOREGISTROACADEMICOCURSO')])[1]");

            estudante.EmailInstitucional = this.GetTextEçementByXpath("(//span[contains(@id, 'INSTITUCIONALFATEC')])[2]");

            if (estudante.Autenticado == false)
                estudante.Autenticado = true;

            this._estudanteService!.Save(estudante);
        }

        private void PreencherSenha(string? senha)
        {
            try
            {
                IWebElement Senha = _driver!.FindElement(By.XPath("//input [@id='vSIS_USUARIOSENHA']"));
                Senha.SendKeys(senha);
            }
            catch(Exception e) 
            { 
                throw new Exception($"ERRO não foi possível preencher o campo de senha: {e.Message}");
            }
        }

        private void PreencherLogin(string? cpf)
        {
            try
            {
                IWebElement Login = _driver!.FindElement(By.XPath("//input [@id='vSIS_USUARIOID']"));
                Login.SendKeys(cpf);
            }catch(Exception e)
            {
                throw new Exception($"ERRO: Não foi possível preencher CPF: {e.Message}");
            }
            
        }


    }
}
