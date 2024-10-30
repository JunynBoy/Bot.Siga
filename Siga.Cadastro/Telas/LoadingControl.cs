using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bot.App.Controls
{
    public partial class LoadingControl : UserControl
    {
        public LoadingControl()
        {
            InitializeComponent();
            this.Resize += LoadingControl_Resize;
            CenterPictureBox();
        }

        public void Start()
        {
            if (InvokeRequired)
            {
                BeginInvoke((Action)Start);
                return;
            }

            this.Visible = true; 
        }

        public void Stop()
        {
            if (InvokeRequired)
            {
                BeginInvoke((Action)Stop);
                return;
            }

            this.Visible = false;
        }

        private void LoadingControl_Resize(object sender, EventArgs e)
        {
            CenterPictureBox();
        }

        private void CenterPictureBox()
        {
            pictureBox1.Left = (this.Width - pictureBox1.Width) / 2;
            pictureBox1.Top = (this.Height - pictureBox1.Height) / 2;
        }
    }
}