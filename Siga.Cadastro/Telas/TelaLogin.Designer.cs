namespace Siga.Cadastro
{
    partial class TelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            lblSenha = new Label();
            lblCpf = new Label();
            lblLogin = new Label();
            panelHeader = new Panel();
            label1 = new Label();
            btnClose = new Button();
            pbxUser = new PictureBox();
            panelLogin = new Panel();
            btnEntrar = new Bot.App.Controls.CustomButton();
            panel1 = new Panel();
            txtmCPF = new Bot.App.Controls.CustomMaskedTextBox();
            txtSenha = new Bot.App.Controls.CustomTextBox();
            llblPrimeiroAcesso = new LinkLabel();
            pbxPassword = new PictureBox();
            pbxLogoFatec = new PictureBox();
            lblPreferencias = new Label();
            label3 = new Label();
            label4 = new Label();
            pcbWhatsapp = new PictureBox();
            pcbEmail = new PictureBox();
            txtEmail = new Bot.App.Controls.CustomTextBox();
            txtmWhatsapp = new Bot.App.Controls.CustomMaskedTextBox();
            panelPreferencias = new Panel();
            label5 = new Label();
            tbAtualizarPorEmail = new CustomControls.CustomControls.CustomToggleButton();
            lblAtualizarPorWhatsapp = new Label();
            tbAtualizarPorWhatsapp = new CustomControls.CustomControls.CustomToggleButton();
            panel2 = new Panel();
            panelLogos = new Panel();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxUser).BeginInit();
            panelLogin.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxLogoFatec).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbWhatsapp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbEmail).BeginInit();
            panelPreferencias.SuspendLayout();
            panel2.SuspendLayout();
            panelLogos.SuspendLayout();
            SuspendLayout();
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblSenha.Location = new Point(77, 164);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(57, 23);
            lblSenha.TabIndex = 0;
            lblSenha.Text = "Senha";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblCpf.Location = new Point(78, 84);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(40, 23);
            lblCpf.TabIndex = 0;
            lblCpf.Text = "CPF";
            // 
            // lblLogin
            // 
            lblLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.FromArgb(30, 39, 44);
            lblLogin.Location = new Point(131, 17);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(133, 32);
            lblLogin.TabIndex = 32;
            lblLogin.Text = "Login Siga";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(66, 84, 96);
            panelHeader.Controls.Add(label1);
            panelHeader.Controls.Add(btnClose);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 4, 3, 4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(821, 47);
            panelHeader.TabIndex = 34;
            panelHeader.MouseDown += panelHeader_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 13);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 35;
            label1.Text = "Mensageiro do SIGA";
            // 
            // btnClose
            // 
            btnClose.BackgroundImageLayout = ImageLayout.None;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 0, 0);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(216, 0, 0);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(781, 0);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 47);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pbxUser
            // 
            pbxUser.Image = (Image)resources.GetObject("pbxUser.Image");
            pbxUser.Location = new Point(41, 120);
            pbxUser.Margin = new Padding(3, 4, 3, 4);
            pbxUser.Name = "pbxUser";
            pbxUser.Size = new Size(29, 33);
            pbxUser.TabIndex = 35;
            pbxUser.TabStop = false;
            // 
            // panelLogin
            // 
            panelLogin.Controls.Add(btnEntrar);
            panelLogin.Controls.Add(panel1);
            panelLogin.Controls.Add(txtmCPF);
            panelLogin.Controls.Add(txtSenha);
            panelLogin.Controls.Add(llblPrimeiroAcesso);
            panelLogin.Controls.Add(pbxPassword);
            panelLogin.Controls.Add(lblCpf);
            panelLogin.Controls.Add(lblSenha);
            panelLogin.Controls.Add(pbxUser);
            panelLogin.Dock = DockStyle.Left;
            panelLogin.Location = new Point(0, 47);
            panelLogin.Margin = new Padding(3, 4, 3, 4);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(410, 398);
            panelLogin.TabIndex = 37;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(66, 84, 96);
            btnEntrar.BackgroundColor = Color.FromArgb(66, 84, 96);
            btnEntrar.BorderColor = Color.FromArgb(64, 64, 64);
            btnEntrar.BorderRadius = 3;
            btnEntrar.BorderSize = 1;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(131, 279);
            btnEntrar.Margin = new Padding(3, 4, 3, 4);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(138, 31);
            btnEntrar.TabIndex = 3;
            btnEntrar.Text = "Entrar";
            btnEntrar.TextColor = Color.White;
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblLogin);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 71);
            panel1.TabIndex = 41;
            // 
            // txtmCPF
            // 
            txtmCPF.BackColor = SystemColors.Window;
            txtmCPF.BorderColor = Color.FromArgb(66, 84, 96);
            txtmCPF.BorderFocusColor = Color.FromArgb(176, 0, 0);
            txtmCPF.BorderSize = 1;
            txtmCPF.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtmCPF.ForeColor = Color.DimGray;
            txtmCPF.Location = new Point(78, 115);
            txtmCPF.Margin = new Padding(5);
            txtmCPF.Mask = "000.000.000-00";
            txtmCPF.Multiline = false;
            txtmCPF.Name = "txtmCPF";
            txtmCPF.Padding = new Padding(8, 9, 8, 9);
            txtmCPF.PasswordChar = false;
            txtmCPF.Size = new Size(286, 38);
            txtmCPF.TabIndex = 1;
            txtmCPF.Texts = "   ,   ,   -";
            txtmCPF.UnderlinedStyle = true;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.Window;
            txtSenha.BorderColor = Color.FromArgb(66, 84, 96);
            txtSenha.BorderFocusColor = Color.FromArgb(176, 0, 0);
            txtSenha.BorderSize = 1;
            txtSenha.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtSenha.ForeColor = Color.DimGray;
            txtSenha.Location = new Point(77, 195);
            txtSenha.Margin = new Padding(5);
            txtSenha.Multiline = false;
            txtSenha.Name = "txtSenha";
            txtSenha.Padding = new Padding(8, 9, 8, 9);
            txtSenha.PasswordChar = true;
            txtSenha.Size = new Size(286, 38);
            txtSenha.TabIndex = 2;
            txtSenha.Texts = "";
            txtSenha.UnderlinedStyle = true;
            // 
            // llblPrimeiroAcesso
            // 
            llblPrimeiroAcesso.ActiveLinkColor = Color.FromArgb(66, 84, 96);
            llblPrimeiroAcesso.AutoSize = true;
            llblPrimeiroAcesso.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            llblPrimeiroAcesso.LinkColor = Color.Black;
            llblPrimeiroAcesso.Location = new Point(152, 328);
            llblPrimeiroAcesso.Name = "llblPrimeiroAcesso";
            llblPrimeiroAcesso.Size = new Size(109, 19);
            llblPrimeiroAcesso.TabIndex = 4;
            llblPrimeiroAcesso.TabStop = true;
            llblPrimeiroAcesso.Text = "Primeiro Acesso";
            llblPrimeiroAcesso.VisitedLinkColor = Color.FromArgb(178, 0, 0);
            llblPrimeiroAcesso.LinkClicked += llblPrimeiroAcesso_LinkClicked;
            // 
            // pbxPassword
            // 
            pbxPassword.Image = (Image)resources.GetObject("pbxPassword.Image");
            pbxPassword.Location = new Point(41, 195);
            pbxPassword.Margin = new Padding(3, 4, 3, 4);
            pbxPassword.Name = "pbxPassword";
            pbxPassword.Size = new Size(29, 33);
            pbxPassword.TabIndex = 36;
            pbxPassword.TabStop = false;
            // 
            // pbxLogoFatec
            // 
            pbxLogoFatec.Image = (Image)resources.GetObject("pbxLogoFatec.Image");
            pbxLogoFatec.Location = new Point(0, 93);
            pbxLogoFatec.Margin = new Padding(3, 4, 3, 4);
            pbxLogoFatec.Name = "pbxLogoFatec";
            pbxLogoFatec.Size = new Size(365, 196);
            pbxLogoFatec.TabIndex = 38;
            pbxLogoFatec.TabStop = false;
            // 
            // lblPreferencias
            // 
            lblPreferencias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPreferencias.AutoSize = true;
            lblPreferencias.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPreferencias.ForeColor = Color.FromArgb(30, 39, 44);
            lblPreferencias.Location = new Point(141, 17);
            lblPreferencias.Name = "lblPreferencias";
            lblPreferencias.Size = new Size(155, 32);
            lblPreferencias.TabIndex = 40;
            lblPreferencias.Text = "Preferências";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(72, 164);
            label3.Name = "label3";
            label3.Size = new Size(58, 23);
            label3.TabIndex = 0;
            label3.Text = "E-mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(72, 84);
            label4.Name = "label4";
            label4.Size = new Size(87, 23);
            label4.TabIndex = 0;
            label4.Text = "Whatsapp";
            // 
            // pcbWhatsapp
            // 
            pcbWhatsapp.Image = (Image)resources.GetObject("pcbWhatsapp.Image");
            pcbWhatsapp.Location = new Point(35, 120);
            pcbWhatsapp.Margin = new Padding(3, 4, 3, 4);
            pcbWhatsapp.Name = "pcbWhatsapp";
            pcbWhatsapp.Size = new Size(29, 33);
            pcbWhatsapp.TabIndex = 40;
            pcbWhatsapp.TabStop = false;
            // 
            // pcbEmail
            // 
            pcbEmail.Image = (Image)resources.GetObject("pcbEmail.Image");
            pcbEmail.Location = new Point(35, 195);
            pcbEmail.Margin = new Padding(3, 4, 3, 4);
            pcbEmail.Name = "pcbEmail";
            pcbEmail.Size = new Size(29, 33);
            pcbEmail.TabIndex = 40;
            pcbEmail.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.Window;
            txtEmail.BorderColor = Color.FromArgb(66, 84, 96);
            txtEmail.BorderFocusColor = Color.FromArgb(176, 0, 0);
            txtEmail.BorderSize = 1;
            txtEmail.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.ForeColor = Color.DimGray;
            txtEmail.Location = new Point(72, 195);
            txtEmail.Margin = new Padding(5);
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(8, 9, 8, 9);
            txtEmail.PasswordChar = false;
            txtEmail.Size = new Size(286, 38);
            txtEmail.TabIndex = 6;
            txtEmail.Texts = "";
            txtEmail.UnderlinedStyle = true;
            // 
            // txtmWhatsapp
            // 
            txtmWhatsapp.BackColor = SystemColors.Window;
            txtmWhatsapp.BorderColor = Color.FromArgb(66, 84, 96);
            txtmWhatsapp.BorderFocusColor = Color.FromArgb(176, 0, 0);
            txtmWhatsapp.BorderSize = 1;
            txtmWhatsapp.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtmWhatsapp.ForeColor = Color.DimGray;
            txtmWhatsapp.Location = new Point(72, 115);
            txtmWhatsapp.Margin = new Padding(5);
            txtmWhatsapp.Mask = "00 00000-0000";
            txtmWhatsapp.Multiline = false;
            txtmWhatsapp.Name = "txtmWhatsapp";
            txtmWhatsapp.Padding = new Padding(8, 9, 8, 9);
            txtmWhatsapp.PasswordChar = false;
            txtmWhatsapp.Size = new Size(286, 38);
            txtmWhatsapp.TabIndex = 5;
            txtmWhatsapp.Texts = "        -";
            txtmWhatsapp.UnderlinedStyle = true;
            // 
            // panelPreferencias
            // 
            panelPreferencias.Controls.Add(label5);
            panelPreferencias.Controls.Add(tbAtualizarPorEmail);
            panelPreferencias.Controls.Add(lblAtualizarPorWhatsapp);
            panelPreferencias.Controls.Add(tbAtualizarPorWhatsapp);
            panelPreferencias.Controls.Add(panel2);
            panelPreferencias.Controls.Add(txtmWhatsapp);
            panelPreferencias.Controls.Add(txtEmail);
            panelPreferencias.Controls.Add(pcbEmail);
            panelPreferencias.Controls.Add(pcbWhatsapp);
            panelPreferencias.Controls.Add(label4);
            panelPreferencias.Controls.Add(label3);
            panelPreferencias.Dock = DockStyle.Right;
            panelPreferencias.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            panelPreferencias.Location = new Point(0, 0);
            panelPreferencias.Margin = new Padding(3, 4, 3, 4);
            panelPreferencias.Name = "panelPreferencias";
            panelPreferencias.Size = new Size(410, 399);
            panelPreferencias.TabIndex = 40;
            panelPreferencias.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(30, 39, 44);
            label5.Location = new Point(94, 316);
            label5.Name = "label5";
            label5.Size = new Size(198, 23);
            label5.TabIndex = 0;
            label5.Text = "Atualizações por E-mail";
            // 
            // tbAtualizarPorEmail
            // 
            tbAtualizarPorEmail.Location = new Point(35, 316);
            tbAtualizarPorEmail.Margin = new Padding(3, 4, 3, 4);
            tbAtualizarPorEmail.MinimumSize = new Size(51, 29);
            tbAtualizarPorEmail.Name = "tbAtualizarPorEmail";
            tbAtualizarPorEmail.OffBackColor = Color.Gray;
            tbAtualizarPorEmail.OffToggleColor = Color.Gainsboro;
            tbAtualizarPorEmail.OnBackColor = Color.FromArgb(66, 84, 96);
            tbAtualizarPorEmail.OnToggleColor = Color.WhiteSmoke;
            tbAtualizarPorEmail.Size = new Size(51, 29);
            tbAtualizarPorEmail.TabIndex = 8;
            tbAtualizarPorEmail.UseVisualStyleBackColor = true;
            // 
            // lblAtualizarPorWhatsapp
            // 
            lblAtualizarPorWhatsapp.AutoSize = true;
            lblAtualizarPorWhatsapp.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAtualizarPorWhatsapp.ForeColor = Color.FromArgb(30, 39, 44);
            lblAtualizarPorWhatsapp.Location = new Point(94, 277);
            lblAtualizarPorWhatsapp.Name = "lblAtualizarPorWhatsapp";
            lblAtualizarPorWhatsapp.Size = new Size(228, 23);
            lblAtualizarPorWhatsapp.TabIndex = 0;
            lblAtualizarPorWhatsapp.Text = "Atualizações por Whatsapp";
            lblAtualizarPorWhatsapp.TextAlign = ContentAlignment.TopRight;
            // 
            // tbAtualizarPorWhatsapp
            // 
            tbAtualizarPorWhatsapp.Location = new Point(35, 277);
            tbAtualizarPorWhatsapp.Margin = new Padding(3, 4, 3, 4);
            tbAtualizarPorWhatsapp.MinimumSize = new Size(51, 29);
            tbAtualizarPorWhatsapp.Name = "tbAtualizarPorWhatsapp";
            tbAtualizarPorWhatsapp.OffBackColor = Color.Gray;
            tbAtualizarPorWhatsapp.OffToggleColor = Color.Gainsboro;
            tbAtualizarPorWhatsapp.OnBackColor = Color.FromArgb(66, 84, 96);
            tbAtualizarPorWhatsapp.OnToggleColor = Color.WhiteSmoke;
            tbAtualizarPorWhatsapp.Size = new Size(51, 29);
            tbAtualizarPorWhatsapp.TabIndex = 7;
            tbAtualizarPorWhatsapp.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblPreferencias);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(410, 71);
            panel2.TabIndex = 42;
            // 
            // panelLogos
            // 
            panelLogos.Controls.Add(panelPreferencias);
            panelLogos.Controls.Add(pbxLogoFatec);
            panelLogos.Location = new Point(410, 47);
            panelLogos.Margin = new Padding(3, 4, 3, 4);
            panelLogos.Name = "panelLogos";
            panelLogos.Size = new Size(410, 399);
            panelLogos.TabIndex = 39;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(821, 445);
            Controls.Add(panelLogos);
            Controls.Add(panelLogin);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaLogin";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxUser).EndInit();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxLogoFatec).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbWhatsapp).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbEmail).EndInit();
            panelPreferencias.ResumeLayout(false);
            panelPreferencias.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelLogos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lblSenha;
        private Label lblCpf;
        private Label lblLogin;
        private Panel panelHeader;
        private Button btnClose;
        private Label label1;
        private PictureBox pbxUser;
        private Panel panelLogin;
        private LinkLabel llblPrimeiroAcesso;
        private PictureBox pbxPassword;
        private Bot.App.Controls.CustomTextBox txtSenha;
        private Bot.App.Controls.CustomMaskedTextBox txtmCPF;
        private PictureBox pbxLogoFatec;
        private Label lblPreferencias;
        private Label label3;
        private Label label4;
        private PictureBox pcbWhatsapp;
        private PictureBox pcbEmail;
        private Bot.App.Controls.CustomTextBox txtEmail;
        private Bot.App.Controls.CustomMaskedTextBox txtmWhatsapp;
        private Panel panelPreferencias;
        private Panel panelLogos;
        private Panel panel1;
        private Panel panel2;
        private Label label5;
        private CustomControls.CustomControls.CustomToggleButton tbAtualizarPorEmail;
        private Label lblAtualizarPorWhatsapp;
        private CustomControls.CustomControls.CustomToggleButton tbAtualizarPorWhatsapp;
        private Bot.App.Controls.CustomButton btnEntrar;
    }
}