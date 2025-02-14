﻿using Bot.Core.Model;
using Bot.Core.Service;
using Bot.Core.src.Model.Enum;
using Bot.Core.src.Service;
using Bot.Siga.src.ColetaModular.Interface;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;
using System.Configuration;


namespace Bot.Siga
{
    public class IniciadorColeta: SigaSeleniumBot
    {

        private String? _urlLogin;
        public String? statusAtualDoBot;
        protected Dictionary<EnumTipoDeExecucao, IColetaModular>? _estrategias;
        private EstrategiaColeta? _estrategiaColeta;
        private EstudanteService _estudanteService;

        private Action<string> logAction;

        public IniciadorColeta()
        {
            this._estudanteService = new EstudanteService();
            this._urlLogin = ConfigurationManager.AppSettings["urlLogin"];
        }

        public void SetLogAction(Action<string> log)
        {

            Console.WriteLine(log.ToString());
            this.logAction = log;
        }

        public void Log(params string[] args)
        {
            foreach(var message in args)
            {
                logAction?.Invoke($"{message} - {DateTime.Now:dd/MM HH:mm}\n");
                Console.WriteLine(message);
            }
        }

        public void Log(string message)
        {
            logAction?.Invoke($"{message} - {DateTime.Now:dd/MM HH:mm}\n");
        }


        public void IniciarColeta(Estudante estudante, List<EnumTipoDeExecucao> tipoExecucao, bool headless = true)
        {

            if (estudante != null)
            {
                Log("Iniciando coleta para o estudante " + estudante.Nome);
                Log("Criando Navegador...");
                this.CreateChromeWithDriverManager(headless);
                this.Executar(tipoExecucao, estudante);

            }
            else
            {
                Log("Estudante não encontrado");
                this.FecharNavegador();
                throw new Exception("Usuário não encontrado");
            }
        }


        public bool ValidarLoginSiga(Estudante estudante,bool headless = true)
        {
            if (estudante != null)
            {
                this.CreateChromeWithDriverManager(headless);
                Log("Iniciando sistema do SIGA para validar o usuário inserido......");
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

        private void Executar(List<EnumTipoDeExecucao> TiposExecucao, Estudante estudante)
        {

            Log("Iniciando Coleta");

            try
            {

                bool logado = this.FazerLogin(estudante);
                if (!logado)
                  throw new Exception("Não foi possível efetuar o login corretamente ");

                this.Aguardar(2);

                this._estrategiaColeta = new EstrategiaColeta();

                foreach (EnumTipoDeExecucao tipoExecucao in TiposExecucao)
                {
                    var rotina =  this._estrategiaColeta!.ObterEstrategia(tipoExecucao);
                    Log($"Coletando {this.GetTipoExecucaoLabel(tipoExecucao)}!");
                    rotina.ColetarDados(estudante);
                    Log($"Coleta de {this.GetTipoExecucaoLabel(tipoExecucao)} Finalizada!");
                }

                this.FecharNavegador();
            }
            catch (Exception ex)
            {
                Log("Um erro inesperado ocorreu",
                    $"Detalhes do ERRO:{ex.Message}");
                this.FecharNavegador();
            }
        }

        private string GetTipoExecucaoLabel(EnumTipoDeExecucao tipoExecucao)
        {
            string label = "Desconhecido..";
            if (tipoExecucao == EnumTipoDeExecucao.COLETAR_FALTA)
            {
                label = "Faltas";
            }

            if (tipoExecucao == EnumTipoDeExecucao.COLETAR_NOTA)
            {
                label = "Notas";
            }

            if (tipoExecucao == EnumTipoDeExecucao.COLETAR_MATERIA)
            {
                label = "Matérias";
            }

            return label;
        }

        private bool FazerLogin(Estudante estudante)
        {
            string xpathConfirmarLogin = "//input [@value='Confirmar']";
            string xpathLoginInvalido = "//span[@class='ReadonlyAttribute']/text";
            string xpathInternalServerError = "//h1[contains(text(), 'Server Error')]";
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

            if (this.VerificarElementoPresente(xpathInternalServerError))
            {
                throw new Exception ("Sistema do SIGA se encontra fora do ar no momento, tente novamente mais tarde");
            }


            if (this.VerificarElementoPresente(xpathLoginInvalido))
            {
                this.statusAtualDoBot = _driver!.FindElement(By.XPath(xpathLoginInvalido)).Text;
                Log($"ERRO: {statusAtualDoBot}");
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
            estudante.Nome = this.GetTextElementByXpath("(//span[contains(@id, 'PESSOALNOME')])[1]")?.Replace("-", "").Trim();

            estudante.PP = this.GetTextElementByXpath("(//span[contains(@id, 'ALUNOCURSOINDICEPP')])[1]") + "%";

            estudante.PR = this.GetTextElementByXpath("(//span[contains(@id, 'ALUNOCURSOINDICEPR')])[1]");

            estudante.Ciclo = this.GetTextElementByXpath("(//span[contains(@id, 'ALUNOCURSOCICLOATUAL')])[1]");

            estudante.Ra = this.GetTextElementByXpath("(//span[contains(@id, 'ALUNOCURSOREGISTROACADEMICOCURSO')])[1]");

            estudante.EmailInstitucional = this.GetTextElementByXpath("(//span[contains(@id, 'INSTITUCIONALFATEC')])[2]");
            
            estudante.Cursado = this.GetTextElementByXpath("(//span[contains(@title, 'Numero de semestres efetivamente cursados')])[2]");
            estudante.Faltam = this.GetTextElementByXpath("(//span[contains(@title, 'Numero de semestres que faltam para o estudante completar seu curso sem estourar o prazo de integralização, incluindo o corrente caso esteja matriculado.')])[2]");
            estudante.Maximo = this.GetTextElementByXpath("//span[contains(@class, 'ReadonlyAttribute') and contains(@title, 'Prazo máximo') and contains(@id, 'INTEGRALIZACAOMAX')]");

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
