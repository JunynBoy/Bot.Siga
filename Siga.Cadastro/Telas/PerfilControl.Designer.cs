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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerfilControl));
            panelContainer = new Panel();
            lblEmailInstitucional = new Label();
            lblEmailInstitucionaltitle = new Label();
            lblMaximo = new Label();
            lblMaximoTitle = new Label();
            pvPieChart = new OxyPlot.WindowsForms.PlotView();
            lblPrazoDeIntegralizaçãoTitle = new Label();
            pbPercentualRendimento = new ProgressBar();
            lblPercentualRendimento = new Label();
            lblPercentualRendimentoTitle = new Label();
            pbPercentualProgressao = new ProgressBar();
            lblRendimentoCursoTitle = new Label();
            lblLogin = new Label();
            lblPercentualProgressao = new Label();
            lblPercentualProgressaoTitle = new Label();
            lblCiclo = new Label();
            lblCicloTitle = new Label();
            lblRA = new Label();
            lblRATitle = new Label();
            lblNome = new Label();
            lblNomeTitle = new Label();
            pcbUser = new PictureBox();
            panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbUser).BeginInit();
            SuspendLayout();
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(lblEmailInstitucional);
            panelContainer.Controls.Add(lblEmailInstitucionaltitle);
            panelContainer.Controls.Add(lblMaximo);
            panelContainer.Controls.Add(lblMaximoTitle);
            panelContainer.Controls.Add(pvPieChart);
            panelContainer.Controls.Add(lblPrazoDeIntegralizaçãoTitle);
            panelContainer.Controls.Add(pbPercentualRendimento);
            panelContainer.Controls.Add(lblPercentualRendimento);
            panelContainer.Controls.Add(lblPercentualRendimentoTitle);
            panelContainer.Controls.Add(pbPercentualProgressao);
            panelContainer.Controls.Add(lblRendimentoCursoTitle);
            panelContainer.Controls.Add(lblLogin);
            panelContainer.Controls.Add(lblPercentualProgressao);
            panelContainer.Controls.Add(lblPercentualProgressaoTitle);
            panelContainer.Controls.Add(lblCiclo);
            panelContainer.Controls.Add(lblCicloTitle);
            panelContainer.Controls.Add(lblRA);
            panelContainer.Controls.Add(lblRATitle);
            panelContainer.Controls.Add(lblNome);
            panelContainer.Controls.Add(lblNomeTitle);
            panelContainer.Controls.Add(pcbUser);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(800, 389);
            panelContainer.TabIndex = 0;
            panelContainer.Paint += panel1_Paint;
            // 
            // lblEmailInstitucional
            // 
            lblEmailInstitucional.AutoSize = true;
            lblEmailInstitucional.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmailInstitucional.ForeColor = Color.FromArgb(30, 39, 44);
            lblEmailInstitucional.Location = new Point(191, 78);
            lblEmailInstitucional.Name = "lblEmailInstitucional";
            lblEmailInstitucional.Size = new Size(187, 15);
            lblEmailInstitucional.TabIndex = 44;
            lblEmailInstitucional.Text = "marcos.gaparini@fatec.sp.gov.br";
            lblEmailInstitucional.TextAlign = ContentAlignment.TopRight;
            // 
            // lblEmailInstitucionaltitle
            // 
            lblEmailInstitucionaltitle.AutoSize = true;
            lblEmailInstitucionaltitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmailInstitucionaltitle.Location = new Point(191, 59);
            lblEmailInstitucionaltitle.Name = "lblEmailInstitucionaltitle";
            lblEmailInstitucionaltitle.Size = new Size(131, 19);
            lblEmailInstitucionaltitle.TabIndex = 43;
            lblEmailInstitucionaltitle.Text = "E-mail Institucional";
            // 
            // lblMaximo
            // 
            lblMaximo.AutoSize = true;
            lblMaximo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaximo.ForeColor = Color.FromArgb(30, 39, 44);
            lblMaximo.Location = new Point(734, 335);
            lblMaximo.Name = "lblMaximo";
            lblMaximo.Size = new Size(21, 15);
            lblMaximo.TabIndex = 42;
            lblMaximo.Text = "10";
            lblMaximo.TextAlign = ContentAlignment.TopRight;
            // 
            // lblMaximoTitle
            // 
            lblMaximoTitle.AutoSize = true;
            lblMaximoTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaximoTitle.Location = new Point(471, 331);
            lblMaximoTitle.Name = "lblMaximoTitle";
            lblMaximoTitle.Size = new Size(60, 19);
            lblMaximoTitle.TabIndex = 41;
            lblMaximoTitle.Text = "Máximo";
            // 
            // pvPieChart
            // 
            pvPieChart.BackColor = SystemColors.ControlLightLight;
            pvPieChart.BackgroundImage = Properties.Resources.question3;
            pvPieChart.BackgroundImageLayout = ImageLayout.Center;
            pvPieChart.Location = new Point(471, 59);
            pvPieChart.Name = "pvPieChart";
            pvPieChart.PanCursor = Cursors.Hand;
            pvPieChart.Size = new Size(284, 269);
            pvPieChart.TabIndex = 40;
            pvPieChart.Text = "plotView1";
            pvPieChart.ZoomHorizontalCursor = Cursors.SizeWE;
            pvPieChart.ZoomRectangleCursor = Cursors.SizeNWSE;
            pvPieChart.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // lblPrazoDeIntegralizaçãoTitle
            // 
            lblPrazoDeIntegralizaçãoTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPrazoDeIntegralizaçãoTitle.AutoSize = true;
            lblPrazoDeIntegralizaçãoTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrazoDeIntegralizaçãoTitle.ForeColor = Color.FromArgb(30, 39, 44);
            lblPrazoDeIntegralizaçãoTitle.Location = new Point(503, 31);
            lblPrazoDeIntegralizaçãoTitle.Name = "lblPrazoDeIntegralizaçãoTitle";
            lblPrazoDeIntegralizaçãoTitle.Size = new Size(220, 25);
            lblPrazoDeIntegralizaçãoTitle.TabIndex = 39;
            lblPrazoDeIntegralizaçãoTitle.Text = "Prazo de Integralização";
            // 
            // pbPercentualRendimento
            // 
            pbPercentualRendimento.ForeColor = Color.FromArgb(66, 84, 96);
            pbPercentualRendimento.Location = new Point(30, 334);
            pbPercentualRendimento.Name = "pbPercentualRendimento";
            pbPercentualRendimento.Size = new Size(359, 16);
            pbPercentualRendimento.TabIndex = 38;
            // 
            // lblPercentualRendimento
            // 
            lblPercentualRendimento.AutoSize = true;
            lblPercentualRendimento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPercentualRendimento.ForeColor = Color.FromArgb(30, 39, 44);
            lblPercentualRendimento.Location = new Point(28, 316);
            lblPercentualRendimento.Name = "lblPercentualRendimento";
            lblPercentualRendimento.Size = new Size(48, 15);
            lblPercentualRendimento.TabIndex = 37;
            lblPercentualRendimento.Text = "74.28%";
            lblPercentualRendimento.TextAlign = ContentAlignment.TopRight;
            // 
            // lblPercentualRendimentoTitle
            // 
            lblPercentualRendimentoTitle.AutoSize = true;
            lblPercentualRendimentoTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblPercentualRendimentoTitle.Location = new Point(28, 297);
            lblPercentualRendimentoTitle.Name = "lblPercentualRendimentoTitle";
            lblPercentualRendimentoTitle.Size = new Size(174, 19);
            lblPercentualRendimentoTitle.TabIndex = 36;
            lblPercentualRendimentoTitle.Text = "Percentual de Rendimento";
            // 
            // pbPercentualProgressao
            // 
            pbPercentualProgressao.ForeColor = Color.FromArgb(66, 84, 96);
            pbPercentualProgressao.Location = new Point(30, 278);
            pbPercentualProgressao.Name = "pbPercentualProgressao";
            pbPercentualProgressao.Size = new Size(359, 16);
            pbPercentualProgressao.TabIndex = 35;
            // 
            // lblRendimentoCursoTitle
            // 
            lblRendimentoCursoTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblRendimentoCursoTitle.AutoSize = true;
            lblRendimentoCursoTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblRendimentoCursoTitle.ForeColor = Color.FromArgb(30, 39, 44);
            lblRendimentoCursoTitle.Location = new Point(28, 216);
            lblRendimentoCursoTitle.Name = "lblRendimentoCursoTitle";
            lblRendimentoCursoTitle.Size = new Size(207, 25);
            lblRendimentoCursoTitle.TabIndex = 34;
            lblRendimentoCursoTitle.Text = "Rendimento do Curso";
            // 
            // lblLogin
            // 
            lblLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.FromArgb(30, 39, 44);
            lblLogin.Location = new Point(191, 31);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(213, 25);
            lblLogin.TabIndex = 33;
            lblLogin.Text = "Informações Essenciais";
            // 
            // lblPercentualProgressao
            // 
            lblPercentualProgressao.AutoSize = true;
            lblPercentualProgressao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPercentualProgressao.ForeColor = Color.FromArgb(30, 39, 44);
            lblPercentualProgressao.Location = new Point(30, 260);
            lblPercentualProgressao.Name = "lblPercentualProgressao";
            lblPercentualProgressao.Size = new Size(48, 15);
            lblPercentualProgressao.TabIndex = 27;
            lblPercentualProgressao.Text = "74.28%";
            lblPercentualProgressao.TextAlign = ContentAlignment.TopRight;
            // 
            // lblPercentualProgressaoTitle
            // 
            lblPercentualProgressaoTitle.AutoSize = true;
            lblPercentualProgressaoTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblPercentualProgressaoTitle.Location = new Point(30, 241);
            lblPercentualProgressaoTitle.Name = "lblPercentualProgressaoTitle";
            lblPercentualProgressaoTitle.Size = new Size(166, 19);
            lblPercentualProgressaoTitle.TabIndex = 26;
            lblPercentualProgressaoTitle.Text = "Percentual de Progressão";
            // 
            // lblCiclo
            // 
            lblCiclo.AutoSize = true;
            lblCiclo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCiclo.ForeColor = Color.FromArgb(30, 39, 44);
            lblCiclo.Location = new Point(349, 146);
            lblCiclo.Name = "lblCiclo";
            lblCiclo.Size = new Size(14, 15);
            lblCiclo.TabIndex = 25;
            lblCiclo.Text = "1";
            lblCiclo.TextAlign = ContentAlignment.TopRight;
            // 
            // lblCicloTitle
            // 
            lblCicloTitle.AutoSize = true;
            lblCicloTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblCicloTitle.Location = new Point(348, 127);
            lblCicloTitle.Name = "lblCicloTitle";
            lblCicloTitle.Size = new Size(41, 19);
            lblCicloTitle.TabIndex = 24;
            lblCicloTitle.Text = "Ciclo";
            // 
            // lblRA
            // 
            lblRA.AutoSize = true;
            lblRA.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblRA.ForeColor = Color.FromArgb(30, 39, 44);
            lblRA.Location = new Point(191, 146);
            lblRA.Name = "lblRA";
            lblRA.Size = new Size(91, 15);
            lblRA.TabIndex = 23;
            lblRA.Text = "123123123123";
            lblRA.TextAlign = ContentAlignment.TopRight;
            // 
            // lblRATitle
            // 
            lblRATitle.AutoSize = true;
            lblRATitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblRATitle.Location = new Point(191, 127);
            lblRATitle.Name = "lblRATitle";
            lblRATitle.Size = new Size(27, 19);
            lblRATitle.TabIndex = 22;
            lblRATitle.Text = "RA";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.ForeColor = Color.FromArgb(30, 39, 44);
            lblNome.Location = new Point(191, 112);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(138, 15);
            lblNome.TabIndex = 21;
            lblNome.Text = "Marcos Gasparini Junior";
            lblNome.TextAlign = ContentAlignment.TopRight;
            // 
            // lblNomeTitle
            // 
            lblNomeTitle.AutoSize = true;
            lblNomeTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomeTitle.Location = new Point(191, 93);
            lblNomeTitle.Name = "lblNomeTitle";
            lblNomeTitle.Size = new Size(47, 19);
            lblNomeTitle.TabIndex = 1;
            lblNomeTitle.Text = "Nome";
            // 
            // pcbUser
            // 
            pcbUser.BackColor = Color.FromArgb(224, 224, 224);
            pcbUser.Image = (Image)resources.GetObject("pcbUser.Image");
            pcbUser.Location = new Point(30, 39);
            pcbUser.Name = "pcbUser";
            pcbUser.Size = new Size(140, 140);
            pcbUser.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbUser.TabIndex = 0;
            pcbUser.TabStop = false;
            // 
            // PerfilControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContainer);
            Name = "PerfilControl";
            Size = new Size(800, 389);
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContainer;
        private PictureBox pcbUser;
        private Label lblNomeTitle;
        private Label lblCiclo;
        private Label lblCicloTitle;
        private Label lblRA;
        private Label lblRATitle;
        private Label lblNome;
        private Label lblPercentualProgressao;
        private Label lblPercentualProgressaoTitle;
        private Label lblRendimentoCursoTitle;
        private Label lblLogin;
        private ProgressBar pbPercentualRendimento;
        private Label lblPercentualRendimento;
        private Label lblPercentualRendimentoTitle;
        private ProgressBar pbPercentualProgressao;
        private Label lblPrazoDeIntegralizaçãoTitle;
        private OxyPlot.WindowsForms.PlotView pvPieChart;
        private Label lblEmailInstitucional;
        private Label lblEmailInstitucionaltitle;
        private Label lblMaximo;
        private Label lblMaximoTitle;
    }
}
