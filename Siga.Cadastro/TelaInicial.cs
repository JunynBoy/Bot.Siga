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

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FAZER VALIDAÇÃO, USUÁRIO JÁ LOGADO?

            TelaUserPrincipal telaUserPrincipal = new TelaUserPrincipal();
            //telaUserPrincipal.MdiParent = this;
            telaUserPrincipal.ShowDialog();

        }
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.ShowDialog();

        }

        private void VisibleDgv()
        {
            this.dgvUsuariosLogados.Visible = this.dgvUsuariosLogados.Visible == true ? false : true;
        }

    }
}
