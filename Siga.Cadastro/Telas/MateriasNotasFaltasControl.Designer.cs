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
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(800, 389);
            panelContainer.TabIndex = 72;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblNenhumResultado);
            panel1.Controls.Add(dgvMateriasNotasFaltas);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 294);
            panel1.TabIndex = 1;
            // 
            // lblNenhumResultado
            // 
            lblNenhumResultado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNenhumResultado.AutoSize = true;
            lblNenhumResultado.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNenhumResultado.ForeColor = Color.FromArgb(30, 39, 44);
            lblNenhumResultado.Location = new Point(260, 130);
            lblNenhumResultado.Name = "lblNenhumResultado";
            lblNenhumResultado.Size = new Size(292, 25);
            lblNenhumResultado.TabIndex = 50;
            lblNenhumResultado.Text = "Nenhum resultado encontrado.";
            lblNenhumResultado.Visible = false;
            // 
            // dgvMateriasNotasFaltas
            // 
            dgvMateriasNotasFaltas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMateriasNotasFaltas.Dock = DockStyle.Fill;
            dgvMateriasNotasFaltas.Location = new Point(0, 0);
            dgvMateriasNotasFaltas.Name = "dgvMateriasNotasFaltas";
            dgvMateriasNotasFaltas.RowTemplate.Height = 25;
            dgvMateriasNotasFaltas.Size = new Size(800, 294);
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
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(800, 95);
            panelHeader.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(66, 84, 96);
            btnSearch.BackgroundColor = Color.FromArgb(66, 84, 96);
            btnSearch.BorderColor = Color.FromArgb(64, 64, 64);
            btnSearch.BorderRadius = 3;
            btnSearch.BorderSize = 1;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(294, 61);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(30, 30);
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
            btnClear.BorderRadius = 3;
            btnClear.BorderSize = 1;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Image = (Image)resources.GetObject("btnClear.Image");
            btnClear.Location = new Point(328, 61);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(30, 30);
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
            btnEncerrarCiclo.BorderRadius = 3;
            btnEncerrarCiclo.BorderSize = 1;
            btnEncerrarCiclo.FlatAppearance.BorderSize = 0;
            btnEncerrarCiclo.FlatStyle = FlatStyle.Flat;
            btnEncerrarCiclo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEncerrarCiclo.ForeColor = Color.White;
            btnEncerrarCiclo.Location = new Point(697, 61);
            btnEncerrarCiclo.Name = "btnEncerrarCiclo";
            btnEncerrarCiclo.Size = new Size(100, 29);
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
            panelSubHeaderLoginSiga.Name = "panelSubHeaderLoginSiga";
            panelSubHeaderLoginSiga.Size = new Size(800, 36);
            panelSubHeaderLoginSiga.TabIndex = 44;
            // 
            // lblUltimaAtualizacao
            // 
            lblUltimaAtualizacao.AutoSize = true;
            lblUltimaAtualizacao.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblUltimaAtualizacao.Location = new Point(328, 10);
            lblUltimaAtualizacao.Name = "lblUltimaAtualizacao";
            lblUltimaAtualizacao.Size = new Size(279, 19);
            lblUltimaAtualizacao.TabIndex = 49;
            lblUltimaAtualizacao.Text = "Última Atualização - dd/MM/YYYY HH:mm";
            // 
            // lblCiclo
            // 
            lblCiclo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCiclo.AutoSize = true;
            lblCiclo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCiclo.ForeColor = Color.FromArgb(30, 39, 44);
            lblCiclo.Location = new Point(714, 4);
            lblCiclo.Name = "lblCiclo";
            lblCiclo.Size = new Size(76, 25);
            lblCiclo.TabIndex = 33;
            lblCiclo.Text = "Ciclo  1";
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(30, 39, 44);
            lblTitle.Location = new Point(7, 4);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(225, 25);
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
            txtMateria.Location = new Point(37, 62);
            txtMateria.Margin = new Padding(4);
            txtMateria.Multiline = false;
            txtMateria.Name = "txtMateria";
            txtMateria.Padding = new Padding(7);
            txtMateria.PasswordChar = false;
            txtMateria.Size = new Size(250, 29);
            txtMateria.TabIndex = 42;
            txtMateria.Texts = "";
            txtMateria.UnderlinedStyle = true;
            // 
            // pcbEmail
            // 
            pcbEmail.Image = (Image)resources.GetObject("pcbEmail.Image");
            pcbEmail.Location = new Point(3, 61);
            pcbEmail.Name = "pcbEmail";
            pcbEmail.Size = new Size(30, 30);
            pcbEmail.TabIndex = 43;
            pcbEmail.TabStop = false;
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblMateria.Location = new Point(37, 39);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(57, 19);
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContainer);
            Name = "MateriasNotasFaltasControl";
            Size = new Size(800, 389);
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
