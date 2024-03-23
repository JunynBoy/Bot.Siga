namespace Siga.Cadastro
{
    partial class TelaInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            TSMIUsuarioPrincipal = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            horarioDeProcuraToolStripMenuItem = new ToolStripMenuItem();
            adicionarToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            logOutToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            txtUsrPrincipalStatus = new ToolStripTextBox();
            toolTip1 = new ToolTip(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(30, 30);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, adicionarToolStripMenuItem, toolStripMenuItem3, toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem4, txtUsrPrincipalStatus });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1010, 38);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { TSMIUsuarioPrincipal, loginToolStripMenuItem, horarioDeProcuraToolStripMenuItem });
            inicioToolStripMenuItem.Image = (Image)resources.GetObject("inicioToolStripMenuItem.Image");
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(42, 34);
            // 
            // TSMIUsuarioPrincipal
            // 
            TSMIUsuarioPrincipal.Name = "TSMIUsuarioPrincipal";
            TSMIUsuarioPrincipal.Size = new Size(174, 22);
            TSMIUsuarioPrincipal.Text = "Usuario Principal";
            TSMIUsuarioPrincipal.Click += cadastroToolStripMenuItem_Click;
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(174, 22);
            loginToolStripMenuItem.Text = "Usuário comúm";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // horarioDeProcuraToolStripMenuItem
            // 
            horarioDeProcuraToolStripMenuItem.Name = "horarioDeProcuraToolStripMenuItem";
            horarioDeProcuraToolStripMenuItem.Size = new Size(174, 22);
            horarioDeProcuraToolStripMenuItem.Text = "Horario de procura";
            // 
            // adicionarToolStripMenuItem
            // 
            adicionarToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            adicionarToolStripMenuItem.Image = (Image)resources.GetObject("adicionarToolStripMenuItem.Image");
            adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            adicionarToolStripMenuItem.Size = new Size(42, 34);
            adicionarToolStripMenuItem.Click += adicionarToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { logOutToolStripMenuItem1 });
            toolStripMenuItem3.Image = (Image)resources.GetObject("toolStripMenuItem3.Image");
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(42, 34);
            // 
            // logOutToolStripMenuItem1
            // 
            logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            logOutToolStripMenuItem1.Size = new Size(114, 22);
            logOutToolStripMenuItem1.Text = "LogOut";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Image = (Image)resources.GetObject("toolStripMenuItem1.Image");
            toolStripMenuItem1.Margin = new Padding(120, 0, 0, 0);
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(42, 34);
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Image = (Image)resources.GetObject("toolStripMenuItem2.Image");
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(42, 34);
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Image = (Image)resources.GetObject("toolStripMenuItem4.Image");
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(42, 34);
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // txtUsrPrincipalStatus
            // 
            txtUsrPrincipalStatus.AutoToolTip = true;
            txtUsrPrincipalStatus.Margin = new Padding(120, 0, 1, 0);
            txtUsrPrincipalStatus.Name = "txtUsrPrincipalStatus";
            txtUsrPrincipalStatus.Size = new Size(176, 34);
            txtUsrPrincipalStatus.Text = "Usuário Principal:";
            txtUsrPrincipalStatus.Visible = false;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 601);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "TelaInicial";
            Text = "TelaInicial";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem adicionarToolStripMenuItem;
        private ToolTip toolTip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem TSMIUsuarioPrincipal;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem logOutToolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripTextBox txtUsrPrincipalStatus;
        private ToolStripMenuItem horarioDeProcuraToolStripMenuItem;
    }
}