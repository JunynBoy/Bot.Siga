﻿using AngleSharp.Html;
using Bot.App.Shared;
using Bot.App.Telas;
using Bot.Core.Model;
using Bot.Core.Service;
using Bot.Core.src.Exceptions;
using Bot.Core.src.Helper;
using Bot.Core.src.Model;
using Bot.Core.src.Model.Enum;
using Bot.Siga;

namespace Siga.Cadastro
{
    public partial class TelaLogin : Form
    {


        EstudanteService _estudanteService;
        LoadingService _loadingService;
        private Panel controlTempLoading;
        private bool primeiroAcesso = false;
        private NotifyIcon? trayIcon;
        

        IniciadorColeta coletor = new IniciadorColeta();
        List<EnumTipoDeExecucao> acoes = new List<EnumTipoDeExecucao>()
        {
            EnumTipoDeExecucao.COLETAR_NOTA,
        };

        public TelaLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this._loadingService = new LoadingService();
            this._estudanteService =  new EstudanteService();


            this.trayIcon = new NotifyIcon
            {
                Text = "AutoSiga",
                Icon = Bot.App.Properties.Resources.BotIco,
                Visible = true
            };
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                this.btnEntrar.PerformClick(); 
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(255, 0, 0);
            this.Dispose();
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NativeMethods.ReleaseCapture();

                NativeMethods.SendMessage(this.Handle, NativeMethods.WM_NCLBUTTONDOWN, NativeMethods.HTCAPTION, 0);
            }
        }

        private void llblPrimeiroAcesso_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.panelPreferencias.Visible = !this.panelPreferencias.Visible;
            if (this.panelPreferencias.Visible)
            {
                primeiroAcesso = true;
                this.llblPrimeiroAcesso.ForeColor = Color.FromArgb(176, 0, 0);
            }
            else
            {
                primeiroAcesso = false;
                this.llblPrimeiroAcesso.ForeColor = Color.FromArgb(66, 84, 96);
            }

            llblPrimeiroAcesso.Refresh(); 
        }

        private async void btnEntrar_Click(object sender, EventArgs e)
        {

            this.btnEntrar.Enabled = false;

            bool estudanteValidado = false;

            List<string> erros = this.isValidLogin();
            if (erros.Any())
            {
                var result = CustomMessageBox.CustomMessageBox.Show(string.Join("\n", erros),
                "Atenção, Erros de validação",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                Estudante? estudante = null;
                this.prepararTelaParaLoading();

                Func<Task> longRunningTask = async () =>
                {
                    try
                    {

                        estudante = null;
                        estudante = this._estudanteService.GetByCpf(this.txtmCPF.Texts.Replace(",", "").Replace("-", "").Replace(".", ""));
                        if (primeiroAcesso && estudante != null)
                            throw new CustomException("Esse CPF Já está cadastrado, basta logar!");

                        if (primeiroAcesso && estudante == null)
                            estudante = new Estudante(this.txtmCPF.Texts.Replace(",", "").Replace("-", "").Replace(".", ""), this.txtSenha.Texts);

                        if (!primeiroAcesso && estudante == null)
                            throw new CustomException("Não existe nenhum usuário cadastrado nesse sistema com este CPF");


                        if (primeiroAcesso)
                        {
                            Preferencia preferencia = new Preferencia();
                            preferencia.Whatsapp = this.txtmWhatsapp.Texts;
                            preferencia.Email = this.txtEmail.Texts;
                            preferencia.IsAtualizarPorEmail = this.tbAtualizarPorEmail.Checked;
                            preferencia.IsAtualizarPorWhatsapp = this.tbAtualizarPorWhatsapp.Checked;
                            estudante.Preferencia = preferencia;


                            IniciadorColeta iniciadorColeta = new IniciadorColeta();
                            
                            estudanteValidado = iniciadorColeta.ValidarLoginSiga(estudante, true);
                          
                            if (!estudanteValidado)
                                throw new CustomException("Usuário ou senha incorretos. Por favor, verifique se suas credenciais são as mesmas do SIGA e tente novamente.");
                        }
                        else if (estudante.Id == 0 && estudante.Autenticado == false && !estudante.Senha!.Equals(txtSenha.Texts.ToString()))
                        {
                            throw new CustomException("Usuário ou senha incorretos. Por favor, verifique se suas credenciais são as mesmas do SIGA e tente novamente.");
                        }
                        else
                        {
                            estudanteValidado = true;
                        }

                        
                    }
                    catch (CustomException ex)
                    {
                        CustomMessageBox.CustomMessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (Exception ex)
                    {
                        CustomMessageBox.CustomMessageBox.Show($"Não foi possível efetuar login\n\nMensagem: {ex.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                };

                await this._loadingService.StartLoadingAsync(controlTempLoading, longRunningTask);
                this.removerLoadingTela();

                if (estudanteValidado)
                {
                    this.IniciarTelaPrincipal(estudante);
                }

            }
            this.btnEntrar.Enabled = true;
        }

        private async void prepararTelaParaLoading()
        {
            this.panelContainer.Visible = false;
            controlTempLoading = new Panel
            {
                Size = this.panelContainer.Size,
                Location = this.panelContainer.Location,
                Dock = DockStyle.Fill
            };

            this.Controls.Add(controlTempLoading);
        }

        private void removerLoadingTela()
        {

            if (controlTempLoading != null)
            {
                this.Controls.Remove(controlTempLoading);
                controlTempLoading = null;
            }

            this.panelContainer.Visible = true;
        }


        private void IniciarTelaPrincipal(Estudante estudante)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal(estudante);
            telaPrincipal.Show();
            this.Hide();
        }

        private bool IsCpfValid(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "").Trim();

            if (cpf.Length != 11 || !long.TryParse(cpf, out _))
            {
                return false;
            }

            return true;
        }


        private List<string> isValidLogin()
        {
            List<string> erros = new List<string>();

            if (!IsCpfValid(txtmCPF.Texts)) 
            {
               erros.Add("CPF inserido é inválido");
            }

            if (String.IsNullOrEmpty(txtSenha.Texts))
            {
                erros.Add("O Campo Senha Não foi preenchido");
            }

            if (this.primeiroAcesso)
            {
                if (String.IsNullOrEmpty(txtEmail.Texts))
                {
                    erros.Add("Preencha o campo e-mail");
                }

                if (!String.IsNullOrEmpty(txtEmail.Texts))
                {
                    if (!StringHelper.IsValidEmail(txtEmail.Texts))
                    {
                        erros.Add("O Formato do E-mail que você digitou é inválido");
                    }
                }

                if (String.IsNullOrEmpty(txtmWhatsapp.Texts) && txtmWhatsapp.Text.Length != 13)
                {
                    erros.Add("Preencha o número do whatsapp corretamente para receber atualizações");
                }
            }


            return erros;
        }
    }
}
