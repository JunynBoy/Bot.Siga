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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        CadastroDetail cadastroForm;
        TelaLogin loginForm;

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loginForm == null)
            {
                loginForm = new TelaLogin();
                loginForm.MdiParent = this;
                loginForm.Show();
            }
            else
            {
                loginForm.Activate();
            }

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cadastroForm == null)
            {
                cadastroForm = new CadastroDetail();
                cadastroForm.MdiParent = this;
                cadastroForm.Show();
            }
            else
            {
                cadastroForm.Activate();
            }
        }

        private void inicioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}
