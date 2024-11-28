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
            panelInfoConfig = new Panel();
            lblLoopingtime = new Label();
            label1 = new Label();
            btnMoreTime = new CustomButton();
            lblContador = new Label();
            btnLessTime = new CustomButton();
            lblUltimaModificacao = new Label();
            lblStatus = new Label();
            lblContadorTitle = new Label();
            lblUltimaModificacaoTitle = new Label();
            lblStatusTitle = new Label();
            lblInformacoes = new Label();
            lblColetarNotas = new Label();
            tbColetarNotas = new CustomControls.CustomControls.CustomToggleButton();
            lblItensParaAtualizar = new Label();
            lblColetarFaltas = new Label();
            tbColetarMaterias = new CustomControls.CustomControls.CustomToggleButton();
            lblColetarMaterias = new Label();
            tbColetarFaltas = new CustomControls.CustomControls.CustomToggleButton();
            panelFooter = new Panel();
            btnLooping = new CustomButton();
            btnStop = new CustomButton();
            btnStart = new CustomButton();
            panelInfoConfigTab = new Panel();
            lblColetorDeDados = new Label();
            panel2 = new Panel();
            panelConsoleContainer = new Panel();
            fileSystemWatcher1 = new FileSystemWatcher();
            panel1.SuspendLayout();
            panelInfoConfig.SuspendLayout();
            panelFooter.SuspendLayout();
            panelInfoConfigTab.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(panelInfoConfig);
            panel1.Controls.Add(panelInfoConfigTab);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(343, 519);
            panel1.TabIndex = 0;
            // 
            // panelInfoConfig
            // 
            panelInfoConfig.BackColor = Color.White;
            panelInfoConfig.Controls.Add(lblLoopingtime);
            panelInfoConfig.Controls.Add(label1);
            panelInfoConfig.Controls.Add(btnMoreTime);
            panelInfoConfig.Controls.Add(lblContador);
            panelInfoConfig.Controls.Add(btnLessTime);
            panelInfoConfig.Controls.Add(lblUltimaModificacao);
            panelInfoConfig.Controls.Add(lblStatus);
            panelInfoConfig.Controls.Add(lblContadorTitle);
            panelInfoConfig.Controls.Add(lblUltimaModificacaoTitle);
            panelInfoConfig.Controls.Add(lblStatusTitle);
            panelInfoConfig.Controls.Add(lblInformacoes);
            panelInfoConfig.Controls.Add(lblColetarNotas);
            panelInfoConfig.Controls.Add(tbColetarNotas);
            panelInfoConfig.Controls.Add(lblItensParaAtualizar);
            panelInfoConfig.Controls.Add(lblColetarFaltas);
            panelInfoConfig.Controls.Add(tbColetarMaterias);
            panelInfoConfig.Controls.Add(lblColetarMaterias);
            panelInfoConfig.Controls.Add(tbColetarFaltas);
            panelInfoConfig.Controls.Add(panelFooter);
            panelInfoConfig.Location = new Point(0, 71);
            panelInfoConfig.Margin = new Padding(3, 4, 3, 4);
            panelInfoConfig.Name = "panelInfoConfig";
            panelInfoConfig.Size = new Size(343, 448);
            panelInfoConfig.TabIndex = 35;
            // 
            // lblLoopingtime
            // 
            lblLoopingtime.AutoSize = true;
            lblLoopingtime.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblLoopingtime.ForeColor = Color.FromArgb(30, 39, 44);
            lblLoopingtime.Location = new Point(51, 327);
            lblLoopingtime.Name = "lblLoopingtime";
            lblLoopingtime.Size = new Size(32, 20);
            lblLoopingtime.TabIndex = 28;
            lblLoopingtime.Text = "1m";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(30, 39, 44);
            label1.Location = new Point(26, 291);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 27;
            label1.Text = "Tempo Looping";
            // 
            // btnMoreTime
            // 
            btnMoreTime.BackColor = Color.FromArgb(66, 84, 96);
            btnMoreTime.BackgroundColor = Color.FromArgb(66, 84, 96);
            btnMoreTime.BorderColor = Color.Gray;
            btnMoreTime.BorderRadiusPercentage = 10F;
            btnMoreTime.BorderSize = 0;
            btnMoreTime.FlatAppearance.BorderSize = 0;
            btnMoreTime.FlatStyle = FlatStyle.Flat;
            btnMoreTime.ForeColor = Color.White;
            btnMoreTime.Image = (Image)resources.GetObject("btnMoreTime.Image");
            btnMoreTime.Location = new Point(93, 313);
            btnMoreTime.Margin = new Padding(3, 4, 3, 4);
            btnMoreTime.Name = "btnMoreTime";
            btnMoreTime.Size = new Size(23, 20);
            btnMoreTime.TabIndex = 25;
            btnMoreTime.TextColor = Color.White;
            btnMoreTime.UseVisualStyleBackColor = false;
            btnMoreTime.Click += btnMoreTime_Click;
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblContador.ForeColor = Color.FromArgb(30, 39, 44);
            lblContador.Location = new Point(142, 79);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(18, 20);
            lblContador.TabIndex = 23;
            lblContador.Text = "0";
            lblContador.TextAlign = ContentAlignment.TopRight;
            // 
            // btnLessTime
            // 
            btnLessTime.BackColor = Color.FromArgb(66, 84, 96);
            btnLessTime.BackgroundColor = Color.FromArgb(66, 84, 96);
            btnLessTime.BorderColor = Color.Gray;
            btnLessTime.BorderRadiusPercentage = 10F;
            btnLessTime.BorderSize = 0;
            btnLessTime.FlatAppearance.BorderSize = 0;
            btnLessTime.FlatStyle = FlatStyle.Flat;
            btnLessTime.ForeColor = Color.White;
            btnLessTime.Image = (Image)resources.GetObject("btnLessTime.Image");
            btnLessTime.Location = new Point(93, 335);
            btnLessTime.Margin = new Padding(3, 4, 3, 4);
            btnLessTime.Name = "btnLessTime";
            btnLessTime.Size = new Size(23, 20);
            btnLessTime.TabIndex = 26;
            btnLessTime.TextColor = Color.White;
            btnLessTime.UseVisualStyleBackColor = false;
            btnLessTime.Click += btnLessTime_Click;
            // 
            // lblUltimaModificacao
            // 
            lblUltimaModificacao.AutoSize = true;
            lblUltimaModificacao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUltimaModificacao.ForeColor = Color.FromArgb(30, 39, 44);
            lblUltimaModificacao.Location = new Point(160, 119);
            lblUltimaModificacao.Name = "lblUltimaModificacao";
            lblUltimaModificacao.Size = new Size(119, 20);
            lblUltimaModificacao.TabIndex = 22;
            lblUltimaModificacao.Text = "dd/mm hh/MM";
            lblUltimaModificacao.TextAlign = ContentAlignment.TopRight;
            lblUltimaModificacao.Visible = false;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.FromArgb(176, 0, 0);
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(86, 41);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(58, 20);
            lblStatus.TabIndex = 21;
            lblStatus.Text = "Parado";
            lblStatus.TextAlign = ContentAlignment.TopRight;
            // 
            // lblContadorTitle
            // 
            lblContadorTitle.AutoSize = true;
            lblContadorTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblContadorTitle.ForeColor = Color.FromArgb(30, 39, 44);
            lblContadorTitle.Location = new Point(23, 79);
            lblContadorTitle.Name = "lblContadorTitle";
            lblContadorTitle.Size = new Size(122, 20);
            lblContadorTitle.TabIndex = 20;
            lblContadorTitle.Text = "Qtd. Execuções :";
            lblContadorTitle.TextAlign = ContentAlignment.TopRight;
            // 
            // lblUltimaModificacaoTitle
            // 
            lblUltimaModificacaoTitle.AutoSize = true;
            lblUltimaModificacaoTitle.BackColor = Color.White;
            lblUltimaModificacaoTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUltimaModificacaoTitle.ForeColor = Color.FromArgb(30, 39, 44);
            lblUltimaModificacaoTitle.Location = new Point(23, 119);
            lblUltimaModificacaoTitle.Name = "lblUltimaModificacaoTitle";
            lblUltimaModificacaoTitle.Size = new Size(145, 20);
            lblUltimaModificacaoTitle.TabIndex = 19;
            lblUltimaModificacaoTitle.Text = "Última Modificação";
            lblUltimaModificacaoTitle.TextAlign = ContentAlignment.TopRight;
            lblUltimaModificacaoTitle.Visible = false;
            // 
            // lblStatusTitle
            // 
            lblStatusTitle.AutoSize = true;
            lblStatusTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatusTitle.ForeColor = Color.FromArgb(30, 39, 44);
            lblStatusTitle.Location = new Point(23, 41);
            lblStatusTitle.Name = "lblStatusTitle";
            lblStatusTitle.Size = new Size(61, 20);
            lblStatusTitle.TabIndex = 18;
            lblStatusTitle.Text = "Status :";
            lblStatusTitle.TextAlign = ContentAlignment.TopRight;
            // 
            // lblInformacoes
            // 
            lblInformacoes.AutoSize = true;
            lblInformacoes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblInformacoes.ForeColor = Color.FromArgb(30, 39, 44);
            lblInformacoes.Location = new Point(19, 4);
            lblInformacoes.Name = "lblInformacoes";
            lblInformacoes.Size = new Size(108, 23);
            lblInformacoes.TabIndex = 17;
            lblInformacoes.Text = "Informações";
            lblInformacoes.TextAlign = ContentAlignment.TopRight;
            // 
            // lblColetarNotas
            // 
            lblColetarNotas.AutoSize = true;
            lblColetarNotas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblColetarNotas.ForeColor = Color.FromArgb(30, 39, 44);
            lblColetarNotas.Location = new Point(26, 221);
            lblColetarNotas.Name = "lblColetarNotas";
            lblColetarNotas.Size = new Size(51, 20);
            lblColetarNotas.TabIndex = 13;
            lblColetarNotas.Text = "Notas";
            // 
            // tbColetarNotas
            // 
            tbColetarNotas.Checked = true;
            tbColetarNotas.CheckState = CheckState.Checked;
            tbColetarNotas.Location = new Point(26, 245);
            tbColetarNotas.Margin = new Padding(3, 4, 3, 4);
            tbColetarNotas.MinimumSize = new Size(51, 29);
            tbColetarNotas.Name = "tbColetarNotas";
            tbColetarNotas.OffBackColor = Color.Gray;
            tbColetarNotas.OffToggleColor = Color.Gainsboro;
            tbColetarNotas.OnBackColor = Color.FromArgb(66, 84, 96);
            tbColetarNotas.OnToggleColor = Color.WhiteSmoke;
            tbColetarNotas.Size = new Size(51, 29);
            tbColetarNotas.TabIndex = 16;
            tbColetarNotas.UseVisualStyleBackColor = true;
            // 
            // lblItensParaAtualizar
            // 
            lblItensParaAtualizar.AutoSize = true;
            lblItensParaAtualizar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblItensParaAtualizar.ForeColor = Color.FromArgb(30, 39, 44);
            lblItensParaAtualizar.Location = new Point(19, 189);
            lblItensParaAtualizar.Name = "lblItensParaAtualizar";
            lblItensParaAtualizar.Size = new Size(165, 23);
            lblItensParaAtualizar.TabIndex = 14;
            lblItensParaAtualizar.Text = "Itens Para Atualizar";
            lblItensParaAtualizar.TextAlign = ContentAlignment.TopRight;
            // 
            // lblColetarFaltas
            // 
            lblColetarFaltas.AutoSize = true;
            lblColetarFaltas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblColetarFaltas.ForeColor = Color.FromArgb(30, 39, 44);
            lblColetarFaltas.Location = new Point(155, 221);
            lblColetarFaltas.Name = "lblColetarFaltas";
            lblColetarFaltas.Size = new Size(50, 20);
            lblColetarFaltas.TabIndex = 9;
            lblColetarFaltas.Text = "Faltas";
            // 
            // tbColetarMaterias
            // 
            tbColetarMaterias.Checked = true;
            tbColetarMaterias.CheckState = CheckState.Checked;
            tbColetarMaterias.Location = new Point(87, 245);
            tbColetarMaterias.Margin = new Padding(3, 4, 3, 4);
            tbColetarMaterias.MinimumSize = new Size(51, 29);
            tbColetarMaterias.Name = "tbColetarMaterias";
            tbColetarMaterias.OffBackColor = Color.Gray;
            tbColetarMaterias.OffToggleColor = Color.Gainsboro;
            tbColetarMaterias.OnBackColor = Color.FromArgb(66, 84, 96);
            tbColetarMaterias.OnToggleColor = Color.WhiteSmoke;
            tbColetarMaterias.Size = new Size(51, 29);
            tbColetarMaterias.TabIndex = 12;
            tbColetarMaterias.UseVisualStyleBackColor = true;
            // 
            // lblColetarMaterias
            // 
            lblColetarMaterias.AutoSize = true;
            lblColetarMaterias.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblColetarMaterias.ForeColor = Color.FromArgb(30, 39, 44);
            lblColetarMaterias.Location = new Point(86, 221);
            lblColetarMaterias.Name = "lblColetarMaterias";
            lblColetarMaterias.Size = new Size(70, 20);
            lblColetarMaterias.TabIndex = 10;
            lblColetarMaterias.Text = "Matérias";
            lblColetarMaterias.TextAlign = ContentAlignment.TopRight;
            // 
            // tbColetarFaltas
            // 
            tbColetarFaltas.Checked = true;
            tbColetarFaltas.CheckState = CheckState.Checked;
            tbColetarFaltas.Location = new Point(154, 245);
            tbColetarFaltas.Margin = new Padding(3, 4, 3, 4);
            tbColetarFaltas.MinimumSize = new Size(51, 29);
            tbColetarFaltas.Name = "tbColetarFaltas";
            tbColetarFaltas.OffBackColor = Color.Gray;
            tbColetarFaltas.OffToggleColor = Color.Gainsboro;
            tbColetarFaltas.OnBackColor = Color.FromArgb(66, 84, 96);
            tbColetarFaltas.OnToggleColor = Color.WhiteSmoke;
            tbColetarFaltas.Size = new Size(51, 29);
            tbColetarFaltas.TabIndex = 11;
            tbColetarFaltas.UseVisualStyleBackColor = true;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = SystemColors.Control;
            panelFooter.Controls.Add(btnLooping);
            panelFooter.Controls.Add(btnStop);
            panelFooter.Controls.Add(btnStart);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 363);
            panelFooter.Margin = new Padding(3, 4, 3, 4);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(343, 85);
            panelFooter.TabIndex = 1;
            // 
            // btnLooping
            // 
            btnLooping.BackColor = Color.White;
            btnLooping.BackgroundColor = Color.White;
            btnLooping.BorderColor = Color.Black;
            btnLooping.BorderRadiusPercentage = 50F;
            btnLooping.BorderSize = 1;
            btnLooping.FlatAppearance.BorderSize = 0;
            btnLooping.FlatStyle = FlatStyle.Flat;
            btnLooping.ForeColor = Color.White;
            btnLooping.Image = (Image)resources.GetObject("btnLooping.Image");
            btnLooping.Location = new Point(206, 25);
            btnLooping.Margin = new Padding(3, 4, 3, 4);
            btnLooping.Name = "btnLooping";
            btnLooping.Size = new Size(34, 40);
            btnLooping.TabIndex = 2;
            btnLooping.TextColor = Color.White;
            btnLooping.UseVisualStyleBackColor = false;
            btnLooping.Click += btnLooping_Click;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.White;
            btnStop.BackgroundColor = Color.White;
            btnStop.BorderColor = Color.Black;
            btnStop.BorderRadiusPercentage = 50F;
            btnStop.BorderSize = 1;
            btnStop.FlatAppearance.BorderSize = 0;
            btnStop.FlatStyle = FlatStyle.Flat;
            btnStop.ForeColor = Color.White;
            btnStop.Image = (Image)resources.GetObject("btnStop.Image");
            btnStop.Location = new Point(97, 25);
            btnStop.Margin = new Padding(3, 4, 3, 4);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(34, 40);
            btnStop.TabIndex = 1;
            btnStop.TextColor = Color.White;
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.White;
            btnStart.BackgroundColor = Color.White;
            btnStart.BorderColor = Color.Black;
            btnStart.BorderRadiusPercentage = 50F;
            btnStart.BorderSize = 1;
            btnStart.FlatAppearance.BorderSize = 0;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.ForeColor = Color.White;
            btnStart.Image = (Image)resources.GetObject("btnStart.Image");
            btnStart.Location = new Point(138, 4);
            btnStart.Margin = new Padding(3, 4, 3, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(61, 71);
            btnStart.TabIndex = 0;
            btnStart.TextColor = Color.White;
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // panelInfoConfigTab
            // 
            panelInfoConfigTab.Controls.Add(lblColetorDeDados);
            panelInfoConfigTab.Dock = DockStyle.Top;
            panelInfoConfigTab.Location = new Point(0, 0);
            panelInfoConfigTab.Margin = new Padding(3, 4, 3, 4);
            panelInfoConfigTab.Name = "panelInfoConfigTab";
            panelInfoConfigTab.Size = new Size(343, 71);
            panelInfoConfigTab.TabIndex = 34;
            // 
            // lblColetorDeDados
            // 
            lblColetorDeDados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblColetorDeDados.AutoSize = true;
            lblColetorDeDados.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblColetorDeDados.ForeColor = Color.FromArgb(30, 39, 44);
            lblColetorDeDados.Location = new Point(23, 20);
            lblColetorDeDados.Name = "lblColetorDeDados";
            lblColetorDeDados.Size = new Size(209, 32);
            lblColetorDeDados.TabIndex = 33;
            lblColetorDeDados.Text = "Coletor de dados";
            // 
            // panel2
            // 
            panel2.Controls.Add(panelConsoleContainer);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(343, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(571, 519);
            panel2.TabIndex = 1;
            // 
            // panelConsoleContainer
            // 
            panelConsoleContainer.Dock = DockStyle.Fill;
            panelConsoleContainer.Location = new Point(0, 0);
            panelConsoleContainer.Margin = new Padding(3, 4, 3, 4);
            panelConsoleContainer.Name = "panelConsoleContainer";
            panelConsoleContainer.Size = new Size(571, 519);
            panelConsoleContainer.TabIndex = 2;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // HomeControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "HomeControl";
            Size = new Size(914, 519);
            panel1.ResumeLayout(false);
            panelInfoConfig.ResumeLayout(false);
            panelInfoConfig.PerformLayout();
            panelFooter.ResumeLayout(false);
            panelInfoConfigTab.ResumeLayout(false);
            panelInfoConfigTab.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private CustomButton btnStart;
        private Panel panelInfoConfigTab;
        private Label lblColetorDeDados;
        private Panel panelInfoConfig;
        private Panel panelConsoleContainer;
        private Panel panelFooter;
        private Label lblColetarNotas;
        private CustomControls.CustomControls.CustomToggleButton tbColetarNotas;
        private Label lblItensParaAtualizar;
        private Label lblColetarFaltas;
        private CustomControls.CustomControls.CustomToggleButton tbColetarMaterias;
        private Label lblColetarMaterias;
        private CustomControls.CustomControls.CustomToggleButton tbColetarFaltas;
        private Label lblContadorTitle;
        private Label lblUltimaModificacaoTitle;
        private Label lblStatusTitle;
        private Label lblInformacoes;
        private Label lblContador;
        private Label lblUltimaModificacao;
        private Label lblStatus;
        private CustomButton btnStop;
        private CustomButton btnLooping;
        private FileSystemWatcher fileSystemWatcher1;
        private CustomButton btnMoreTime;
        private CustomButton btnLessTime;
        private Label label1;
        private Label lblLoopingtime;
    }
}
