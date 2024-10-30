namespace Bot.App.Controls
{
    partial class PerfilControl
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblCpf = new Label();
            lblContadorTitle = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblLogin = new Label();
            label7 = new Label();
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label10);
            panel1.Controls.Add(progressBar2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(progressBar1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lblLogin);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblContadorTitle);
            panel1.Controls.Add(lblCpf);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 389);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(22, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 140);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblCpf.Location = new Point(191, 58);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(47, 19);
            lblCpf.TabIndex = 1;
            lblCpf.Text = "Nome";
            // 
            // lblContadorTitle
            // 
            lblContadorTitle.AutoSize = true;
            lblContadorTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblContadorTitle.ForeColor = Color.FromArgb(30, 39, 44);
            lblContadorTitle.Location = new Point(191, 77);
            lblContadorTitle.Name = "lblContadorTitle";
            lblContadorTitle.Size = new Size(138, 15);
            lblContadorTitle.TabIndex = 21;
            lblContadorTitle.Text = "Marcos Gasparini Junior";
            lblContadorTitle.TextAlign = ContentAlignment.TopRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(30, 39, 44);
            label1.Location = new Point(191, 124);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 23;
            label1.Text = "123123123123";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(191, 105);
            label2.Name = "label2";
            label2.Size = new Size(27, 19);
            label2.TabIndex = 22;
            label2.Text = "RA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(30, 39, 44);
            label3.Location = new Point(331, 124);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 25;
            label3.Text = "1";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(319, 105);
            label4.Name = "label4";
            label4.Size = new Size(41, 19);
            label4.TabIndex = 24;
            label4.Text = "Ciclo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(30, 39, 44);
            label5.Location = new Point(22, 262);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 27;
            label5.Text = "74.28%";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(22, 243);
            label6.Name = "label6";
            label6.Size = new Size(166, 19);
            label6.TabIndex = 26;
            label6.Text = "Percentual de Progressão";
            // 
            // lblLogin
            // 
            lblLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.FromArgb(30, 39, 44);
            lblLogin.Location = new Point(168, 16);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(213, 25);
            lblLogin.TabIndex = 33;
            lblLogin.Text = "Informações Essenciais";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(30, 39, 44);
            label7.Location = new Point(11, 198);
            label7.Name = "label7";
            label7.Size = new Size(207, 25);
            label7.TabIndex = 34;
            label7.Text = "Rendimento do Curso";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(22, 280);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(359, 16);
            progressBar1.TabIndex = 35;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(22, 336);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(359, 16);
            progressBar2.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(30, 39, 44);
            label8.Location = new Point(20, 318);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 37;
            label8.Text = "74.28%";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(20, 299);
            label9.Name = "label9";
            label9.Size = new Size(174, 19);
            label9.TabIndex = 36;
            label9.Text = "Percentual de Rendimento";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(30, 39, 44);
            label10.Location = new Point(510, 16);
            label10.Name = "label10";
            label10.Size = new Size(220, 25);
            label10.TabIndex = 39;
            label10.Text = "Prazo de Integralização";
            // 
            // PerfilControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "PerfilControl";
            Size = new Size(800, 389);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblCpf;
        private Label label3;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label lblContadorTitle;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblLogin;
        private ProgressBar progressBar2;
        private Label label8;
        private Label label9;
        private ProgressBar progressBar1;
        private Label label10;
    }
}
