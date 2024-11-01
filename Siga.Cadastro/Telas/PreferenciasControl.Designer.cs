namespace Bot.App.Controls
{
    partial class PreferenciasControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferenciasControl));
            panel1 = new Panel();
            panel3 = new Panel();
            lblLogin = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label8 = new Label();
            label9 = new Label();
            pcbUser = new PictureBox();
            btnEdit = new CustomButton();
            panelPreferencias = new Panel();
            btnSalvarAtualizar = new CustomButton();
            label6 = new Label();
            richTextBox1 = new RichTextBox();
            lblAtualizarPorEmail = new Label();
            tbAtualizarPorEmail = new CustomControls.CustomControls.CustomToggleButton();
            lblAtualizarPorWhatsapp = new Label();
            tbAtualizarPorWhatsapp = new CustomControls.CustomControls.CustomToggleButton();
            panelSubHeaderPreferencias = new Panel();
            lblPreferencias = new Label();
            txtmWhatsapp = new CustomMaskedTextBox();
            txtEmail = new CustomTextBox();
            pcbEmail = new PictureBox();
            pcbWhatsapp = new PictureBox();
            lblWhatsapp = new Label();
            lblEmail = new Label();
            panel2 = new Panel();
            label7 = new Label();
            customButton3 = new CustomButton();
            customButton2 = new CustomButton();
            customButton1 = new CustomButton();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbUser).BeginInit();
            panelPreferencias.SuspendLayout();
            panelSubHeaderPreferencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbWhatsapp).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 389);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(368, 121);
            panel3.TabIndex = 0;
            // 
            // lblLogin
            // 
            lblLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.FromArgb(30, 39, 44);
            lblLogin.Location = new Point(3, 7);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(167, 25);
            lblLogin.TabIndex = 62;
            lblLogin.Text = "Suas preferencias";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(30, 39, 44);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(213, 25);
            label1.TabIndex = 65;
            label1.Text = "Informações Essenciais";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(30, 39, 44);
            label2.Location = new Point(3, 51);
            label2.Name = "label2";
            label2.Size = new Size(187, 15);
            label2.TabIndex = 66;
            label2.Text = "marcos.gaparini@fatec.sp.gov.br";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 32);
            label3.Name = "label3";
            label3.Size = new Size(131, 19);
            label3.TabIndex = 65;
            label3.Text = "E-mail Institucional";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label4);
            panel4.Controls.Add(pcbUser);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(label5);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(368, 121);
            panel4.TabIndex = 67;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.Controls.Add(btnEdit);
            panel5.Controls.Add(lblLogin);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(368, 41);
            panel5.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(30, 39, 44);
            label4.Location = new Point(109, 61);
            label4.Name = "label4";
            label4.Size = new Size(187, 15);
            label4.TabIndex = 66;
            label4.Text = "marcos.gaparini@fatec.sp.gov.br";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(109, 42);
            label5.Name = "label5";
            label5.Size = new Size(49, 19);
            label5.TabIndex = 65;
            label5.Text = "E-mail";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(30, 39, 44);
            label8.Location = new Point(109, 100);
            label8.Name = "label8";
            label8.Size = new Size(93, 15);
            label8.TabIndex = 66;
            label8.Text = "(00) 0000-0000";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(109, 81);
            label9.Name = "label9";
            label9.Size = new Size(72, 19);
            label9.TabIndex = 65;
            label9.Text = "Whatsapp";
            // 
            // pcbUser
            // 
            pcbUser.BackColor = Color.FromArgb(224, 224, 224);
            pcbUser.Image = (Image)resources.GetObject("pcbUser.Image");
            pcbUser.Location = new Point(3, 47);
            pcbUser.Name = "pcbUser";
            pcbUser.Size = new Size(100, 68);
            pcbUser.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbUser.TabIndex = 67;
            pcbUser.TabStop = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.White;
            btnEdit.BackgroundColor = Color.White;
            btnEdit.BorderColor = Color.Black;
            btnEdit.BorderRadius = 15;
            btnEdit.BorderSize = 1;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.White;
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.Location = new Point(332, 7);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(30, 30);
            btnEdit.TabIndex = 68;
            btnEdit.TextColor = Color.White;
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // panelPreferencias
            // 
            panelPreferencias.BackColor = Color.White;
            panelPreferencias.Controls.Add(btnSalvarAtualizar);
            panelPreferencias.Controls.Add(label6);
            panelPreferencias.Controls.Add(richTextBox1);
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
            panelPreferencias.Location = new Point(368, 0);
            panelPreferencias.Name = "panelPreferencias";
            panelPreferencias.Size = new Size(432, 389);
            panelPreferencias.TabIndex = 70;
            panelPreferencias.Visible = false;
            // 
            // btnSalvarAtualizar
            // 
            btnSalvarAtualizar.BackColor = Color.FromArgb(66, 84, 96);
            btnSalvarAtualizar.BackgroundColor = Color.FromArgb(66, 84, 96);
            btnSalvarAtualizar.BorderColor = Color.FromArgb(64, 64, 64);
            btnSalvarAtualizar.BorderRadius = 3;
            btnSalvarAtualizar.BorderSize = 1;
            btnSalvarAtualizar.FlatAppearance.BorderSize = 0;
            btnSalvarAtualizar.FlatStyle = FlatStyle.Flat;
            btnSalvarAtualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvarAtualizar.ForeColor = Color.White;
            btnSalvarAtualizar.Location = new Point(262, 344);
            btnSalvarAtualizar.Name = "btnSalvarAtualizar";
            btnSalvarAtualizar.Size = new Size(121, 23);
            btnSalvarAtualizar.TabIndex = 72;
            btnSalvarAtualizar.Text = "Salvar";
            btnSalvarAtualizar.TextColor = Color.White;
            btnSalvarAtualizar.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(51, 240);
            label6.Name = "label6";
            label6.Size = new Size(162, 19);
            label6.TabIndex = 70;
            label6.Text = "Mensagem Customizada";
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(51, 262);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(332, 76);
            richTextBox1.TabIndex = 69;
            richTextBox1.Text = "Olá! aqui é o robozinho do SIGA, estou te enviando essa mensagem por que houve atualizações de notas no siga... da uma conferida lá!";
            // 
            // lblAtualizarPorEmail
            // 
            lblAtualizarPorEmail.AutoSize = true;
            lblAtualizarPorEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAtualizarPorEmail.ForeColor = Color.FromArgb(30, 39, 44);
            lblAtualizarPorEmail.Location = new Point(102, 215);
            lblAtualizarPorEmail.Name = "lblAtualizarPorEmail";
            lblAtualizarPorEmail.Size = new Size(153, 17);
            lblAtualizarPorEmail.TabIndex = 0;
            lblAtualizarPorEmail.Text = "Atualizações por E-mail";
            // 
            // tbAtualizarPorEmail
            // 
            tbAtualizarPorEmail.Location = new Point(51, 215);
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
            lblAtualizarPorWhatsapp.Location = new Point(102, 186);
            lblAtualizarPorWhatsapp.Name = "lblAtualizarPorWhatsapp";
            lblAtualizarPorWhatsapp.Size = new Size(176, 17);
            lblAtualizarPorWhatsapp.TabIndex = 0;
            lblAtualizarPorWhatsapp.Text = "Atualizações por Whatsapp";
            lblAtualizarPorWhatsapp.TextAlign = ContentAlignment.TopRight;
            // 
            // tbAtualizarPorWhatsapp
            // 
            tbAtualizarPorWhatsapp.Location = new Point(51, 186);
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
            panelSubHeaderPreferencias.BackColor = SystemColors.Control;
            panelSubHeaderPreferencias.Controls.Add(lblPreferencias);
            panelSubHeaderPreferencias.Dock = DockStyle.Top;
            panelSubHeaderPreferencias.Location = new Point(0, 0);
            panelSubHeaderPreferencias.Name = "panelSubHeaderPreferencias";
            panelSubHeaderPreferencias.Size = new Size(432, 41);
            panelSubHeaderPreferencias.TabIndex = 42;
            // 
            // lblPreferencias
            // 
            lblPreferencias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPreferencias.AutoSize = true;
            lblPreferencias.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPreferencias.ForeColor = Color.FromArgb(30, 39, 44);
            lblPreferencias.Location = new Point(157, 7);
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
            txtmWhatsapp.Location = new Point(83, 81);
            txtmWhatsapp.Margin = new Padding(4);
            txtmWhatsapp.Mask = "00 00000-0000";
            txtmWhatsapp.Multiline = false;
            txtmWhatsapp.Name = "txtmWhatsapp";
            txtmWhatsapp.Padding = new Padding(7);
            txtmWhatsapp.PasswordChar = false;
            txtmWhatsapp.Size = new Size(300, 29);
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
            txtEmail.Location = new Point(83, 141);
            txtEmail.Margin = new Padding(4);
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(7);
            txtEmail.PasswordChar = false;
            txtEmail.Size = new Size(300, 29);
            txtEmail.TabIndex = 6;
            txtEmail.Texts = "";
            txtEmail.UnderlinedStyle = true;
            // 
            // pcbEmail
            // 
            pcbEmail.Image = (Image)resources.GetObject("pcbEmail.Image");
            pcbEmail.Location = new Point(51, 141);
            pcbEmail.Name = "pcbEmail";
            pcbEmail.Size = new Size(25, 25);
            pcbEmail.TabIndex = 40;
            pcbEmail.TabStop = false;
            // 
            // pcbWhatsapp
            // 
            pcbWhatsapp.Image = (Image)resources.GetObject("pcbWhatsapp.Image");
            pcbWhatsapp.Location = new Point(51, 85);
            pcbWhatsapp.Name = "pcbWhatsapp";
            pcbWhatsapp.Size = new Size(25, 25);
            pcbWhatsapp.TabIndex = 40;
            pcbWhatsapp.TabStop = false;
            // 
            // lblWhatsapp
            // 
            lblWhatsapp.AutoSize = true;
            lblWhatsapp.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblWhatsapp.Location = new Point(83, 58);
            lblWhatsapp.Name = "lblWhatsapp";
            lblWhatsapp.Size = new Size(72, 19);
            lblWhatsapp.TabIndex = 0;
            lblWhatsapp.Text = "Whatsapp";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(83, 118);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 19);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "E-mail";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(customButton3);
            panel2.Controls.Add(customButton2);
            panel2.Controls.Add(customButton1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 121);
            panel2.Name = "panel2";
            panel2.Size = new Size(368, 41);
            panel2.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(3, 12);
            label7.Name = "label7";
            label7.Size = new Size(233, 19);
            label7.TabIndex = 71;
            label7.Text = "Enviar Mensagem ao Atualizar Nota";
            // 
            // customButton3
            // 
            customButton3.BackColor = Color.White;
            customButton3.BackgroundColor = Color.White;
            customButton3.BorderColor = Color.Black;
            customButton3.BorderRadius = 15;
            customButton3.BorderSize = 1;
            customButton3.FlatAppearance.BorderSize = 0;
            customButton3.FlatStyle = FlatStyle.Flat;
            customButton3.ForeColor = Color.White;
            customButton3.Image = (Image)resources.GetObject("customButton3.Image");
            customButton3.Location = new Point(260, 6);
            customButton3.Name = "customButton3";
            customButton3.Size = new Size(30, 30);
            customButton3.TabIndex = 70;
            customButton3.TextColor = Color.White;
            customButton3.UseVisualStyleBackColor = false;
            // 
            // customButton2
            // 
            customButton2.BackColor = Color.White;
            customButton2.BackgroundColor = Color.White;
            customButton2.BorderColor = Color.Black;
            customButton2.BorderRadius = 15;
            customButton2.BorderSize = 1;
            customButton2.FlatAppearance.BorderSize = 0;
            customButton2.FlatStyle = FlatStyle.Flat;
            customButton2.ForeColor = Color.White;
            customButton2.Image = (Image)resources.GetObject("customButton2.Image");
            customButton2.Location = new Point(296, 6);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(30, 30);
            customButton2.TabIndex = 69;
            customButton2.TextColor = Color.White;
            customButton2.UseVisualStyleBackColor = false;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.White;
            customButton1.BackgroundColor = Color.White;
            customButton1.BorderColor = Color.Black;
            customButton1.BorderRadius = 15;
            customButton1.BorderSize = 1;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.ForeColor = Color.White;
            customButton1.Image = (Image)resources.GetObject("customButton1.Image");
            customButton1.Location = new Point(332, 6);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(30, 30);
            customButton1.TabIndex = 68;
            customButton1.TextColor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 162);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(368, 227);
            dataGridView1.TabIndex = 5;
            // 
            // PreferenciasControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelPreferencias);
            Controls.Add(panel1);
            Name = "PreferenciasControl";
            Size = new Size(800, 389);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbUser).EndInit();
            panelPreferencias.ResumeLayout(false);
            panelPreferencias.PerformLayout();
            panelSubHeaderPreferencias.ResumeLayout(false);
            panelSubHeaderPreferencias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbWhatsapp).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label lblLogin;
        private Panel panel4;
        private Label label8;
        private Label label4;
        private Label label9;
        private Panel panel5;
        private Label label5;
        private Label label2;
        private Label label3;
        private Label label1;
        private PictureBox pcbUser;
        private CustomButton btnEdit;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label7;
        private CustomButton customButton3;
        private CustomButton customButton2;
        private CustomButton customButton1;
        private Panel panelPreferencias;
        private CustomButton btnSalvarAtualizar;
        private Label label6;
        private RichTextBox richTextBox1;
        private Label lblAtualizarPorEmail;
        private CustomControls.CustomControls.CustomToggleButton tbAtualizarPorEmail;
        private Label lblAtualizarPorWhatsapp;
        private CustomControls.CustomControls.CustomToggleButton tbAtualizarPorWhatsapp;
        private Panel panelSubHeaderPreferencias;
        private Label lblPreferencias;
        private CustomMaskedTextBox txtmWhatsapp;
        private CustomTextBox txtEmail;
        private PictureBox pcbEmail;
        private PictureBox pcbWhatsapp;
        private Label lblWhatsapp;
        private Label lblEmail;
    }
}
