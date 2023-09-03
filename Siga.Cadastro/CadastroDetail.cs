using Bot.Core.Service;
using Bot.Core.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siga.Cadastro
{
    public partial class CadastroDetail : Form
    {

        private AlunoService _alunoService;
        public CadastroDetail()
        {

            InitializeComponent();
            this._alunoService = new AlunoService();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cpf = txtCPF.Text;
            string senha = txtSenha.Text;
            string confirmaSenha = txtConfirmaSenha.Text;
            string email = txtEmail.Text;
            string whatsapp = txtWhatsapp.Text;
            bool atualizarPorEmail = cbxAtualizarPeloEmail.Checked;
            bool atualizarPorWhatsapp = cbxAtualizarPeloWhatsapp.Checked;
            bool termos = cbxTermos.Checked;
            try
            {
                if (!termos)
                    throw new ArgumentException("Para usar a apicação é necessário concordar com os termos de uso!");
                Aluno aluno = new(nome, senha, email, atualizarPorEmail, cpf, whatsapp, atualizarPorWhatsapp);
                this._alunoService.Save(aluno);
                MessageBox.Show("Usuário salvo com sucesso");
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnJaMeCadastrei_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void cbxAtualizarPeloEmail_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CadastroDetail_Load(object sender, EventArgs e)
        {

        }
    }
}
