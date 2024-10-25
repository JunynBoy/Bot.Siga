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
            btnSigaImage = new Controls.CustomButton();
            btnPerfil = new Controls.CustomButton();
            btnHome = new Controls.CustomButton();
            panelContainer = new Panel();
            btnMateriasNotas = new Controls.CustomButton();
            customButton4 = new Controls.CustomButton();
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
            panelHeaderOptions.Controls.Add(customButton4);
            panelHeaderOptions.Controls.Add(btnMateriasNotas);
            panelHeaderOptions.Controls.Add(btnSigaImage);
            panelHeaderOptions.Controls.Add(btnPerfil);
            panelHeaderOptions.Controls.Add(btnHome);
            panelHeaderOptions.Dock = DockStyle.Top;
            panelHeaderOptions.Location = new Point(0, 35);
            panelHeaderOptions.Name = "panelHeaderOptions";
            panelHeaderOptions.Size = new Size(800, 26);
            panelHeaderOptions.TabIndex = 36;
            // 
            // btnSigaImage
            // 
            btnSigaImage.BackColor = Color.FromArgb(176, 0, 0);
            btnSigaImage.BackgroundColor = Color.FromArgb(176, 0, 0);
            btnSigaImage.BackgroundImage = Properties.Resources.logosiga_124x26;
            btnSigaImage.BorderColor = Color.Black;
            btnSigaImage.BorderRadius = 0;
            btnSigaImage.BorderSize = 1;
            btnSigaImage.Dock = DockStyle.Right;
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
            // btnPerfil
            // 
            btnPerfil.BackColor = Color.FromArgb(176, 0, 0);
            btnPerfil.BackgroundColor = Color.FromArgb(176, 0, 0);
            btnPerfil.BorderColor = Color.Black;
            btnPerfil.BorderRadius = 0;
            btnPerfil.BorderSize = 1;
            btnPerfil.Dock = DockStyle.Left;
            btnPerfil.FlatAppearance.BorderSize = 0;
            btnPerfil.FlatStyle = FlatStyle.Flat;
            btnPerfil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPerfil.ForeColor = Color.White;
            btnPerfil.Location = new Point(118, 0);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(124, 26);
            btnPerfil.TabIndex = 5;
            btnPerfil.Text = "Perfil";
            btnPerfil.TextColor = Color.White;
            btnPerfil.UseVisualStyleBackColor = false;
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
            // btnMateriasNotas
            // 
            btnMateriasNotas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnMateriasNotas.BackColor = Color.FromArgb(176, 0, 0);
            btnMateriasNotas.BackgroundColor = Color.FromArgb(176, 0, 0);
            btnMateriasNotas.BorderColor = Color.Black;
            btnMateriasNotas.BorderRadius = 0;
            btnMateriasNotas.BorderSize = 1;
            btnMateriasNotas.Dock = DockStyle.Left;
            btnMateriasNotas.FlatAppearance.BorderSize = 0;
            btnMateriasNotas.FlatStyle = FlatStyle.Flat;
            btnMateriasNotas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMateriasNotas.ForeColor = Color.White;
            btnMateriasNotas.Location = new Point(242, 0);
            btnMateriasNotas.Name = "btnMateriasNotas";
            btnMateriasNotas.Size = new Size(249, 26);
            btnMateriasNotas.TabIndex = 7;
            btnMateriasNotas.Text = "Materias / Notas / Faltas";
            btnMateriasNotas.TextColor = Color.White;
            btnMateriasNotas.UseVisualStyleBackColor = false;
            // 
            // customButton4
            // 
            customButton4.BackColor = Color.FromArgb(176, 0, 0);
            customButton4.BackgroundColor = Color.FromArgb(176, 0, 0);
            customButton4.BorderColor = Color.Black;
            customButton4.BorderRadius = 0;
            customButton4.BorderSize = 1;
            customButton4.Dock = DockStyle.Fill;
            customButton4.FlatAppearance.BorderSize = 0;
            customButton4.FlatStyle = FlatStyle.Flat;
            customButton4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            customButton4.ForeColor = Color.White;
            customButton4.Location = new Point(491, 0);
            customButton4.Name = "customButton4";
            customButton4.Size = new Size(183, 26);
            customButton4.TabIndex = 8;
            customButton4.Text = "Preferências";
            customButton4.TextColor = Color.White;
            customButton4.UseVisualStyleBackColor = false;
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
        private Controls.CustomButton btnPerfil;
        private Controls.CustomButton btnSigaImage;
        private Controls.CustomButton customButton4;
        private Controls.CustomButton btnMateriasNotas;
    }
}