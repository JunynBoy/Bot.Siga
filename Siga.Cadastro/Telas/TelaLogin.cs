using AngleSharp.Html;
using Bot.App.Shared;
using Bot.App.Telas;
using Bot.Core.Model;
using Bot.Core.Service;
using Bot.Core.src.Helper;
using Bot.Core.src.Model;
using Bot.Core.src.Model.Enum;
using Bot.Siga;
using System.Windows.Forms;

namespace Siga.Cadastro
{
    public partial class TelaLogin : Form
    {


        EstudanteService _estudanteService;
        PreferenciaService _preferenciaService; //TODO TIRAR ??

        IniciadorColeta coletor = new IniciadorColeta();
        List<EnumTipoDeExecucao> acoes = new List<EnumTipoDeExecucao>()
        {
            EnumTipoDeExecucao.COLETAR_NOTA,
        };

        public TelaLogin()
        {
            InitializeComponent();

            this._estudanteService =  new EstudanteService();
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
                this.llblPrimeiroAcesso.ForeColor = Color.FromArgb(176, 0, 0);
            }
            else
            {
                this.llblPrimeiroAcesso.ForeColor = Color.FromArgb(66, 84, 96);
            }

            llblPrimeiroAcesso.Refresh(); 
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            this.btnEntrar.Enabled = false;

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
                try
                {
                    Estudante? estudante = this._estudanteService.GetByCpf(this.txtmCPF.Texts.Replace(",","").Replace("-","").Replace(".", ""));
                    if (estudante == null)
                        estudante = new Estudante(this.txtmCPF.Texts.Replace(",", "").Replace("-", "").Replace(".", ""), this.txtSenha.Texts);

                    if (this.panelPreferencias.Visible)
                    {
                        Preferencia preferencia = new Preferencia();
                        preferencia.Whatsapp = this.txtmWhatsapp.Texts;
                        preferencia.Email = this.txtEmail.Texts;
                        preferencia.IsAtualizarPorEmail = this.tbAtualizarPorEmail.Checked;
                        preferencia.IsAtualizarPorWhatsapp = this.tbAtualizarPorWhatsapp.Checked;

                        estudante.Preferencia = preferencia;
                    }


                    if (estudante.Id != 0 && estudante.Autenticado)
                    {
                        if (estudante.Senha!.Equals(txtSenha.Texts))
                        {
                            this.IniciarTelaPrincipal();
                        }
                    }
                    else
                    {
                        if (this.coletor.ValidarLoginSiga(estudante))
                            this.IniciarTelaPrincipal();
                        else
                            CustomMessageBox.CustomMessageBox.Show("Usuario ou senha inválidos, preencha com seu Login do SIGA e tente novamente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                   

                }
                catch (Exception ex)
                {
                    CustomMessageBox.CustomMessageBox.Show($"Não foi possível efetuar login devido a um erro inesperado:\n\nMensagem: {ex.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            this.btnEntrar.Enabled = true;
        }



        private void IniciarTelaPrincipal()
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            telaPrincipal.Show();

            this.Hide();
            telaPrincipal.FormClosed += (s, args) => Application.Exit();
        }

        private bool IsCpfValid(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "").Trim();

            if (cpf.Length != 11 || !long.TryParse(cpf, out _))
            {
                return false;
            }

            return ValidateCpfDigits(cpf);
        }

        private bool ValidateCpfDigits(string cpf)
        {
            int[] weights1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] weights2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                sum += (cpf[i] - '0') * weights1[i];
            }

            int remainder = sum % 11;
            int firstDigit = remainder < 2 ? 0 : 11 - remainder;

            sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += (cpf[i] - '0') * weights2[i];
            }

            remainder = sum % 11;
            int secondDigit = remainder < 2 ? 0 : 11 - remainder;

            return cpf[9] - '0' == firstDigit && cpf[10] - '0' == secondDigit;
        }

        private List<string> isValidLogin()
        {
            List<string> erros = new List<string>();

            if (IsCpfValid(txtmCPF.Texts)) 
            {
               erros.Add("CPF inserido é inválido");
            }

            if (String.IsNullOrEmpty(txtSenha.Texts))
            {
                erros.Add("O Campo Senha Não foi preenchido");
            }

            if (this.panelPreferencias.Visible)
            {
                if (this.tbAtualizarPorEmail.Checked && String.IsNullOrEmpty(txtEmail.Texts))
                {
                    erros.Add("Preencha o campo e-mail");
                }

                if (this.tbAtualizarPorEmail.Checked && !String.IsNullOrEmpty(txtEmail.Texts))
                {
                    if (!StringHelper.IsValidEmail(txtEmail.Texts))
                    {
                        erros.Add("O Formato do E-mail que você digitou é inválido");
                    }
                }

                if (this.tbAtualizarPorWhatsapp.Checked && String.IsNullOrEmpty(txtmWhatsapp.Texts) && txtmWhatsapp.Text.Length != 13)
                {
                    erros.Add("Preencha o número do whatsapp corretamente para receber atualizações");
                }
            }


            return erros;
        }
    }
}
