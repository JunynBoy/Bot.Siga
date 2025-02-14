﻿namespace Bot.App.Telas
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
            pbxLogo = new PictureBox();
            lblNomeUsuario = new Label();
            btnClose = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panelHeaderOptions = new Panel();
            btnPreferencias = new Controls.CustomButton();
            btnMateriasNotas = new Controls.CustomButton();
            btnSigaImage = new Controls.CustomButton();
            btnPerfil = new Controls.CustomButton();
            btnHome = new Controls.CustomButton();
            panelContainer = new Panel();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
            panelHeaderOptions.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(66, 84, 96);
            panelHeader.Controls.Add(pbxLogo);
            panelHeader.Controls.Add(lblNomeUsuario);
            panelHeader.Controls.Add(btnClose);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 4, 3, 4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(914, 47);
            panelHeader.TabIndex = 35;
            panelHeader.MouseDown += panelHeader_MouseDown;
            // 
            // pbxLogo
            // 
            pbxLogo.Dock = DockStyle.Left;
            pbxLogo.ErrorImage = Properties.Resources.BotWhite30;
            pbxLogo.ImageLocation = "Center";
            pbxLogo.InitialImage = Properties.Resources.BotWhite25;
            pbxLogo.Location = new Point(0, 0);
            pbxLogo.Margin = new Padding(3, 4, 3, 4);
            pbxLogo.Name = "pbxLogo";
            pbxLogo.Size = new Size(47, 47);
            pbxLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            pbxLogo.TabIndex = 36;
            pbxLogo.TabStop = false;
            // 
            // lblNomeUsuario
            // 
            lblNomeUsuario.AutoSize = true;
            lblNomeUsuario.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomeUsuario.ForeColor = Color.White;
            lblNomeUsuario.Location = new Point(53, 13);
            lblNomeUsuario.Name = "lblNomeUsuario";
            lblNomeUsuario.Size = new Size(118, 23);
            lblNomeUsuario.TabIndex = 35;
            lblNomeUsuario.Text = "Nome usuário";
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
            btnClose.Location = new Point(874, 0);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 47);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // panelHeaderOptions
            // 
            panelHeaderOptions.BackColor = Color.FromArgb(176, 0, 0);
            panelHeaderOptions.Controls.Add(btnPreferencias);
            panelHeaderOptions.Controls.Add(btnMateriasNotas);
            panelHeaderOptions.Controls.Add(btnSigaImage);
            panelHeaderOptions.Controls.Add(btnPerfil);
            panelHeaderOptions.Controls.Add(btnHome);
            panelHeaderOptions.Dock = DockStyle.Top;
            panelHeaderOptions.Location = new Point(0, 47);
            panelHeaderOptions.Margin = new Padding(3, 4, 3, 4);
            panelHeaderOptions.Name = "panelHeaderOptions";
            panelHeaderOptions.Size = new Size(914, 35);
            panelHeaderOptions.TabIndex = 36;
            // 
            // btnPreferencias
            // 
            btnPreferencias.BackColor = Color.FromArgb(176, 0, 0);
            btnPreferencias.BackgroundColor = Color.FromArgb(176, 0, 0);
            btnPreferencias.BorderColor = Color.Black;
            btnPreferencias.BorderRadiusPercentage = 0F;
            btnPreferencias.BorderSize = 0;
            btnPreferencias.Dock = DockStyle.Left;
            btnPreferencias.FlatAppearance.BorderSize = 0;
            btnPreferencias.FlatAppearance.CheckedBackColor = Color.FromArgb(252, 0, 0);
            btnPreferencias.FlatAppearance.MouseDownBackColor = Color.FromArgb(252, 0, 0);
            btnPreferencias.FlatAppearance.MouseOverBackColor = Color.FromArgb(82, 22, 18);
            btnPreferencias.FlatStyle = FlatStyle.Flat;
            btnPreferencias.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPreferencias.ForeColor = Color.White;
            btnPreferencias.Location = new Point(514, 0);
            btnPreferencias.Margin = new Padding(3, 4, 3, 4);
            btnPreferencias.Name = "btnPreferencias";
            btnPreferencias.Size = new Size(193, 35);
            btnPreferencias.TabIndex = 8;
            btnPreferencias.Text = "Preferências";
            btnPreferencias.TextColor = Color.White;
            btnPreferencias.UseVisualStyleBackColor = false;
            btnPreferencias.Click += btnPreferencias_Click;
            // 
            // btnMateriasNotas
            // 
            btnMateriasNotas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnMateriasNotas.BackColor = Color.FromArgb(176, 0, 0);
            btnMateriasNotas.BackgroundColor = Color.FromArgb(176, 0, 0);
            btnMateriasNotas.BorderColor = Color.Black;
            btnMateriasNotas.BorderRadiusPercentage = 0F;
            btnMateriasNotas.BorderSize = 0;
            btnMateriasNotas.Dock = DockStyle.Left;
            btnMateriasNotas.FlatAppearance.BorderSize = 0;
            btnMateriasNotas.FlatAppearance.CheckedBackColor = Color.FromArgb(252, 0, 0);
            btnMateriasNotas.FlatAppearance.MouseDownBackColor = Color.FromArgb(252, 0, 0);
            btnMateriasNotas.FlatAppearance.MouseOverBackColor = Color.FromArgb(82, 22, 18);
            btnMateriasNotas.FlatStyle = FlatStyle.Flat;
            btnMateriasNotas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMateriasNotas.ForeColor = Color.White;
            btnMateriasNotas.Location = new Point(245, 0);
            btnMateriasNotas.Margin = new Padding(3, 4, 3, 4);
            btnMateriasNotas.Name = "btnMateriasNotas";
            btnMateriasNotas.Size = new Size(269, 35);
            btnMateriasNotas.TabIndex = 7;
            btnMateriasNotas.Text = "Materias / Notas / Faltas";
            btnMateriasNotas.TextColor = Color.White;
            btnMateriasNotas.UseVisualStyleBackColor = false;
            btnMateriasNotas.Click += btnMateriasNotas_Click;
            // 
            // btnSigaImage
            // 
            btnSigaImage.BackColor = Color.FromArgb(176, 0, 0);
            btnSigaImage.BackgroundColor = Color.FromArgb(176, 0, 0);
            btnSigaImage.BackgroundImage = Properties.Resources.logosiga_124x26;
            btnSigaImage.BorderColor = Color.Black;
            btnSigaImage.BorderRadiusPercentage = 0F;
            btnSigaImage.BorderSize = 0;
            btnSigaImage.Dock = DockStyle.Right;
            btnSigaImage.FlatAppearance.BorderSize = 0;
            btnSigaImage.FlatStyle = FlatStyle.Flat;
            btnSigaImage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSigaImage.ForeColor = Color.White;
            btnSigaImage.Location = new Point(784, 0);
            btnSigaImage.Margin = new Padding(3, 4, 3, 4);
            btnSigaImage.Name = "btnSigaImage";
            btnSigaImage.Size = new Size(130, 35);
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
            btnPerfil.BorderRadiusPercentage = 0F;
            btnPerfil.BorderSize = 0;
            btnPerfil.Dock = DockStyle.Left;
            btnPerfil.FlatAppearance.BorderSize = 0;
            btnPerfil.FlatAppearance.CheckedBackColor = Color.FromArgb(252, 0, 0);
            btnPerfil.FlatAppearance.MouseDownBackColor = Color.FromArgb(252, 0, 0);
            btnPerfil.FlatAppearance.MouseOverBackColor = Color.FromArgb(82, 22, 18);
            btnPerfil.FlatStyle = FlatStyle.Flat;
            btnPerfil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPerfil.ForeColor = Color.White;
            btnPerfil.Location = new Point(119, 0);
            btnPerfil.Margin = new Padding(3, 4, 3, 4);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(126, 35);
            btnPerfil.TabIndex = 5;
            btnPerfil.Text = "Perfil";
            btnPerfil.TextColor = Color.White;
            btnPerfil.UseVisualStyleBackColor = false;
            btnPerfil.Click += btnPerfil_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(176, 0, 0);
            btnHome.BackgroundColor = Color.FromArgb(176, 0, 0);
            btnHome.BorderColor = Color.Black;
            btnHome.BorderRadiusPercentage = 0F;
            btnHome.BorderSize = 0;
            btnHome.Dock = DockStyle.Left;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.CheckedBackColor = Color.FromArgb(252, 0, 0);
            btnHome.FlatAppearance.MouseDownBackColor = Color.FromArgb(252, 0, 0);
            btnHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(82, 22, 18);
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(0, 0);
            btnHome.Margin = new Padding(3, 4, 3, 4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(119, 35);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.TextColor = Color.White;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 82);
            panelContainer.Margin = new Padding(3, 4, 3, 4);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(914, 518);
            panelContainer.TabIndex = 37;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panelContainer);
            Controls.Add(panelHeaderOptions);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaPrincipal";
            Text = " ";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            panelHeaderOptions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblNomeUsuario;
        private Button btnClose;
        private PictureBox pbxLogo;
        private ContextMenuStrip contextMenuStrip1;
        private Panel panelHeaderOptions;
        private Controls.CustomButton btnHome;
        private Controls.CustomButton customButton2;
        private Controls.CustomButton customButton1;
        private Panel panelContainer;
        private PictureBox pictureBox2;
        private Controls.CustomButton btnPerfil;
        private Controls.CustomButton btnSigaImage;
        private Controls.CustomButton btnPreferencias;
        private Controls.CustomButton btnMateriasNotas;
    }
}