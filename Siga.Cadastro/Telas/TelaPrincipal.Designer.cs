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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            panelHeader = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnClose = new Button();
            customButton1 = new Controls.CustomButton();
            customButton2 = new Controls.CustomButton();
            customButton3 = new Controls.CustomButton();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // customButton1
            // 
            customButton1.BackColor = Color.FromArgb(66, 84, 96);
            customButton1.BackgroundColor = Color.FromArgb(66, 84, 96);
            customButton1.BorderColor = Color.Silver;
            customButton1.BorderRadius = 5;
            customButton1.BorderSize = 1;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            customButton1.ForeColor = Color.White;
            customButton1.Location = new Point(121, 177);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(126, 32);
            customButton1.TabIndex = 36;
            customButton1.Text = "Testar Message Box ";
            customButton1.TextColor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // customButton2
            // 
            customButton2.BackColor = Color.FromArgb(66, 84, 96);
            customButton2.BackgroundColor = Color.FromArgb(66, 84, 96);
            customButton2.BorderColor = Color.Silver;
            customButton2.BorderRadius = 5;
            customButton2.BorderSize = 1;
            customButton2.FlatAppearance.BorderSize = 0;
            customButton2.FlatStyle = FlatStyle.Flat;
            customButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            customButton2.ForeColor = Color.White;
            customButton2.Location = new Point(310, 177);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(126, 32);
            customButton2.TabIndex = 37;
            customButton2.Text = "Testar Message Box ";
            customButton2.TextColor = Color.White;
            customButton2.UseVisualStyleBackColor = false;
            // 
            // customButton3
            // 
            customButton3.BackColor = Color.FromArgb(66, 84, 96);
            customButton3.BackgroundColor = Color.FromArgb(66, 84, 96);
            customButton3.BorderColor = Color.Silver;
            customButton3.BorderRadius = 5;
            customButton3.BorderSize = 1;
            customButton3.FlatAppearance.BorderSize = 0;
            customButton3.FlatStyle = FlatStyle.Flat;
            customButton3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            customButton3.ForeColor = Color.White;
            customButton3.Location = new Point(507, 177);
            customButton3.Name = "customButton3";
            customButton3.Size = new Size(126, 32);
            customButton3.TabIndex = 38;
            customButton3.Text = "Testar Message Box ";
            customButton3.TextColor = Color.White;
            customButton3.UseVisualStyleBackColor = false;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(customButton3);
            Controls.Add(customButton2);
            Controls.Add(customButton1);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaPrincipal";
            Text = "TelaPrincipal";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label label1;
        private Button btnClose;
        private PictureBox pictureBox1;
        private Controls.CustomButton customButton1;
        private Controls.CustomButton customButton2;
        private Controls.CustomButton customButton3;
    }
}