namespace Siga.Cadastro
{
    partial class CadastroDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public bool IsMdiContainer { get; set; }

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
            btnCadastrar = new Button();
            lblCadastro = new Label();
            lblLogin = new Label();
            lblSenha = new Label();
            lblConfirmaSenha = new Label();
            label1 = new Label();
            cbxTermos = new CheckBox();
            txtCPF = new MaskedTextBox();
            txtSenha = new MaskedTextBox();
            txtConfirmaSenha = new MaskedTextBox();
            txtEmail = new MaskedTextBox();
            txtWhatsapp = new MaskedTextBox();
            lblWhatsapp = new Label();
            cbxAtualizarPeloWhatsapp = new CheckBox();
            cbxAtualizarPeloEmail = new CheckBox();
            txtNome = new MaskedTextBox();
            lblNome = new Label();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(284, 294);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(184, 23);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = " Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblCadastro
            // 
            lblCadastro.AutoSize = true;
            lblCadastro.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCadastro.Location = new Point(160, 20);
            lblCadastro.Name = "lblCadastro";
            lblCadastro.Size = new Size(162, 18);
            lblCadastro.TabIndex = 3;
            lblCadastro.Text = "Faça seu cadastro:";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(83, 94);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(34, 15);
            lblLogin.TabIndex = 4;
            lblLogin.Text = "CPF :";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(74, 130);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(45, 15);
            lblSenha.TabIndex = 5;
            lblSenha.Text = "Senha :";
            // 
            // lblConfirmaSenha
            // 
            lblConfirmaSenha.AutoSize = true;
            lblConfirmaSenha.Location = new Point(11, 166);
            lblConfirmaSenha.Name = "lblConfirmaSenha";
            lblConfirmaSenha.Size = new Size(106, 15);
            lblConfirmaSenha.TabIndex = 6;
            lblConfirmaSenha.Text = "Confirme a senha :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 201);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 8;
            label1.Text = "E-mail :";
            // 
            // cbxTermos
            // 
            cbxTermos.AutoSize = true;
            cbxTermos.Location = new Point(123, 259);
            cbxTermos.Name = "cbxTermos";
            cbxTermos.Size = new Size(199, 19);
            cbxTermos.TabIndex = 10;
            cbxTermos.Text = "Concordo com os termos de uso";
            cbxTermos.UseVisualStyleBackColor = true;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(123, 92);
            txtCPF.Mask = "000.000.000-00";
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(246, 23);
            txtCPF.TabIndex = 12;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(123, 127);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(246, 23);
            txtSenha.TabIndex = 16;
            // 
            // txtConfirmaSenha
            // 
            txtConfirmaSenha.Location = new Point(123, 164);
            txtConfirmaSenha.Name = "txtConfirmaSenha";
            txtConfirmaSenha.PasswordChar = '*';
            txtConfirmaSenha.Size = new Size(246, 23);
            txtConfirmaSenha.TabIndex = 18;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(123, 199);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(246, 23);
            txtEmail.TabIndex = 19;
            // 
            // txtWhatsapp
            // 
            txtWhatsapp.Location = new Point(123, 225);
            txtWhatsapp.Mask = "+00 (00)00000-0000";
            txtWhatsapp.Name = "txtWhatsapp";
            txtWhatsapp.Size = new Size(246, 23);
            txtWhatsapp.TabIndex = 22;
            // 
            // lblWhatsapp
            // 
            lblWhatsapp.AutoSize = true;
            lblWhatsapp.Location = new Point(50, 227);
            lblWhatsapp.Name = "lblWhatsapp";
            lblWhatsapp.Size = new Size(69, 15);
            lblWhatsapp.TabIndex = 21;
            lblWhatsapp.Text = "Whatsapp : ";
            // 
            // cbxAtualizarPeloWhatsapp
            // 
            cbxAtualizarPeloWhatsapp.AutoSize = true;
            cbxAtualizarPeloWhatsapp.Location = new Point(375, 229);
            cbxAtualizarPeloWhatsapp.Name = "cbxAtualizarPeloWhatsapp";
            cbxAtualizarPeloWhatsapp.Size = new Size(154, 19);
            cbxAtualizarPeloWhatsapp.TabIndex = 23;
            cbxAtualizarPeloWhatsapp.Text = "Atualizar pelo Whatsapp";
            cbxAtualizarPeloWhatsapp.UseVisualStyleBackColor = true;
            cbxAtualizarPeloWhatsapp.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // cbxAtualizarPeloEmail
            // 
            cbxAtualizarPeloEmail.AutoSize = true;
            cbxAtualizarPeloEmail.Location = new Point(375, 203);
            cbxAtualizarPeloEmail.Name = "cbxAtualizarPeloEmail";
            cbxAtualizarPeloEmail.Size = new Size(135, 19);
            cbxAtualizarPeloEmail.TabIndex = 24;
            cbxAtualizarPeloEmail.Text = "Atualizar pelo E-mail";
            cbxAtualizarPeloEmail.UseVisualStyleBackColor = true;
            cbxAtualizarPeloEmail.CheckedChanged += cbxAtualizarPeloEmail_CheckedChanged;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(123, 61);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(246, 23);
            txtNome.TabIndex = 26;
            txtNome.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // lblNome
            // 
            lblNome.AutoEllipsis = true;
            lblNome.AutoSize = true;
            lblNome.Location = new Point(74, 61);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(46, 15);
            lblNome.TabIndex = 25;
            lblNome.Text = "Nome :";
            lblNome.Click += label2_Click;
            // 
            // CadastroDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 344);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(cbxAtualizarPeloEmail);
            Controls.Add(cbxAtualizarPeloWhatsapp);
            Controls.Add(txtWhatsapp);
            Controls.Add(lblWhatsapp);
            Controls.Add(txtEmail);
            Controls.Add(txtConfirmaSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtCPF);
            Controls.Add(cbxTermos);
            Controls.Add(label1);
            Controls.Add(lblConfirmaSenha);
            Controls.Add(lblSenha);
            Controls.Add(lblLogin);
            Controls.Add(lblCadastro);
            Controls.Add(btnCadastrar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "CadastroDetail";
            Text = "CadastroDetail";
            Load += CadastroDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrar;
        private Label lblCadastro;
        private Label lblLogin;
        private Label lblSenha;
        private Label lblConfirmaSenha;
        private Label label1;
        private CheckBox cbxTermos;
        private MaskedTextBox txtCPF;
        private MaskedTextBox txtSenha;
        private MaskedTextBox txtConfirmaSenha;
        private MaskedTextBox txtEmail;
        private MaskedTextBox txtWhatsapp;
        private Label lblWhatsapp;
        private CheckBox cbxAtualizarPeloWhatsapp;
        private CheckBox cbxAtualizarPeloEmail;
        private MaskedTextBox txtNome;
        private Label lblNome;
    }
}