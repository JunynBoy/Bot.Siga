using AngleSharp.Html;
using Bot.App.Shared;
using Bot.Core.Model;
using Bot.Core.Service;
using Bot.Core.src.Helper;
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

            llblPrimeiroAcesso.Refresh(); // Adicione isso
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            List<string> erros = this.isValidLogin();
            if (erros.Any())
            {
                var result = CustomMessageBox.CustomMessageBox.Show(string.Join("\n", erros),
                "Atenção, Erros de validação",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Warning);
                if (result == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
            else
            {
                Estudante estudante = new Estudante();
                if (this.coletor.ValidarLoginSiga(estudante))
                {
                    //liberar acesso
                }
                else
                {
                    //siga consta como usuário inválido, tente novamente
                }
            }
           
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

            if (IsCpfValid(txtmCPF.Text))
            {
               erros.Add("CPF inserido é inválido");
            }

            if (String.IsNullOrEmpty(txtSenha.Text))
            {
                erros.Add("O Campo Senha Não foi preenchido");
            }

            if (this.panelPreferencias.Visible)
            {
                if (this.tbAtualizarPorEmail.Checked && String.IsNullOrEmpty(txtEmail.Text))
                {
                    erros.Add("Preencha o campo e-mail");
                }

                if (this.tbAtualizarPorEmail.Checked && !String.IsNullOrEmpty(txtEmail.Text))
                {
                    if (!StringHelper.IsValidEmail(txtEmail.Text))
                    {
                        erros.Add("O Formato do E-mail que você digitou é inválido");
                    }
                }

                //TODO VERIFICAR SE O ESPAÇO CONTA COMO CARACTER NO LENGTH SE SIM AUMENTAR 1
                if (this.tbAtualizarPorWhatsapp.Checked && String.IsNullOrEmpty(txtmWhatsapp.Text) && txtmWhatsapp.Text.Length != 13)
                {
                    erros.Add("Preencha o número do whatsapp corretamente para receber atualizações");
                }
            }


            return erros;
        }
    }
}
