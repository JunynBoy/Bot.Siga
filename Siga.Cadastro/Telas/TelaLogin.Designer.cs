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
            lblWindowTitle = new Label();
            btnClose = new Button();
            pbxUser = new PictureBox();
            panelLogin = new Panel();
            btnEntrar = new Bot.App.Controls.CustomButton();
            panelSubHeaderLoginSiga = new Panel();
            txtmCPF = new Bot.App.Controls.CustomMaskedTextBox();
            txtSenha = new Bot.App.Controls.CustomTextBox();
            llblPrimeiroAcesso = new LinkLabel();
            pbxPassword = new PictureBox();
            panelContainer = new Panel();
            panelLogos = new Panel();
            panelPreferencias = new Panel();
            lblAtualizarPorEmail = new Label();
            tbAtualizarPorEmail = new CustomControls.CustomControls.CustomToggleButton();
            lblAtualizarPorWhatsapp = new Label();
            tbAtualizarPorWhatsapp = new CustomControls.CustomControls.CustomToggleButton();
            panelSubHeaderPreferencias = new Panel();
            lblPreferencias = new Label();
            txtmWhatsapp = new Bot.App.Controls.CustomMaskedTextBox();
            txtEmail = new Bot.App.Controls.CustomTextBox();
            pcbEmail = new PictureBox();
            pcbWhatsapp = new PictureBox();
            lblWhatsapp = new Label();
            lblEmail = new Label();
            pbxLogoFatec = new PictureBox();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxUser).BeginInit();
            panelLogin.SuspendLayout();
            panelSubHeaderLoginSiga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxPassword).BeginInit();
            panelContainer.SuspendLayout();
            panelLogos.SuspendLayout();
            panelPreferencias.SuspendLayout();
            panelSubHeaderPreferencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbWhatsapp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxLogoFatec).BeginInit();
            SuspendLayout();
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblSenha.Location = new Point(67, 123);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(47, 19);
            lblSenha.TabIndex = 0;
            lblSenha.Text = "Senha";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblCpf.Location = new Point(68, 63);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(33, 19);
            lblCpf.TabIndex = 0;
            lblCpf.Text = "CPF";
            // 
            // lblLogin
            // 
            lblLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.FromArgb(30, 39, 44);
            lblLogin.Location = new Point(115, 13);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(106, 25);
            lblLogin.TabIndex = 32;
            lblLogin.Text = "Login Siga";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(66, 84, 96);
            panelHeader.Controls.Add(lblWindowTitle);
            panelHeader.Controls.Add(btnClose);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(724, 35);
            panelHeader.TabIndex = 34;
            panelHeader.MouseDown += panelHeader_MouseDown;
            // 
            // lblWindowTitle
            // 
            lblWindowTitle.AutoSize = true;
            lblWindowTitle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblWindowTitle.ForeColor = Color.White;
            lblWindowTitle.Location = new Point(12, 10);
            lblWindowTitle.Name = "lblWindowTitle";
            lblWindowTitle.Size = new Size(116, 15);
            lblWindowTitle.TabIndex = 35;
            lblWindowTitle.Text = "Mensageiro do SIGA";
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
            btnClose.Location = new Point(689, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 35);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pbxUser
            // 
            pbxUser.Image = (Image)resources.GetObject("pbxUser.Image");
            pbxUser.Location = new Point(36, 90);
            pbxUser.Name = "pbxUser";
            pbxUser.Size = new Size(25, 25);
            pbxUser.TabIndex = 35;
            pbxUser.TabStop = false;
            // 
            // panelLogin
            // 
            panelLogin.Controls.Add(btnEntrar);
            panelLogin.Controls.Add(panelSubHeaderLoginSiga);
            panelLogin.Controls.Add(txtmCPF);
            panelLogin.Controls.Add(txtSenha);
            panelLogin.Controls.Add(llblPrimeiroAcesso);
            panelLogin.Controls.Add(pbxPassword);
            panelLogin.Controls.Add(lblCpf);
            panelLogin.Controls.Add(lblSenha);
            panelLogin.Controls.Add(pbxUser);
            panelLogin.Dock = DockStyle.Left;
            panelLogin.Location = new Point(0, 0);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(358, 302);
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
            btnEntrar.Location = new Point(115, 209);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(121, 23);
            btnEntrar.TabIndex = 3;
            btnEntrar.Text = "Entrar";
            btnEntrar.TextColor = Color.White;
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // panelSubHeaderLoginSiga
            // 
            panelSubHeaderLoginSiga.Controls.Add(lblLogin);
            panelSubHeaderLoginSiga.Dock = DockStyle.Top;
            panelSubHeaderLoginSiga.Location = new Point(0, 0);
            panelSubHeaderLoginSiga.Name = "panelSubHeaderLoginSiga";
            panelSubHeaderLoginSiga.Size = new Size(358, 53);
            panelSubHeaderLoginSiga.TabIndex = 41;
            // 
            // txtmCPF
            // 
            txtmCPF.BackColor = SystemColors.Window;
            txtmCPF.BorderColor = Color.FromArgb(66, 84, 96);
            txtmCPF.BorderFocusColor = Color.FromArgb(176, 0, 0);
            txtmCPF.BorderSize = 1;
            txtmCPF.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtmCPF.ForeColor = Color.DimGray;
            txtmCPF.Location = new Point(68, 86);
            txtmCPF.Margin = new Padding(4);
            txtmCPF.Mask = "000.000.000-00";
            txtmCPF.Multiline = false;
            txtmCPF.Name = "txtmCPF";
            txtmCPF.Padding = new Padding(7);
            txtmCPF.PasswordChar = false;
            txtmCPF.Size = new Size(250, 29);
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
            txtSenha.Location = new Point(67, 146);
            txtSenha.Margin = new Padding(4);
            txtSenha.Multiline = false;
            txtSenha.Name = "txtSenha";
            txtSenha.Padding = new Padding(7);
            txtSenha.PasswordChar = true;
            txtSenha.Size = new Size(250, 29);
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
            llblPrimeiroAcesso.Location = new Point(133, 246);
            llblPrimeiroAcesso.Name = "llblPrimeiroAcesso";
            llblPrimeiroAcesso.Size = new Size(88, 13);
            llblPrimeiroAcesso.TabIndex = 4;
            llblPrimeiroAcesso.TabStop = true;
            llblPrimeiroAcesso.Text = "Primeiro Acesso";
            llblPrimeiroAcesso.VisitedLinkColor = Color.FromArgb(178, 0, 0);
            llblPrimeiroAcesso.LinkClicked += llblPrimeiroAcesso_LinkClicked;
            // 
            // pbxPassword
            // 
            pbxPassword.Image = (Image)resources.GetObject("pbxPassword.Image");
            pbxPassword.Location = new Point(36, 146);
            pbxPassword.Name = "pbxPassword";
            pbxPassword.Size = new Size(25, 25);
            pbxPassword.TabIndex = 36;
            pbxPassword.TabStop = false;
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(panelLogos);
            panelContainer.Controls.Add(panelLogin);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 35);
            panelContainer.Margin = new Padding(3, 2, 3, 2);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(724, 302);
            panelContainer.TabIndex = 40;
            // 
            // panelLogos
            // 
            panelLogos.Controls.Add(panelPreferencias);
            panelLogos.Controls.Add(pbxLogoFatec);
            panelLogos.Dock = DockStyle.Fill;
            panelLogos.Location = new Point(358, 0);
            panelLogos.Name = "panelLogos";
            panelLogos.Size = new Size(366, 302);
            panelLogos.TabIndex = 39;
            // 
            // panelPreferencias
            // 
            panelPreferencias.Controls.Add(lblAtualizarPorEmail);
            panelPreferencias.Controls.Add(tbAtualizarPorEmail);
            panelPreferencias.Controls.Add(lblAtualizarPorWhatsapp);
            panelPreferencias.Controls.Add(tbAtualizarPorWhatsapp);
            panelPreferencias.Controls.Add(panelSubHeaderPreferencias);
            panelPreferencias.Controls.Add(txtmWhatsapp);
            panelPreferencias.Controls.Add(txtEmail);
            panelPreferencias.Controls.Add(pcbEmail);
            panelPreferencias.Controls.Add(pcbWhatsapp);
            panelPreferencias.Controls.Add(lblWhatsapp);
            panelPreferencias.Controls.Add(lblEmail);
            panelPreferencias.Dock = DockStyle.Fill;
            panelPreferencias.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            panelPreferencias.Location = new Point(0, 0);
            panelPreferencias.Name = "panelPreferencias";
            panelPreferencias.Size = new Size(366, 302);
            panelPreferencias.TabIndex = 40;
            panelPreferencias.Visible = false;
            // 
            // lblAtualizarPorEmail
            // 
            lblAtualizarPorEmail.AutoSize = true;
            lblAtualizarPorEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAtualizarPorEmail.ForeColor = Color.FromArgb(30, 39, 44);
            lblAtualizarPorEmail.Location = new Point(82, 237);
            lblAtualizarPorEmail.Name = "lblAtualizarPorEmail";
            lblAtualizarPorEmail.Size = new Size(153, 17);
            lblAtualizarPorEmail.TabIndex = 0;
            lblAtualizarPorEmail.Text = "Atualizações por E-mail";
            // 
            // tbAtualizarPorEmail
            // 
            tbAtualizarPorEmail.Location = new Point(31, 237);
            tbAtualizarPorEmail.MinimumSize = new Size(45, 22);
            tbAtualizarPorEmail.Name = "tbAtualizarPorEmail";
            tbAtualizarPorEmail.OffBackColor = Color.Gray;
            tbAtualizarPorEmail.OffToggleColor = Color.Gainsboro;
            tbAtualizarPorEmail.OnBackColor = Color.FromArgb(66, 84, 96);
            tbAtualizarPorEmail.OnToggleColor = Color.WhiteSmoke;
            tbAtualizarPorEmail.Size = new Size(45, 22);
            tbAtualizarPorEmail.TabIndex = 8;
            tbAtualizarPorEmail.UseVisualStyleBackColor = true;
            // 
            // lblAtualizarPorWhatsapp
            // 
            lblAtualizarPorWhatsapp.AutoSize = true;
            lblAtualizarPorWhatsapp.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAtualizarPorWhatsapp.ForeColor = Color.FromArgb(30, 39, 44);
            lblAtualizarPorWhatsapp.Location = new Point(82, 208);
            lblAtualizarPorWhatsapp.Name = "lblAtualizarPorWhatsapp";
            lblAtualizarPorWhatsapp.Size = new Size(176, 17);
            lblAtualizarPorWhatsapp.TabIndex = 0;
            lblAtualizarPorWhatsapp.Text = "Atualizações por Whatsapp";
            lblAtualizarPorWhatsapp.TextAlign = ContentAlignment.TopRight;
            // 
            // tbAtualizarPorWhatsapp
            // 
            tbAtualizarPorWhatsapp.Location = new Point(31, 208);
            tbAtualizarPorWhatsapp.MinimumSize = new Size(45, 22);
            tbAtualizarPorWhatsapp.Name = "tbAtualizarPorWhatsapp";
            tbAtualizarPorWhatsapp.OffBackColor = Color.Gray;
            tbAtualizarPorWhatsapp.OffToggleColor = Color.Gainsboro;
            tbAtualizarPorWhatsapp.OnBackColor = Color.FromArgb(66, 84, 96);
            tbAtualizarPorWhatsapp.OnToggleColor = Color.WhiteSmoke;
            tbAtualizarPorWhatsapp.Size = new Size(45, 22);
            tbAtualizarPorWhatsapp.TabIndex = 7;
            tbAtualizarPorWhatsapp.UseVisualStyleBackColor = true;
            // 
            // panelSubHeaderPreferencias
            // 
            panelSubHeaderPreferencias.Controls.Add(lblPreferencias);
            panelSubHeaderPreferencias.Dock = DockStyle.Top;
            panelSubHeaderPreferencias.Location = new Point(0, 0);
            panelSubHeaderPreferencias.Name = "panelSubHeaderPreferencias";
            panelSubHeaderPreferencias.Size = new Size(366, 53);
            panelSubHeaderPreferencias.TabIndex = 42;
            // 
            // lblPreferencias
            // 
            lblPreferencias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPreferencias.AutoSize = true;
            lblPreferencias.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPreferencias.ForeColor = Color.FromArgb(30, 39, 44);
            lblPreferencias.Location = new Point(123, 13);
            lblPreferencias.Name = "lblPreferencias";
            lblPreferencias.Size = new Size(121, 25);
            lblPreferencias.TabIndex = 40;
            lblPreferencias.Text = "Preferências";
            // 
            // txtmWhatsapp
            // 
            txtmWhatsapp.BackColor = SystemColors.Window;
            txtmWhatsapp.BorderColor = Color.FromArgb(66, 84, 96);
            txtmWhatsapp.BorderFocusColor = Color.FromArgb(176, 0, 0);
            txtmWhatsapp.BorderSize = 1;
            txtmWhatsapp.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtmWhatsapp.ForeColor = Color.DimGray;
            txtmWhatsapp.Location = new Point(63, 86);
            txtmWhatsapp.Margin = new Padding(4);
            txtmWhatsapp.Mask = "00 00000-0000";
            txtmWhatsapp.Multiline = false;
            txtmWhatsapp.Name = "txtmWhatsapp";
            txtmWhatsapp.Padding = new Padding(7);
            txtmWhatsapp.PasswordChar = false;
            txtmWhatsapp.Size = new Size(250, 29);
            txtmWhatsapp.TabIndex = 5;
            txtmWhatsapp.Texts = "        -";
            txtmWhatsapp.UnderlinedStyle = true;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.Window;
            txtEmail.BorderColor = Color.FromArgb(66, 84, 96);
            txtEmail.BorderFocusColor = Color.FromArgb(176, 0, 0);
            txtEmail.BorderSize = 1;
            txtEmail.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.ForeColor = Color.DimGray;
            txtEmail.Location = new Point(63, 146);
            txtEmail.Margin = new Padding(4);
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(7);
            txtEmail.PasswordChar = false;
            txtEmail.Size = new Size(250, 29);
            txtEmail.TabIndex = 6;
            txtEmail.Texts = "";
            txtEmail.UnderlinedStyle = true;
            // 
            // pcbEmail
            // 
            pcbEmail.Image = (Image)resources.GetObject("pcbEmail.Image");
            pcbEmail.Location = new Point(31, 146);
            pcbEmail.Name = "pcbEmail";
            pcbEmail.Size = new Size(25, 25);
            pcbEmail.TabIndex = 40;
            pcbEmail.TabStop = false;
            // 
            // pcbWhatsapp
            // 
            pcbWhatsapp.Image = (Image)resources.GetObject("pcbWhatsapp.Image");
            pcbWhatsapp.Location = new Point(31, 90);
            pcbWhatsapp.Name = "pcbWhatsapp";
            pcbWhatsapp.Size = new Size(25, 25);
            pcbWhatsapp.TabIndex = 40;
            pcbWhatsapp.TabStop = false;
            // 
            // lblWhatsapp
            // 
            lblWhatsapp.AutoSize = true;
            lblWhatsapp.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblWhatsapp.Location = new Point(63, 63);
            lblWhatsapp.Name = "lblWhatsapp";
            lblWhatsapp.Size = new Size(72, 19);
            lblWhatsapp.TabIndex = 0;
            lblWhatsapp.Text = "Whatsapp";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(63, 123);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 19);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "E-mail";
            // 
            // pbxLogoFatec
            // 
            pbxLogoFatec.Dock = DockStyle.Fill;
            pbxLogoFatec.Image = (Image)resources.GetObject("pbxLogoFatec.Image");
            pbxLogoFatec.Location = new Point(0, 0);
            pbxLogoFatec.Name = "pbxLogoFatec";
            pbxLogoFatec.Size = new Size(366, 302);
            pbxLogoFatec.TabIndex = 38;
            pbxLogoFatec.TabStop = false;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(724, 337);
            Controls.Add(panelContainer);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaLogin";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxUser).EndInit();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            panelSubHeaderLoginSiga.ResumeLayout(false);
            panelSubHeaderLoginSiga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxPassword).EndInit();
            panelContainer.ResumeLayout(false);
            panelLogos.ResumeLayout(false);
            panelPreferencias.ResumeLayout(false);
            panelPreferencias.PerformLayout();
            panelSubHeaderPreferencias.ResumeLayout(false);
            panelSubHeaderPreferencias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbWhatsapp).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxLogoFatec).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblSenha;
        private Label lblCpf;
        private Label lblLogin;
        private Panel panelHeader;
        private Button btnClose;
        private Label lblWindowTitle;
        private PictureBox pbxUser;
        private Panel panelLogin;
        private LinkLabel llblPrimeiroAcesso;
        private PictureBox pbxPassword;
        private Bot.App.Controls.CustomTextBox txtSenha;
        private Bot.App.Controls.CustomMaskedTextBox txtmCPF;
        private Panel panelSubHeaderLoginSiga;
        private Bot.App.Controls.CustomButton btnEntrar;
        private Panel panelLogos;
        private Panel panelPreferencias;
        private Label lblAtualizarPorEmail;
        private CustomControls.CustomControls.CustomToggleButton tbAtualizarPorEmail;
        private Label lblAtualizarPorWhatsapp;
        private CustomControls.CustomControls.CustomToggleButton tbAtualizarPorWhatsapp;
        private Panel panelSubHeaderPreferencias;
        private Label lblPreferencias;
        private Bot.App.Controls.CustomMaskedTextBox txtmWhatsapp;
        private Bot.App.Controls.CustomTextBox txtEmail;
        private PictureBox pcbEmail;
        private PictureBox pcbWhatsapp;
        private Label lblWhatsapp;
        private Label lblEmail;
        private PictureBox pbxLogoFatec;
        private Panel panelContainer;
    }
}