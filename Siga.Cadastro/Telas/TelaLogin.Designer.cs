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
            btnEntrar = new Button();
            lblLogin = new Label();
            panelHeader = new Panel();
            label1 = new Label();
            btnClose = new Button();
            pbxUser = new PictureBox();
            panelLogin = new Panel();
            panel1 = new Panel();
            customMaskedTextBox1 = new Bot.App.Controls.CustomMaskedTextBox();
            customTextBox2 = new Bot.App.Controls.CustomTextBox();
            llblPrimeiroAcesso = new LinkLabel();
            pbxPassword = new PictureBox();
            pbxLogoFatec = new PictureBox();
            lblPreferencias = new Label();
            label3 = new Label();
            label4 = new Label();
            pcbWhatsapp = new PictureBox();
            pcbEmail = new PictureBox();
            customTextBox3 = new Bot.App.Controls.CustomTextBox();
            customMaskedTextBox2 = new Bot.App.Controls.CustomMaskedTextBox();
            panelPreferencias = new Panel();
            label5 = new Label();
            customToggleButton2 = new CustomControls.CustomControls.CustomToggleButton();
            lblAtualizarPorWhatsapp = new Label();
            customToggleButton1 = new CustomControls.CustomControls.CustomToggleButton();
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
            lblSenha.Location = new Point(67, 123);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(47, 19);
            lblSenha.TabIndex = 28;
            lblSenha.Text = "Senha";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblCpf.Location = new Point(68, 63);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(33, 19);
            lblCpf.TabIndex = 27;
            lblCpf.Text = "CPF";
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(66, 84, 96);
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(117, 209);
            btnEntrar.Margin = new Padding(3, 2, 3, 2);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(121, 23);
            btnEntrar.TabIndex = 31;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
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
            panelHeader.Controls.Add(label1);
            panelHeader.Controls.Add(btnClose);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(718, 35);
            panelHeader.TabIndex = 34;
            panelHeader.MouseDown += panelHeader_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(114, 13);
            label1.TabIndex = 35;
            label1.Text = "Marcos G. Junior TCC";
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
            btnClose.Location = new Point(683, 0);
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
            panelLogin.Controls.Add(panel1);
            panelLogin.Controls.Add(customMaskedTextBox1);
            panelLogin.Controls.Add(customTextBox2);
            panelLogin.Controls.Add(llblPrimeiroAcesso);
            panelLogin.Controls.Add(pbxPassword);
            panelLogin.Controls.Add(lblCpf);
            panelLogin.Controls.Add(lblSenha);
            panelLogin.Controls.Add(pbxUser);
            panelLogin.Controls.Add(btnEntrar);
            panelLogin.Dock = DockStyle.Left;
            panelLogin.Location = new Point(0, 35);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(359, 299);
            panelLogin.TabIndex = 37;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblLogin);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(359, 53);
            panel1.TabIndex = 41;
            // 
            // customMaskedTextBox1
            // 
            customMaskedTextBox1.BackColor = SystemColors.Window;
            customMaskedTextBox1.BorderColor = Color.FromArgb(66, 84, 96);
            customMaskedTextBox1.BorderFocusColor = Color.FromArgb(176, 0, 0);
            customMaskedTextBox1.BorderSize = 1;
            customMaskedTextBox1.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            customMaskedTextBox1.ForeColor = Color.DimGray;
            customMaskedTextBox1.Location = new Point(68, 86);
            customMaskedTextBox1.Margin = new Padding(4);
            customMaskedTextBox1.Mask = "000.000.000-00";
            customMaskedTextBox1.Multiline = false;
            customMaskedTextBox1.Name = "customMaskedTextBox1";
            customMaskedTextBox1.Padding = new Padding(7);
            customMaskedTextBox1.PasswordChar = false;
            customMaskedTextBox1.Size = new Size(250, 29);
            customMaskedTextBox1.TabIndex = 40;
            customMaskedTextBox1.Texts = "   ,   ,   -";
            customMaskedTextBox1.UnderlinedStyle = true;
            // 
            // customTextBox2
            // 
            customTextBox2.BackColor = SystemColors.Window;
            customTextBox2.BorderColor = Color.FromArgb(66, 84, 96);
            customTextBox2.BorderFocusColor = Color.FromArgb(176, 0, 0);
            customTextBox2.BorderSize = 1;
            customTextBox2.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            customTextBox2.ForeColor = Color.DimGray;
            customTextBox2.Location = new Point(67, 146);
            customTextBox2.Margin = new Padding(4);
            customTextBox2.Multiline = false;
            customTextBox2.Name = "customTextBox2";
            customTextBox2.Padding = new Padding(7);
            customTextBox2.PasswordChar = true;
            customTextBox2.Size = new Size(250, 29);
            customTextBox2.TabIndex = 39;
            customTextBox2.Texts = "";
            customTextBox2.UnderlinedStyle = true;
            // 
            // llblPrimeiroAcesso
            // 
            llblPrimeiroAcesso.ActiveLinkColor = Color.FromArgb(66, 84, 96);
            llblPrimeiroAcesso.AutoSize = true;
            llblPrimeiroAcesso.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            llblPrimeiroAcesso.LinkColor = Color.Black;
            llblPrimeiroAcesso.Location = new Point(136, 245);
            llblPrimeiroAcesso.Name = "llblPrimeiroAcesso";
            llblPrimeiroAcesso.Size = new Size(88, 13);
            llblPrimeiroAcesso.TabIndex = 37;
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
            // pbxLogoFatec
            // 
            pbxLogoFatec.Image = (Image)resources.GetObject("pbxLogoFatec.Image");
            pbxLogoFatec.Location = new Point(0, 70);
            pbxLogoFatec.Name = "pbxLogoFatec";
            pbxLogoFatec.Size = new Size(319, 147);
            pbxLogoFatec.TabIndex = 38;
            pbxLogoFatec.TabStop = false;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(63, 123);
            label3.Name = "label3";
            label3.Size = new Size(49, 19);
            label3.TabIndex = 40;
            label3.Text = "E-mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(63, 63);
            label4.Name = "label4";
            label4.Size = new Size(72, 19);
            label4.TabIndex = 40;
            label4.Text = "Whatsapp";
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
            // pcbEmail
            // 
            pcbEmail.Image = (Image)resources.GetObject("pcbEmail.Image");
            pcbEmail.Location = new Point(31, 146);
            pcbEmail.Name = "pcbEmail";
            pcbEmail.Size = new Size(25, 25);
            pcbEmail.TabIndex = 40;
            pcbEmail.TabStop = false;
            // 
            // customTextBox3
            // 
            customTextBox3.BackColor = SystemColors.Window;
            customTextBox3.BorderColor = Color.FromArgb(66, 84, 96);
            customTextBox3.BorderFocusColor = Color.FromArgb(176, 0, 0);
            customTextBox3.BorderSize = 1;
            customTextBox3.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            customTextBox3.ForeColor = Color.DimGray;
            customTextBox3.Location = new Point(63, 146);
            customTextBox3.Margin = new Padding(4);
            customTextBox3.Multiline = false;
            customTextBox3.Name = "customTextBox3";
            customTextBox3.Padding = new Padding(7);
            customTextBox3.PasswordChar = false;
            customTextBox3.Size = new Size(250, 29);
            customTextBox3.TabIndex = 40;
            customTextBox3.Texts = "";
            customTextBox3.UnderlinedStyle = true;
            // 
            // customMaskedTextBox2
            // 
            customMaskedTextBox2.BackColor = SystemColors.Window;
            customMaskedTextBox2.BorderColor = Color.FromArgb(66, 84, 96);
            customMaskedTextBox2.BorderFocusColor = Color.FromArgb(176, 0, 0);
            customMaskedTextBox2.BorderSize = 1;
            customMaskedTextBox2.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            customMaskedTextBox2.ForeColor = Color.DimGray;
            customMaskedTextBox2.Location = new Point(63, 86);
            customMaskedTextBox2.Margin = new Padding(4);
            customMaskedTextBox2.Mask = "00 00000-0000";
            customMaskedTextBox2.Multiline = false;
            customMaskedTextBox2.Name = "customMaskedTextBox2";
            customMaskedTextBox2.Padding = new Padding(7);
            customMaskedTextBox2.PasswordChar = false;
            customMaskedTextBox2.Size = new Size(250, 29);
            customMaskedTextBox2.TabIndex = 41;
            customMaskedTextBox2.Texts = "        -";
            customMaskedTextBox2.UnderlinedStyle = true;
            // 
            // panelPreferencias
            // 
            panelPreferencias.Controls.Add(label5);
            panelPreferencias.Controls.Add(customToggleButton2);
            panelPreferencias.Controls.Add(lblAtualizarPorWhatsapp);
            panelPreferencias.Controls.Add(customToggleButton1);
            panelPreferencias.Controls.Add(panel2);
            panelPreferencias.Controls.Add(customMaskedTextBox2);
            panelPreferencias.Controls.Add(customTextBox3);
            panelPreferencias.Controls.Add(pcbEmail);
            panelPreferencias.Controls.Add(pcbWhatsapp);
            panelPreferencias.Controls.Add(label4);
            panelPreferencias.Controls.Add(label3);
            panelPreferencias.Dock = DockStyle.Right;
            panelPreferencias.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            panelPreferencias.Location = new Point(0, 0);
            panelPreferencias.Name = "panelPreferencias";
            panelPreferencias.Size = new Size(359, 299);
            panelPreferencias.TabIndex = 40;
            panelPreferencias.Visible = false;
            panelPreferencias.Paint += panelPreferencias_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(30, 39, 44);
            label5.Location = new Point(82, 237);
            label5.Name = "label5";
            label5.Size = new Size(153, 17);
            label5.TabIndex = 46;
            label5.Text = "Atualizações por E-mail";
            // 
            // customToggleButton2
            // 
            customToggleButton2.Location = new Point(31, 237);
            customToggleButton2.MinimumSize = new Size(45, 22);
            customToggleButton2.Name = "customToggleButton2";
            customToggleButton2.OffBackColor = Color.Gray;
            customToggleButton2.OffToggleColor = Color.Gainsboro;
            customToggleButton2.OnBackColor = Color.FromArgb(66, 84, 96);
            customToggleButton2.OnToggleColor = Color.WhiteSmoke;
            customToggleButton2.Size = new Size(45, 22);
            customToggleButton2.TabIndex = 45;
            customToggleButton2.UseVisualStyleBackColor = true;
            // 
            // lblAtualizarPorWhatsapp
            // 
            lblAtualizarPorWhatsapp.AutoSize = true;
            lblAtualizarPorWhatsapp.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAtualizarPorWhatsapp.ForeColor = Color.FromArgb(30, 39, 44);
            lblAtualizarPorWhatsapp.Location = new Point(82, 208);
            lblAtualizarPorWhatsapp.Name = "lblAtualizarPorWhatsapp";
            lblAtualizarPorWhatsapp.Size = new Size(176, 17);
            lblAtualizarPorWhatsapp.TabIndex = 44;
            lblAtualizarPorWhatsapp.Text = "Atualizações por Whatsapp";
            lblAtualizarPorWhatsapp.TextAlign = ContentAlignment.TopRight;
            // 
            // customToggleButton1
            // 
            customToggleButton1.Location = new Point(31, 208);
            customToggleButton1.MinimumSize = new Size(45, 22);
            customToggleButton1.Name = "customToggleButton1";
            customToggleButton1.OffBackColor = Color.Gray;
            customToggleButton1.OffToggleColor = Color.Gainsboro;
            customToggleButton1.OnBackColor = Color.FromArgb(66, 84, 96);
            customToggleButton1.OnToggleColor = Color.WhiteSmoke;
            customToggleButton1.Size = new Size(45, 22);
            customToggleButton1.TabIndex = 43;
            customToggleButton1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblPreferencias);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(359, 53);
            panel2.TabIndex = 42;
            // 
            // panelLogos
            // 
            panelLogos.Controls.Add(panelPreferencias);
            panelLogos.Controls.Add(pbxLogoFatec);
            panelLogos.Location = new Point(359, 35);
            panelLogos.Name = "panelLogos";
            panelLogos.Size = new Size(359, 299);
            panelLogos.TabIndex = 39;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(718, 334);
            Controls.Add(panelLogos);
            Controls.Add(panelLogin);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
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
        private Button btnEntrar;
        private Label lblLogin;
        private Panel panelHeader;
        private Button btnClose;
        private Label label1;
        private PictureBox pbxUser;
        private Panel panelLogin;
        private LinkLabel llblPrimeiroAcesso;
        private PictureBox pbxPassword;
        private Bot.App.Controls.CustomTextBox customTextBox2;
        private Bot.App.Controls.CustomMaskedTextBox customMaskedTextBox1;
        private PictureBox pbxLogoFatec;
        private Label lblPreferencias;
        private Label label3;
        private Label label4;
        private PictureBox pcbWhatsapp;
        private PictureBox pcbEmail;
        private Bot.App.Controls.CustomTextBox customTextBox3;
        private Bot.App.Controls.CustomMaskedTextBox customMaskedTextBox2;
        private Panel panelPreferencias;
        private Panel panelLogos;
        private Panel panel1;
        private Panel panel2;
        private Label label5;
        private CustomControls.CustomControls.CustomToggleButton customToggleButton2;
        private Label lblAtualizarPorWhatsapp;
        private CustomControls.CustomControls.CustomToggleButton customToggleButton1;
    }
}