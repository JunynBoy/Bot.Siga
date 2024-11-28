using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Bot.App.Controls
{
    public class CustomButton : Button
    {
        private int borderSize = 0;
        private float borderRadiusPercentage = 10; 
        private Color borderColor = Color.Gray;

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
        public float BorderRadiusPercentage
        {
            get { return borderRadiusPercentage; }
            set
            {
                borderRadiusPercentage = Math.Max(0, Math.Min(100, value)); // Limita entre 0 e 100
                this.Invalidate();
            }
        }

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
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        [Category("Custom Code Advance")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        public CustomButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize!);
        }

        private GraphicsPath GetFigurePath(Rectangle rect, float radiusPercentage)
        {
            GraphicsPath path = new GraphicsPath();
            float radius = (Math.Min(rect.Width, rect.Height) * radiusPercentage) / 100; // Calcula o raio baseado na porcentagem
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = borderSize > 0 ? borderSize : 2;

            float adjustedRadiusPercentage = BorderRadiusPercentage;

            if (adjustedRadiusPercentage > 0)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, adjustedRadiusPercentage))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, adjustedRadiusPercentage))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    this.Region = new Region(pathSurface);
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    if (borderSize >= 1)
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;

                this.Region = new Region(rectSurface);

                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged!);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Button_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
