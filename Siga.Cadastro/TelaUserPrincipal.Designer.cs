namespace Siga.Cadastro
{
    partial class TelaUserPrincipal
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
            btnCadastrar.Location = new Point(325, 392);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(210, 31);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "Adicionar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblCadastro
            // 
            lblCadastro.AutoSize = true;
            lblCadastro.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCadastro.Location = new Point(161, 27);
            lblCadastro.Name = "lblCadastro";
            lblCadastro.Size = new Size(302, 23);
            lblCadastro.TabIndex = 3;
            lblCadastro.Text = "Adicionar Usuário principal";
            lblCadastro.Click += lblCadastro_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(95, 125);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(40, 20);
            lblLogin.TabIndex = 4;
            lblLogin.Text = "CPF :";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(85, 173);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(56, 20);
            lblSenha.TabIndex = 5;
            lblSenha.Text = "Senha :";
            // 
            // lblConfirmaSenha
            // 
            lblConfirmaSenha.AutoSize = true;
            lblConfirmaSenha.Location = new Point(13, 221);
            lblConfirmaSenha.Name = "lblConfirmaSenha";
            lblConfirmaSenha.Size = new Size(131, 20);
            lblConfirmaSenha.TabIndex = 6;
            lblConfirmaSenha.Text = "Confirme a senha :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 268);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 8;
            label1.Text = "E-mail :";
            // 
            // cbxTermos
            // 
            cbxTermos.AutoSize = true;
            cbxTermos.Location = new Point(141, 345);
            cbxTermos.Margin = new Padding(3, 4, 3, 4);
            cbxTermos.Name = "cbxTermos";
            cbxTermos.Size = new Size(246, 24);
            cbxTermos.TabIndex = 10;
            cbxTermos.Text = "Concordo com os termos de uso";
            cbxTermos.UseVisualStyleBackColor = true;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(141, 123);
            txtCPF.Margin = new Padding(3, 4, 3, 4);
            txtCPF.Mask = "000.000.000-00";
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(281, 27);
            txtCPF.TabIndex = 12;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(141, 169);
            txtSenha.Margin = new Padding(3, 4, 3, 4);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(281, 27);
            txtSenha.TabIndex = 16;
            // 
            // txtConfirmaSenha
            // 
            txtConfirmaSenha.Location = new Point(141, 219);
            txtConfirmaSenha.Margin = new Padding(3, 4, 3, 4);
            txtConfirmaSenha.Name = "txtConfirmaSenha";
            txtConfirmaSenha.PasswordChar = '*';
            txtConfirmaSenha.Size = new Size(281, 27);
            txtConfirmaSenha.TabIndex = 18;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(141, 265);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(281, 27);
            txtEmail.TabIndex = 19;
            // 
            // txtWhatsapp
            // 
            txtWhatsapp.Location = new Point(141, 300);
            txtWhatsapp.Margin = new Padding(3, 4, 3, 4);
            txtWhatsapp.Mask = "+00 (00)00000-0000";
            txtWhatsapp.Name = "txtWhatsapp";
            txtWhatsapp.Size = new Size(281, 27);
            txtWhatsapp.TabIndex = 22;
            // 
            // lblWhatsapp
            // 
            lblWhatsapp.AutoSize = true;
            lblWhatsapp.Location = new Point(57, 303);
            lblWhatsapp.Name = "lblWhatsapp";
            lblWhatsapp.Size = new Size(87, 20);
            lblWhatsapp.TabIndex = 21;
            lblWhatsapp.Text = "Whatsapp : ";
            // 
            // cbxAtualizarPeloWhatsapp
            // 
            cbxAtualizarPeloWhatsapp.AutoSize = true;
            cbxAtualizarPeloWhatsapp.Location = new Point(429, 305);
            cbxAtualizarPeloWhatsapp.Margin = new Padding(3, 4, 3, 4);
            cbxAtualizarPeloWhatsapp.Name = "cbxAtualizarPeloWhatsapp";
            cbxAtualizarPeloWhatsapp.Size = new Size(195, 24);
            cbxAtualizarPeloWhatsapp.TabIndex = 23;
            cbxAtualizarPeloWhatsapp.Text = "Atualizar pelo Whatsapp";
            cbxAtualizarPeloWhatsapp.UseVisualStyleBackColor = true;
            // 
            // cbxAtualizarPeloEmail
            // 
            cbxAtualizarPeloEmail.AutoSize = true;
            cbxAtualizarPeloEmail.Location = new Point(429, 271);
            cbxAtualizarPeloEmail.Margin = new Padding(3, 4, 3, 4);
            cbxAtualizarPeloEmail.Name = "cbxAtualizarPeloEmail";
            cbxAtualizarPeloEmail.Size = new Size(171, 24);
            cbxAtualizarPeloEmail.TabIndex = 24;
            cbxAtualizarPeloEmail.Text = "Atualizar pelo E-mail";
            cbxAtualizarPeloEmail.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(141, 81);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(281, 27);
            txtNome.TabIndex = 26;
            // 
            // lblNome
            // 
            lblNome.AutoEllipsis = true;
            lblNome.AutoSize = true;
            lblNome.Location = new Point(85, 81);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(57, 20);
            lblNome.TabIndex = 25;
            lblNome.Text = "Nome :";
            // 
            // TelaUserPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 459);
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
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MinimizeBox = false;
            Name = "TelaUserPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adicionar";
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