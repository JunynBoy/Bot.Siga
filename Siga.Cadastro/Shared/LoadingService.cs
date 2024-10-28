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

        public async Task StartLoadingAsync(Panel panel, Func<Task> longRunningTask)
        {
            if (!panel.Controls.Contains(loadingControl))
            {
                panel.Controls.Add(loadingControl);
                loadingControl.BringToFront();
            }

            loadingControl.Start();

            try
            {
                await Task.Run(async () =>
                {
                    try
                    {
                        await longRunningTask();
                    }
                    finally
                    {
                        panel.Invoke((Action)(() => loadingControl.Stop()));
                    }
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void StopLoading(Panel panel)
        {
            if (panel.Controls.Contains(loadingControl))
            {
                panel.Invoke((Action)(() => loadingControl.Stop())); 
                panel.Controls.Remove(loadingControl); 
            }
        }
    }
}
