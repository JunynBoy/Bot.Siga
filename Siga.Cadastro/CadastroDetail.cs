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
            string cpf = txtCPF.Text;
            string senha = txtSenha.Text;
            string confirmaSenha = txtConfirmaSenha.Text;
            string email = txtEmail.Text;
            string whatsapp = txtWhatsapp.Text;
            bool receberEmail = cbxAtualizarPeloEmail.Checked;
            bool receberWhatsapp = cbxAtualizarPeloWhatsapp.Checked;

            //fazer lógica de negócio para Telefone ou 



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnJaMeCadastrei_Click(object sender, EventArgs e)
        {

        }
    }
}
