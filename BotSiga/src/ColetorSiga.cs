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
    public class ColetorSiga: SigaSeleniumBot
    {

        private String? _urlLogin;
        private EstudanteService? _estudanteService;
        public String? statusAtualDoBot;
        protected Dictionary<EnumTipoDeExecucao, IColetaModular>? _estrategias;
        private EstrategiaColeta? _estrategiaColeta;


        public ColetorSiga(){}

        public void IniciarColeta( int estudanteId, List<EnumTipoDeExecucao> tipoExecucao, bool headless = false)
        {
            this._estudanteService = new EstudanteService();
            Estudante? estudante = this._estudanteService.GetById(estudanteId);

            if (estudante != null)
            {
                this._estrategiaColeta = new EstrategiaColeta();
                this._urlLogin = ConfigurationManager.AppSettings["urlLogin"];
                this.statusAtualDoBot = "Criando Navegador...";
                this.ColetarDados(tipoExecucao, estudante);
            }
            else
            {
                this.FecharNavegador();
                throw new Exception("Usuário não encontrado");
            }
        }

        private void ColetarDados(List<EnumTipoDeExecucao> TiposExecucao, Estudante estudante)
        {

            this.statusAtualDoBot = "Coletando Dados...";

            try
            {
                if (!this.FazerLogin(estudante))
                    throw new Exception("O não foi validado no siga corretamente! Usuário ou senha podem estar incorretos");

                if (estudante.Autenticado == false)
                {
                    estudante.Autenticado = true;
                    this._estudanteService!.Save(estudante);
                }

                this.Aguardar(2);

                foreach (EnumTipoDeExecucao tipoExecucao in TiposExecucao)
                {
                    var rotina =  this._estrategiaColeta!.ObterEstrategia(tipoExecucao);
                    rotina.ColetarDados(estudante);
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

            this._driver!.Navigate().GoToUrl(this._urlLogin);

            this.Aguardar(2);

            this.PreencherLogin(estudante.Cpf);

            this.PreencherSenha(estudante.Senha);

            this.Aguardar(1);

            IWebElement Confirmar = this._driver!.FindElement(By.XPath(xpathConfirmarLogin));
            Confirmar.Click();

            this.Aguardar(3);
            
            if (this.VerificarElementoPresente(xpathPopUp))
            {
                this._driver!.FindElement(By.XPath(xpathFecharPopUp)).Click();
                this.Aguardar(1);
            }

            if (this.VerificarElementoPresente(xpathLoginInvalido))
            {

                this.statusAtualDoBot = this._driver!.FindElement(By.XPath(xpathLoginInvalido)).Text;
                StringHelper.ConsoleColoredLog(ConsoleColor.Red,
                    $"ERRO: {statusAtualDoBot}",
                    "Fechando o programa...");
                return false;
            }
            return true;
        }

        private void PreencherSenha(string? senha)
        {
            try
            {
                IWebElement Senha = this._driver!.FindElement(By.XPath("//input [@id='vSIS_USUARIOSENHA']"));
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
                IWebElement Login = this._driver!.FindElement(By.XPath("//input [@id='vSIS_USUARIOID']"));
                Login.SendKeys(cpf);
            }catch(Exception e)
            {
                throw new Exception($"ERRO: Não foi possível preencher CPF: {e.Message}");
            }
            
        }


    }
}
