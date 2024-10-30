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

        public async Task StartLoadingAsync(Panel panelToDock, Func<Task> longRunningTask)
        {
            if (!panelToDock.Controls.Contains(loadingControl))
            {
                panelToDock.Controls.Add(loadingControl);
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
                        panelToDock.Invoke((Action)(() => loadingControl.Stop()));
                    }
                });
            }
            catch (Exception ex)
            {
                throw ex; //Cross-thread operation not valid: Control 'panelContainer' accessed from a thread other than the thread it was created on
            }
        }
        public async Task StopLoadingAsync(Panel panelToUndock)
        {
            if (panelToUndock.Controls.Contains(loadingControl))
            {
                while (!loadingControl.IsHandleCreated)
                {
                    await Task.Delay(50);
                }

                panelToUndock.Invoke((Action)(() => loadingControl.Stop()));
                panelToUndock.Controls.Remove(loadingControl);
            }
        }

        public void StartLoading(Panel panelToDock)
        {
            if (!panelToDock.Controls.Contains(loadingControl))
            {
                panelToDock.Controls.Add(loadingControl);
                loadingControl.BringToFront();
            }

            loadingControl.Start();
        }

        public void StopLoading(Panel panelToUndock)
        {
            if (panelToUndock.Controls.Contains(loadingControl))
            {
                // Verifica se o controle possui identificador de janela criado
                if (loadingControl.IsHandleCreated)
                {
                    panelToUndock.Invoke((Action)(() => loadingControl.Stop()));
                }
                else
                {
                    // Cria o controle para garantir que o identificador seja criado
                    loadingControl.CreateControl();
                    panelToUndock.Invoke((Action)(() => loadingControl.Stop()));
                }

                panelToUndock.Controls.Remove(loadingControl);
            }
        }
    }
}
