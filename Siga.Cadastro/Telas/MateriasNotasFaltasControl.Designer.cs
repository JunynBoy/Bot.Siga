namespace Bot.App.Controls
{
    partial class MateriasNotasFaltasControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MateriasNotasFaltasControl));
            panelContainer = new Panel();
            panel1 = new Panel();
            lblNenhumResultado = new Label();
            dgvMateriasNotasFaltas = new DataGridView();
            panelHeader = new Panel();
            btnSearch = new CustomButton();
            btnClear = new CustomButton();
            btnEncerrarCiclo = new CustomButton();
            panelSubHeaderLoginSiga = new Panel();
            lblUltimaAtualizacao = new Label();
            lblCiclo = new Label();
            lblTitle = new Label();
            txtMateria = new CustomTextBox();
            pcbEmail = new PictureBox();
            lblMateria = new Label();
            mySqlDataAdapter1 = new MySqlConnector.MySqlDataAdapter();
            panelContainer.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMateriasNotasFaltas).BeginInit();
            panelHeader.SuspendLayout();
            panelSubHeaderLoginSiga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbEmail).BeginInit();
            SuspendLayout();
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(panel1);
            panelContainer.Controls.Add(panelHeader);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 0);
            panelContainer.Margin = new Padding(3, 4, 3, 4);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(914, 519);
            panelContainer.TabIndex = 72;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblNenhumResultado);
            panel1.Controls.Add(dgvMateriasNotasFaltas);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 127);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 392);
            panel1.TabIndex = 1;
            // 
            // lblNenhumResultado
            // 
            lblNenhumResultado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNenhumResultado.AutoSize = true;
            lblNenhumResultado.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNenhumResultado.ForeColor = Color.FromArgb(30, 39, 44);
            lblNenhumResultado.Location = new Point(297, 173);
            lblNenhumResultado.Name = "lblNenhumResultado";
            lblNenhumResultado.Size = new Size(373, 32);
            lblNenhumResultado.TabIndex = 50;
            lblNenhumResultado.Text = "Nenhum resultado encontrado.";
            lblNenhumResultado.Visible = false;
            // 
            // dgvMateriasNotasFaltas
            // 
            dgvMateriasNotasFaltas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMateriasNotasFaltas.Dock = DockStyle.Fill;
            dgvMateriasNotasFaltas.Location = new Point(0, 0);
            dgvMateriasNotasFaltas.Margin = new Padding(3, 4, 3, 4);
            dgvMateriasNotasFaltas.Name = "dgvMateriasNotasFaltas";
            dgvMateriasNotasFaltas.RowHeadersWidth = 51;
            dgvMateriasNotasFaltas.RowTemplate.Height = 25;
            dgvMateriasNotasFaltas.Size = new Size(914, 392);
            dgvMateriasNotasFaltas.TabIndex = 0;
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(btnSearch);
            panelHeader.Controls.Add(btnClear);
            panelHeader.Controls.Add(btnEncerrarCiclo);
            panelHeader.Controls.Add(panelSubHeaderLoginSiga);
            panelHeader.Controls.Add(txtMateria);
            panelHeader.Controls.Add(pcbEmail);
            panelHeader.Controls.Add(lblMateria);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 4, 3, 4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(914, 127);
            panelHeader.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(66, 84, 96);
            btnSearch.BackgroundColor = Color.FromArgb(66, 84, 96);
            btnSearch.BorderColor = Color.FromArgb(64, 64, 64);
            btnSearch.BorderRadiusPercentage = 10F;
            btnSearch.BorderSize = 1;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(336, 81);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(34, 40);
            btnSearch.TabIndex = 49;
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(66, 84, 96);
            btnClear.BackgroundColor = Color.FromArgb(66, 84, 96);
            btnClear.BorderColor = Color.FromArgb(64, 64, 64);
            btnClear.BorderRadiusPercentage = 10F;
            btnClear.BorderSize = 1;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Image = (Image)resources.GetObject("btnClear.Image");
            btnClear.Location = new Point(375, 81);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(34, 40);
            btnClear.TabIndex = 48;
            btnClear.TextColor = Color.White;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnEncerrarCiclo
            // 
            btnEncerrarCiclo.BackColor = Color.FromArgb(66, 84, 96);
            btnEncerrarCiclo.BackgroundColor = Color.FromArgb(66, 84, 96);
            btnEncerrarCiclo.BorderColor = Color.FromArgb(64, 64, 64);
            btnEncerrarCiclo.BorderRadiusPercentage = 10F;
            btnEncerrarCiclo.BorderSize = 1;
            btnEncerrarCiclo.FlatAppearance.BorderSize = 0;
            btnEncerrarCiclo.FlatStyle = FlatStyle.Flat;
            btnEncerrarCiclo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEncerrarCiclo.ForeColor = Color.White;
            btnEncerrarCiclo.Location = new Point(797, 81);
            btnEncerrarCiclo.Margin = new Padding(3, 4, 3, 4);
            btnEncerrarCiclo.Name = "btnEncerrarCiclo";
            btnEncerrarCiclo.Size = new Size(114, 39);
            btnEncerrarCiclo.TabIndex = 47;
            btnEncerrarCiclo.Text = "Limpar Dados";
            btnEncerrarCiclo.TextColor = Color.White;
            btnEncerrarCiclo.UseVisualStyleBackColor = false;
            btnEncerrarCiclo.Click += btnEncerrarCiclo_Click;
            // 
            // panelSubHeaderLoginSiga
            // 
            panelSubHeaderLoginSiga.BackColor = Color.White;
            panelSubHeaderLoginSiga.Controls.Add(lblUltimaAtualizacao);
            panelSubHeaderLoginSiga.Controls.Add(lblCiclo);
            panelSubHeaderLoginSiga.Controls.Add(lblTitle);
            panelSubHeaderLoginSiga.Dock = DockStyle.Top;
            panelSubHeaderLoginSiga.Location = new Point(0, 0);
            panelSubHeaderLoginSiga.Margin = new Padding(3, 4, 3, 4);
            panelSubHeaderLoginSiga.Name = "panelSubHeaderLoginSiga";
            panelSubHeaderLoginSiga.Size = new Size(914, 48);
            panelSubHeaderLoginSiga.TabIndex = 44;
            // 
            // lblUltimaAtualizacao
            // 
            lblUltimaAtualizacao.AutoSize = true;
            lblUltimaAtualizacao.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblUltimaAtualizacao.Location = new Point(375, 13);
            lblUltimaAtualizacao.Name = "lblUltimaAtualizacao";
            lblUltimaAtualizacao.Size = new Size(341, 23);
            lblUltimaAtualizacao.TabIndex = 49;
            lblUltimaAtualizacao.Text = "Última Atualização - dd/MM/YYYY HH:mm";
            // 
            // lblCiclo
            // 
            lblCiclo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCiclo.AutoSize = true;
            lblCiclo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCiclo.ForeColor = Color.FromArgb(30, 39, 44);
            lblCiclo.Location = new Point(816, 5);
            lblCiclo.Name = "lblCiclo";
            lblCiclo.Size = new Size(98, 32);
            lblCiclo.TabIndex = 33;
            lblCiclo.Text = "Ciclo  1";
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(30, 39, 44);
            lblTitle.Location = new Point(8, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(294, 32);
            lblTitle.TabIndex = 32;
            lblTitle.Text = "Matérias / Notas / Faltas";
            // 
            // txtMateria
            // 
            txtMateria.BackColor = SystemColors.Window;
            txtMateria.BorderColor = Color.FromArgb(66, 84, 96);
            txtMateria.BorderFocusColor = Color.FromArgb(176, 0, 0);
            txtMateria.BorderSize = 1;
            txtMateria.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtMateria.ForeColor = Color.DimGray;
            txtMateria.Location = new Point(42, 83);
            txtMateria.Margin = new Padding(5, 5, 5, 5);
            txtMateria.Multiline = false;
            txtMateria.Name = "txtMateria";
            txtMateria.Padding = new Padding(8, 9, 8, 9);
            txtMateria.PasswordChar = false;
            txtMateria.Size = new Size(286, 38);
            txtMateria.TabIndex = 42;
            txtMateria.Texts = "";
            txtMateria.UnderlinedStyle = true;
            // 
            // pcbEmail
            // 
            pcbEmail.Image = (Image)resources.GetObject("pcbEmail.Image");
            pcbEmail.Location = new Point(3, 81);
            pcbEmail.Margin = new Padding(3, 4, 3, 4);
            pcbEmail.Name = "pcbEmail";
            pcbEmail.Size = new Size(34, 40);
            pcbEmail.TabIndex = 43;
            pcbEmail.TabStop = false;
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblMateria.Location = new Point(42, 52);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(69, 23);
            lblMateria.TabIndex = 41;
            lblMateria.Text = "Matéria";
            // 
            // mySqlDataAdapter1
            // 
            mySqlDataAdapter1.DeleteCommand = null;
            mySqlDataAdapter1.InsertCommand = null;
            mySqlDataAdapter1.SelectCommand = null;
            mySqlDataAdapter1.UpdateBatchSize = 0;
            mySqlDataAdapter1.UpdateCommand = null;
            // 
            // MateriasNotasFaltasControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContainer);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MateriasNotasFaltasControl";
            Size = new Size(914, 519);
            panelContainer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMateriasNotasFaltas).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelSubHeaderLoginSiga.ResumeLayout(false);
            panelSubHeaderLoginSiga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbEmail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblCiclo;
        private Label lblTitle;
        private Panel panelContainer;
        private Panel panelHeader;
        private MySqlConnector.MySqlDataAdapter mySqlDataAdapter1;
        private CustomButton customButton2;
        private CustomTextBox txtMateria;
        private PictureBox pcbEmail;
        private Label lblMateria;
        private CustomButton customButton1;
        private Panel panelSubHeaderLoginSiga;
        private CustomButton btnEncerrarCiclo;
        private CustomButton btnClear;
        private Label lblUltimaAtualizacao;
        private CustomButton btnSearch;
        private Panel panel1;
        private DataGridView dgvMateriasNotasFaltas;
        private Label lblNenhumResultado;
    }
}
