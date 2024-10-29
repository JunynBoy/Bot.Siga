using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Bot.App.Controls
{
    [DefaultEvent("_TextChanged")]
    public partial class CustomMaskedTextBox : UserControl
    {
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 1;
        private bool underlinedStyle = false;
        private Color borderFocusColor = Color.HotPink;
        private bool isFocused = false;

        public CustomMaskedTextBox()
        {
            InitializeComponent();
            maskedTextBox1.Culture = CultureInfo.InvariantCulture;
        }

        public event EventHandler _TextChanged;

        [Category("Custom Code Advance")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Custom Code Advance")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("Custom Code Advance")]
        public bool UnderlinedStyle
        {
            get { return underlinedStyle; }
            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }

        [Category("Custom Code Advance")]
        public bool PasswordChar
        {
            get { return maskedTextBox1.UseSystemPasswordChar; }
            set { maskedTextBox1.UseSystemPasswordChar = value; }
        }

        [Category("Custom Code Advance")]
        public bool Multiline
        {
            get { return maskedTextBox1.Multiline; }
            set { maskedTextBox1.Multiline = value; }
        }

        [Category("Custom Code Advance")]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                maskedTextBox1.BackColor = value;
            }
        }

        [Category("Custom Code Advance")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                maskedTextBox1.ForeColor = value;
            }
        }

        [Category("Custom Code Advance")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                maskedTextBox1.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }

        [Category("Custom Code Advance")]
        public string Texts
        {
            get { return maskedTextBox1.Text; }
            set { maskedTextBox1.Text = value; }
        }

        [Category("Custom Code Advance")]
        public Color BorderFocusColor
        {
            get { return borderFocusColor; }
            set { borderFocusColor = value; }
        }

        [Category("Custom Code Advance")]
        public string Mask
        {
            get { return maskedTextBox1.Mask; }
            set { maskedTextBox1.Mask = value; }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                if (isFocused) penBorder.Color = borderFocusColor;

                if (underlinedStyle)
                    graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                else
                    graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        private void UpdateControlHeight()
        {
            if (maskedTextBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                maskedTextBox1.Multiline = true;
                maskedTextBox1.MinimumSize = new Size(0, txtHeight);
                maskedTextBox1.Multiline = false;

                this.Height = maskedTextBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private int GetFirstEmptyPosition()
        {
            for (int i = 0; i < maskedTextBox1.Text.Length; i++)
            {
                if (maskedTextBox1.Text[i] == ' ' || maskedTextBox1.Text[i] == maskedTextBox1.PromptChar)
                {
                    return i; 
                }
            }
            return maskedTextBox1.Text.Length; 
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            int position = GetFirstEmptyPosition();
            maskedTextBox1.Select(position, 0);
            this.OnClick(e);
        }

        private void maskedTextBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void maskedTextBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void maskedTextBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
        }
    }
}
