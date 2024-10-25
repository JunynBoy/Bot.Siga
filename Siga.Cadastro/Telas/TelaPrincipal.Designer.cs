namespace Bot.App.Telas
{
    partial class TelaPrincipal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            panelHeader = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnClose = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panelHeaderOptions = new Panel();
            btnPreferencias = new Controls.CustomButton();
            this.btnMateriaNotasFaltas = new Controls.CustomButton();
            this.btnPerfil = new Controls.CustomButton();
            btnHome = new Controls.CustomButton();
            panelContainer = new Panel();
            btnSigaImage = new Controls.CustomButton();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelHeaderOptions.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(66, 84, 96);
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Controls.Add(label1);
            panelHeader.Controls.Add(btnClose);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(800, 35);
            panelHeader.TabIndex = 35;
            panelHeader.MouseDown += panelHeader_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 35);
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(36, 9);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 35;
            label1.Text = "Nome usuário";
            label1.Click += label1_Click;
            // 
            // btnClose
            // 
            btnClose.BackgroundImageLayout = ImageLayout.None;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 0, 0);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(216, 0, 0);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(765, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 35);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // panelHeaderOptions
            // 
            panelHeaderOptions.BackColor = Color.FromArgb(176, 0, 0);
            panelHeaderOptions.Controls.Add(btnSigaImage);
            panelHeaderOptions.Controls.Add(btnPreferencias);
            panelHeaderOptions.Controls.Add(this.btnMateriaNotasFaltas);
            panelHeaderOptions.Controls.Add(this.btnPerfil);
            panelHeaderOptions.Controls.Add(btnHome);
            panelHeaderOptions.Dock = DockStyle.Top;
            panelHeaderOptions.Location = new Point(0, 35);
            panelHeaderOptions.Name = "panelHeaderOptions";
            panelHeaderOptions.Size = new Size(800, 26);
            panelHeaderOptions.TabIndex = 36;
            // 
            // btnPreferencias
            // 
            btnPreferencias.BackColor = Color.FromArgb(176, 0, 0);
            btnPreferencias.BackgroundColor = Color.FromArgb(176, 0, 0);
            btnPreferencias.BorderColor = Color.Black;
            btnPreferencias.BorderRadius = 0;
            btnPreferencias.BorderSize = 1;
            btnPreferencias.Dock = DockStyle.Left;
            btnPreferencias.FlatAppearance.BorderSize = 0;
            btnPreferencias.FlatStyle = FlatStyle.Flat;
            btnPreferencias.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPreferencias.ForeColor = Color.White;
            btnPreferencias.Location = new Point(497, 0);
            btnPreferencias.Name = "btnPreferencias";
            btnPreferencias.Size = new Size(177, 26);
            btnPreferencias.TabIndex = 5;
            btnPreferencias.Text = "Preferências";
            btnPreferencias.TextColor = Color.White;
            btnPreferencias.UseVisualStyleBackColor = false;
            // 
            // btnMateriaNotasFaltas
            // 
            this.btnMateriaNotasFaltas.BackColor = Color.FromArgb(176, 0, 0);
            this.btnMateriaNotasFaltas.BackgroundColor = Color.FromArgb(176, 0, 0);
            this.btnMateriaNotasFaltas.BorderColor = Color.Black;
            this.btnMateriaNotasFaltas.BorderRadius = 0;
            this.btnMateriaNotasFaltas.BorderSize = 1;
            this.btnMateriaNotasFaltas.Dock = DockStyle.Left;
            this.btnMateriaNotasFaltas.FlatAppearance.BorderSize = 0;
            this.btnMateriaNotasFaltas.FlatStyle = FlatStyle.Flat;
            this.btnMateriaNotasFaltas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnMateriaNotasFaltas.ForeColor = Color.White;
            this.btnMateriaNotasFaltas.Location = new Point(236, 0);
            this.btnMateriaNotasFaltas.Name = "btnMateriaNotasFaltas";
            this.btnMateriaNotasFaltas.Size = new Size(261, 26);
            this.btnMateriaNotasFaltas.TabIndex = 2;
            this.btnMateriaNotasFaltas.Text = "Matérias / Notas / Faltas";
            this.btnMateriaNotasFaltas.TextColor = Color.White;
            this.btnMateriaNotasFaltas.UseVisualStyleBackColor = false;
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackColor = Color.FromArgb(176, 0, 0);
            this.btnPerfil.BackgroundColor = Color.FromArgb(176, 0, 0);
            this.btnPerfil.BorderColor = Color.Black;
            this.btnPerfil.BorderRadius = 0;
            this.btnPerfil.BorderSize = 1;
            this.btnPerfil.Dock = DockStyle.Left;
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatStyle = FlatStyle.Flat;
            this.btnPerfil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnPerfil.ForeColor = Color.White;
            this.btnPerfil.Location = new Point(118, 0);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new Size(118, 26);
            this.btnPerfil.TabIndex = 1;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.TextColor = Color.White;
            this.btnPerfil.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(176, 0, 0);
            btnHome.BackgroundColor = Color.FromArgb(176, 0, 0);
            btnHome.BorderColor = Color.Black;
            btnHome.BorderRadius = 0;
            btnHome.BorderSize = 1;
            btnHome.Dock = DockStyle.Left;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(0, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(118, 26);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.TextColor = Color.White;
            btnHome.UseVisualStyleBackColor = false;
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 61);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(800, 389);
            panelContainer.TabIndex = 37;
            // 
            // btnSigaImage
            // 
            btnSigaImage.BackColor = Color.FromArgb(176, 0, 0);
            btnSigaImage.BackgroundColor = Color.FromArgb(176, 0, 0);
            btnSigaImage.BackgroundImage = Properties.Resources.logosiga_124x26;
            btnSigaImage.BorderColor = Color.Black;
            btnSigaImage.BorderRadius = 0;
            btnSigaImage.BorderSize = 1;
            btnSigaImage.Dock = DockStyle.Fill;
            btnSigaImage.FlatAppearance.BorderSize = 0;
            btnSigaImage.FlatStyle = FlatStyle.Flat;
            btnSigaImage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSigaImage.ForeColor = Color.White;
            btnSigaImage.Location = new Point(674, 0);
            btnSigaImage.Name = "btnSigaImage";
            btnSigaImage.Size = new Size(126, 26);
            btnSigaImage.TabIndex = 6;
            btnSigaImage.TextColor = Color.White;
            btnSigaImage.UseVisualStyleBackColor = false;
            btnSigaImage.Click += btnSigaImage_Click;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContainer);
            Controls.Add(panelHeaderOptions);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaPrincipal";
            Text = "TelaPrincipal";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelHeaderOptions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label label1;
        private Button btnClose;
        private PictureBox pictureBox1;
        private ContextMenuStrip contextMenuStrip1;
        private Panel panelHeaderOptions;
        private Controls.CustomButton btnHome;
        private Controls.CustomButton customButton2;
        private Controls.CustomButton customButton1;
        private Panel panelContainer;
        private PictureBox pictureBox2;
        private Controls.CustomButton btnPreferencias;
        private Controls.CustomButton btnSigaImage;
    }
}