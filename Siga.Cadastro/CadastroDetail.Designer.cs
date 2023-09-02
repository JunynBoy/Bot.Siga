namespace Siga.Cadastro
{
    partial class CadastroDetail
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
            btnCadastrar = new Button();
            lblTitulo1 = new Label();
            lblSubtitulo = new Label();
            lblCadastro = new Label();
            lblLogin = new Label();
            lblSenha = new Label();
            lblConfirmaSenha = new Label();
            btnJaMeCadastrei = new Button();
            label1 = new Label();
            cbxTermos = new CheckBox();
            txtCPF = new MaskedTextBox();
            lblCanceelamento = new Label();
            label3 = new Label();
            txtSenha = new MaskedTextBox();
            TxtCPFCancelar = new MaskedTextBox();
            txtConfirmaSenha = new MaskedTextBox();
            txtEmail = new MaskedTextBox();
            button1 = new Button();
            txtWhatsapp = new MaskedTextBox();
            lblWhatsapp = new Label();
            cbxAtualizarPeloWhatsapp = new CheckBox();
            cbxAtualizarPeloEmail = new CheckBox();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(114, 435);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(210, 31);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = " Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblTitulo1
            // 
            lblTitulo1.AutoSize = true;
            lblTitulo1.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo1.Location = new Point(234, 11);
            lblTitulo1.Name = "lblTitulo1";
            lblTitulo1.Size = new Size(633, 23);
            lblTitulo1.TabIndex = 1;
            lblTitulo1.Text = "Bem vindo ao meu sistema de E-mail automático do SIGA";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AllowDrop = true;
            lblSubtitulo.AutoEllipsis = true;
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Location = new Point(166, 56);
            lblSubtitulo.MaximumSize = new Size(743, 267);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(743, 45);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Esta aplicação é protegida com criptografia, a função dela será entrar na sua conta com um Bot e armazenar suas notas e faltas, para a partir daí te notificar por E-mail de todas as alterações!";
            lblSubtitulo.UseCompatibleTextRendering = true;
            // 
            // lblCadastro
            // 
            lblCadastro.AutoSize = true;
            lblCadastro.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCadastro.Location = new Point(114, 125);
            lblCadastro.Name = "lblCadastro";
            lblCadastro.Size = new Size(211, 23);
            lblCadastro.TabIndex = 3;
            lblCadastro.Text = "Faça seu cadastro:";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(129, 174);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(40, 20);
            lblLogin.TabIndex = 4;
            lblLogin.Text = "CPF :";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(119, 221);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(56, 20);
            lblSenha.TabIndex = 5;
            lblSenha.Text = "Senha :";
            // 
            // lblConfirmaSenha
            // 
            lblConfirmaSenha.AutoSize = true;
            lblConfirmaSenha.Location = new Point(47, 269);
            lblConfirmaSenha.Name = "lblConfirmaSenha";
            lblConfirmaSenha.Size = new Size(131, 20);
            lblConfirmaSenha.TabIndex = 6;
            lblConfirmaSenha.Text = "Confirme a senha :";
            // 
            // btnJaMeCadastrei
            // 
            btnJaMeCadastrei.Location = new Point(361, 435);
            btnJaMeCadastrei.Margin = new Padding(3, 4, 3, 4);
            btnJaMeCadastrei.Name = "btnJaMeCadastrei";
            btnJaMeCadastrei.Size = new Size(210, 31);
            btnJaMeCadastrei.TabIndex = 7;
            btnJaMeCadastrei.Text = "Já estou cadastrado";
            btnJaMeCadastrei.UseVisualStyleBackColor = true;
            btnJaMeCadastrei.Click += btnJaMeCadastrei_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 316);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 8;
            label1.Text = "E-mail :";
            // 
            // cbxTermos
            // 
            cbxTermos.AutoSize = true;
            cbxTermos.Location = new Point(175, 393);
            cbxTermos.Margin = new Padding(3, 4, 3, 4);
            cbxTermos.Name = "cbxTermos";
            cbxTermos.Size = new Size(246, 24);
            cbxTermos.TabIndex = 10;
            cbxTermos.Text = "Concordo com os termos de uso";
            cbxTermos.UseVisualStyleBackColor = true;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(175, 171);
            txtCPF.Margin = new Padding(3, 4, 3, 4);
            txtCPF.Mask = "000.000.000-00";
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(281, 27);
            txtCPF.TabIndex = 12;
            // 
            // lblCanceelamento
            // 
            lblCanceelamento.AutoSize = true;
            lblCanceelamento.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCanceelamento.Location = new Point(643, 136);
            lblCanceelamento.Name = "lblCanceelamento";
            lblCanceelamento.Size = new Size(326, 23);
            lblCanceelamento.TabIndex = 13;
            lblCanceelamento.Text = "Quero cancelar meu cadastro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(648, 188);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 14;
            label3.Text = "CPF :";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(175, 217);
            txtSenha.Margin = new Padding(3, 4, 3, 4);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(281, 27);
            txtSenha.TabIndex = 16;
            // 
            // TxtCPFCancelar
            // 
            TxtCPFCancelar.Location = new Point(693, 180);
            TxtCPFCancelar.Margin = new Padding(3, 4, 3, 4);
            TxtCPFCancelar.Mask = "000.000.000-00";
            TxtCPFCancelar.Name = "TxtCPFCancelar";
            TxtCPFCancelar.Size = new Size(263, 27);
            TxtCPFCancelar.TabIndex = 17;
            // 
            // txtConfirmaSenha
            // 
            txtConfirmaSenha.Location = new Point(175, 266);
            txtConfirmaSenha.Margin = new Padding(3, 4, 3, 4);
            txtConfirmaSenha.Name = "txtConfirmaSenha";
            txtConfirmaSenha.PasswordChar = '*';
            txtConfirmaSenha.Size = new Size(281, 27);
            txtConfirmaSenha.TabIndex = 18;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(175, 313);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(281, 27);
            txtEmail.TabIndex = 19;
            // 
            // button1
            // 
            button1.Location = new Point(870, 226);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 20;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtWhatsapp
            // 
            txtWhatsapp.Location = new Point(175, 348);
            txtWhatsapp.Margin = new Padding(3, 4, 3, 4);
            txtWhatsapp.Name = "txtWhatsapp";
            txtWhatsapp.Size = new Size(281, 27);
            txtWhatsapp.TabIndex = 22;
            // 
            // lblWhatsapp
            // 
            lblWhatsapp.AutoSize = true;
            lblWhatsapp.Location = new Point(91, 351);
            lblWhatsapp.Name = "lblWhatsapp";
            lblWhatsapp.Size = new Size(87, 20);
            lblWhatsapp.TabIndex = 21;
            lblWhatsapp.Text = "Whatsapp : ";
            // 
            // cbxAtualizarPeloWhatsapp
            // 
            cbxAtualizarPeloWhatsapp.AutoSize = true;
            cbxAtualizarPeloWhatsapp.Location = new Point(462, 350);
            cbxAtualizarPeloWhatsapp.Margin = new Padding(3, 4, 3, 4);
            cbxAtualizarPeloWhatsapp.Name = "cbxAtualizarPeloWhatsapp";
            cbxAtualizarPeloWhatsapp.Size = new Size(195, 24);
            cbxAtualizarPeloWhatsapp.TabIndex = 23;
            cbxAtualizarPeloWhatsapp.Text = "Atualizar pelo Whatsapp";
            cbxAtualizarPeloWhatsapp.UseVisualStyleBackColor = true;
            cbxAtualizarPeloWhatsapp.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // cbxAtualizarPeloEmail
            // 
            cbxAtualizarPeloEmail.AutoSize = true;
            cbxAtualizarPeloEmail.Location = new Point(462, 316);
            cbxAtualizarPeloEmail.Margin = new Padding(3, 4, 3, 4);
            cbxAtualizarPeloEmail.Name = "cbxAtualizarPeloEmail";
            cbxAtualizarPeloEmail.Size = new Size(171, 24);
            cbxAtualizarPeloEmail.TabIndex = 24;
            cbxAtualizarPeloEmail.Text = "Atualizar pelo E-mail";
            cbxAtualizarPeloEmail.UseVisualStyleBackColor = true;
            // 
            // CadastroDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 530);
            Controls.Add(cbxAtualizarPeloEmail);
            Controls.Add(cbxAtualizarPeloWhatsapp);
            Controls.Add(txtWhatsapp);
            Controls.Add(lblWhatsapp);
            Controls.Add(button1);
            Controls.Add(txtEmail);
            Controls.Add(txtConfirmaSenha);
            Controls.Add(TxtCPFCancelar);
            Controls.Add(txtSenha);
            Controls.Add(label3);
            Controls.Add(lblCanceelamento);
            Controls.Add(txtCPF);
            Controls.Add(cbxTermos);
            Controls.Add(label1);
            Controls.Add(btnJaMeCadastrei);
            Controls.Add(lblConfirmaSenha);
            Controls.Add(lblSenha);
            Controls.Add(lblLogin);
            Controls.Add(lblCadastro);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo1);
            Controls.Add(btnCadastrar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CadastroDetail";
            Text = "CadastroDetail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrar;
        private Label lblTitulo1;
        private Label lblSubtitulo;
        private Label lblCadastro;
        private Label lblLogin;
        private Label lblSenha;
        private Label lblConfirmaSenha;
        private Button btnJaMeCadastrei;
        private Label label1;
        private CheckBox cbxTermos;
        private MaskedTextBox txtCPF;
        private Label lblCanceelamento;
        private Label label3;
        private MaskedTextBox txtSenha;
        private MaskedTextBox TxtCPFCancelar;
        private MaskedTextBox txtConfirmaSenha;
        private MaskedTextBox txtEmail;
        private Button button1;
        private MaskedTextBox txtWhatsapp;
        private Label lblWhatsapp;
        private CheckBox cbxAtualizarPeloWhatsapp;
        private CheckBox cbxAtualizarPeloEmail;
    }
}