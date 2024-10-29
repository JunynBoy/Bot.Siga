namespace Bot.App.Controls
{
    partial class HomeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeControl));
            panel1 = new Panel();
            panel5 = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            customToggleButton1 = new CustomControls.CustomControls.CustomToggleButton();
            label2 = new Label();
            lblAtualizarPorEmail = new Label();
            tbAtualizarPorEmail = new CustomControls.CustomControls.CustomToggleButton();
            lblAtualizarPorWhatsapp = new Label();
            tbAtualizarPorWhatsapp = new CustomControls.CustomControls.CustomToggleButton();
            panel6 = new Panel();
            btnStop = new CustomButton();
            btnStartStop = new CustomButton();
            panel4 = new Panel();
            lblStatus = new Label();
            panel2 = new Panel();
            panelConsoleContainer = new Panel();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 389);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(customToggleButton1);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(lblAtualizarPorEmail);
            panel5.Controls.Add(tbAtualizarPorEmail);
            panel5.Controls.Add(lblAtualizarPorWhatsapp);
            panel5.Controls.Add(tbAtualizarPorWhatsapp);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(0, 53);
            panel5.Name = "panel5";
            panel5.Size = new Size(300, 336);
            panel5.TabIndex = 35;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(30, 39, 44);
            label9.Location = new Point(75, 85);
            label9.Name = "label9";
            label9.Size = new Size(48, 15);
            label9.TabIndex = 23;
            label9.Text = "Status :";
            label9.TextAlign = ContentAlignment.TopRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(30, 39, 44);
            label8.Location = new Point(75, 57);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 22;
            label8.Text = "Status :";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(30, 39, 44);
            label7.Location = new Point(75, 31);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 21;
            label7.Text = "Status :";
            label7.TextAlign = ContentAlignment.TopRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(30, 39, 44);
            label6.Location = new Point(20, 85);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 20;
            label6.Text = "Status :";
            label6.TextAlign = ContentAlignment.TopRight;
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(30, 39, 44);
            label5.Location = new Point(20, 57);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 19;
            label5.Text = "Status :";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(30, 39, 44);
            label4.Location = new Point(20, 31);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 18;
            label4.Text = "Status :";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(30, 39, 44);
            label3.Location = new Point(17, 3);
            label3.Name = "label3";
            label3.Size = new Size(84, 17);
            label3.TabIndex = 17;
            label3.Text = "Informações";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(30, 39, 44);
            label1.Location = new Point(68, 188);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 13;
            label1.Text = "Notas";
            // 
            // customToggleButton1
            // 
            customToggleButton1.Checked = true;
            customToggleButton1.CheckState = CheckState.Checked;
            customToggleButton1.Location = new Point(17, 187);
            customToggleButton1.MinimumSize = new Size(45, 22);
            customToggleButton1.Name = "customToggleButton1";
            customToggleButton1.OffBackColor = Color.Gray;
            customToggleButton1.OffToggleColor = Color.Gainsboro;
            customToggleButton1.OnBackColor = Color.FromArgb(66, 84, 96);
            customToggleButton1.OnToggleColor = Color.WhiteSmoke;
            customToggleButton1.Size = new Size(45, 22);
            customToggleButton1.TabIndex = 16;
            customToggleButton1.UseVisualStyleBackColor = true;
            customToggleButton1.CheckedChanged += customToggleButton1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(30, 39, 44);
            label2.Location = new Point(17, 157);
            label2.Name = "label2";
            label2.Size = new Size(128, 17);
            label2.TabIndex = 14;
            label2.Text = "Itens Para Atualizar";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // lblAtualizarPorEmail
            // 
            lblAtualizarPorEmail.AutoSize = true;
            lblAtualizarPorEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAtualizarPorEmail.ForeColor = Color.FromArgb(30, 39, 44);
            lblAtualizarPorEmail.Location = new Point(68, 216);
            lblAtualizarPorEmail.Name = "lblAtualizarPorEmail";
            lblAtualizarPorEmail.Size = new Size(38, 15);
            lblAtualizarPorEmail.TabIndex = 9;
            lblAtualizarPorEmail.Text = "Faltas";
            // 
            // tbAtualizarPorEmail
            // 
            tbAtualizarPorEmail.Checked = true;
            tbAtualizarPorEmail.CheckState = CheckState.Checked;
            tbAtualizarPorEmail.Location = new Point(17, 244);
            tbAtualizarPorEmail.MinimumSize = new Size(45, 22);
            tbAtualizarPorEmail.Name = "tbAtualizarPorEmail";
            tbAtualizarPorEmail.OffBackColor = Color.Gray;
            tbAtualizarPorEmail.OffToggleColor = Color.Gainsboro;
            tbAtualizarPorEmail.OnBackColor = Color.FromArgb(66, 84, 96);
            tbAtualizarPorEmail.OnToggleColor = Color.WhiteSmoke;
            tbAtualizarPorEmail.Size = new Size(45, 22);
            tbAtualizarPorEmail.TabIndex = 12;
            tbAtualizarPorEmail.UseVisualStyleBackColor = true;
            // 
            // lblAtualizarPorWhatsapp
            // 
            lblAtualizarPorWhatsapp.AutoSize = true;
            lblAtualizarPorWhatsapp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAtualizarPorWhatsapp.ForeColor = Color.FromArgb(30, 39, 44);
            lblAtualizarPorWhatsapp.Location = new Point(68, 245);
            lblAtualizarPorWhatsapp.Name = "lblAtualizarPorWhatsapp";
            lblAtualizarPorWhatsapp.Size = new Size(55, 15);
            lblAtualizarPorWhatsapp.TabIndex = 10;
            lblAtualizarPorWhatsapp.Text = "Matérias";
            lblAtualizarPorWhatsapp.TextAlign = ContentAlignment.TopRight;
            // 
            // tbAtualizarPorWhatsapp
            // 
            tbAtualizarPorWhatsapp.Checked = true;
            tbAtualizarPorWhatsapp.CheckState = CheckState.Checked;
            tbAtualizarPorWhatsapp.Location = new Point(17, 215);
            tbAtualizarPorWhatsapp.MinimumSize = new Size(45, 22);
            tbAtualizarPorWhatsapp.Name = "tbAtualizarPorWhatsapp";
            tbAtualizarPorWhatsapp.OffBackColor = Color.Gray;
            tbAtualizarPorWhatsapp.OffToggleColor = Color.Gainsboro;
            tbAtualizarPorWhatsapp.OnBackColor = Color.FromArgb(66, 84, 96);
            tbAtualizarPorWhatsapp.OnToggleColor = Color.WhiteSmoke;
            tbAtualizarPorWhatsapp.Size = new Size(45, 22);
            tbAtualizarPorWhatsapp.TabIndex = 11;
            tbAtualizarPorWhatsapp.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.Control;
            panel6.Controls.Add(btnStop);
            panel6.Controls.Add(btnStartStop);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 272);
            panel6.Name = "panel6";
            panel6.Size = new Size(300, 64);
            panel6.TabIndex = 1;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.White;
            btnStop.BackgroundColor = Color.White;
            btnStop.BorderColor = Color.Black;
            btnStop.BorderRadius = 15;
            btnStop.BorderSize = 1;
            btnStop.FlatAppearance.BorderSize = 0;
            btnStop.FlatStyle = FlatStyle.Flat;
            btnStop.ForeColor = Color.White;
            btnStop.Image = (Image)resources.GetObject("btnStop.Image");
            btnStop.Location = new Point(98, 19);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(30, 30);
            btnStop.TabIndex = 1;
            btnStop.TextColor = Color.White;
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // btnStartStop
            // 
            btnStartStop.BackColor = Color.White;
            btnStartStop.BackgroundColor = Color.White;
            btnStartStop.BorderColor = Color.Black;
            btnStartStop.BorderRadius = 29;
            btnStartStop.BorderSize = 1;
            btnStartStop.FlatAppearance.BorderSize = 0;
            btnStartStop.FlatStyle = FlatStyle.Flat;
            btnStartStop.ForeColor = Color.White;
            btnStartStop.Image = (Image)resources.GetObject("btnStartStop.Image");
            btnStartStop.Location = new Point(134, 3);
            btnStartStop.Name = "btnStartStop";
            btnStartStop.Size = new Size(53, 53);
            btnStartStop.TabIndex = 0;
            btnStartStop.TextColor = Color.White;
            btnStartStop.UseVisualStyleBackColor = false;
            btnStartStop.Click += btnStartStop_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblStatus);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 53);
            panel4.TabIndex = 34;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.FromArgb(30, 39, 44);
            lblStatus.Location = new Point(20, 15);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(164, 25);
            lblStatus.TabIndex = 33;
            lblStatus.Text = "Coletor de dados";
            // 
            // panel2
            // 
            panel2.Controls.Add(panelConsoleContainer);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(300, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(500, 389);
            panel2.TabIndex = 1;
            // 
            // panelConsoleContainer
            // 
            panelConsoleContainer.Dock = DockStyle.Fill;
            panelConsoleContainer.Location = new Point(0, 0);
            panelConsoleContainer.Name = "panelConsoleContainer";
            panelConsoleContainer.Size = new Size(500, 389);
            panelConsoleContainer.TabIndex = 2;
            // 
            // HomeControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "HomeControl";
            Size = new Size(800, 389);
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private CustomButton btnStartStop;
        private Panel panel4;
        private Label lblStatus;
        private Panel panel5;
        private Panel panelConsoleContainer;
        private Panel panel6;
        private Label label1;
        private CustomControls.CustomControls.CustomToggleButton customToggleButton1;
        private Label label2;
        private Label lblAtualizarPorEmail;
        private CustomControls.CustomControls.CustomToggleButton tbAtualizarPorEmail;
        private Label lblAtualizarPorWhatsapp;
        private CustomControls.CustomControls.CustomToggleButton tbAtualizarPorWhatsapp;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label9;
        private Label label8;
        private Label label7;
        private CustomButton btnStop;
    }
}
