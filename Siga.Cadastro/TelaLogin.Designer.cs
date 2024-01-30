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
            txtSenha = new MaskedTextBox();
            txtCPF = new MaskedTextBox();
            lblSenha = new Label();
            lblCpf = new Label();
            btnAdicionar = new Button();
            lblTitle = new Label();
            cbxUserPrincipal = new CheckBox();
            SuspendLayout();
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(155, 152);
            txtSenha.Margin = new Padding(3, 4, 3, 4);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(281, 27);
            txtSenha.TabIndex = 30;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(155, 106);
            txtCPF.Margin = new Padding(3, 4, 3, 4);
            txtCPF.Mask = "000.000.000-00";
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(281, 27);
            txtCPF.TabIndex = 29;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(99, 156);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(56, 20);
            lblSenha.TabIndex = 28;
            lblSenha.Text = "Senha :";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(109, 108);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(40, 20);
            lblCpf.TabIndex = 27;
            lblCpf.Text = "CPF :";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(342, 239);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(94, 29);
            btnAdicionar.TabIndex = 31;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(109, 48);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(169, 32);
            lblTitle.TabIndex = 32;
            lblTitle.Text = "Login Siga:";
            lblTitle.Click += lblTitle_Click;
            // 
            // cbxUserPrincipal
            // 
            cbxUserPrincipal.AutoSize = true;
            cbxUserPrincipal.Location = new Point(109, 242);
            cbxUserPrincipal.Name = "cbxUserPrincipal";
            cbxUserPrincipal.Size = new Size(143, 24);
            cbxUserPrincipal.TabIndex = 33;
            cbxUserPrincipal.Text = "Usuário principal";
            cbxUserPrincipal.UseVisualStyleBackColor = true;
            cbxUserPrincipal.CheckedChanged += cbxUserPrincipal_CheckedChanged;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 317);
            Controls.Add(cbxUserPrincipal);
            Controls.Add(lblTitle);
            Controls.Add(btnAdicionar);
            Controls.Add(txtSenha);
            Controls.Add(txtCPF);
            Controls.Add(lblSenha);
            Controls.Add(lblCpf);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "TelaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtSenha;
        private MaskedTextBox txtCPF;
        private Label lblSenha;
        private Label lblCpf;
        private Button btnAdicionar;
        private Label lblTitle;
        private CheckBox cbxUserPrincipal;
    }
}