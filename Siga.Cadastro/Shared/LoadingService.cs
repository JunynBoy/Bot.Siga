using Bot.App.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.App.Shared
{
    public class LoadingService
    {
        private LoadingControl loadingControl;

        public LoadingService()
        {
            loadingControl = new LoadingControl();
            loadingControl.Dock = DockStyle.Fill;
        }

        public void StartLoading(Panel panel)
        {
            if (!panel.Controls.Contains(loadingControl))
            {
                panel.Controls.Add(loadingControl);
                loadingControl.BringToFront();
            }
        }

        public void StopLoading(Panel panel)
        {
            if (panel.Controls.Contains(loadingControl))
            {
                panel.Controls.Remove(loadingControl);
            }
        }
    }
}
