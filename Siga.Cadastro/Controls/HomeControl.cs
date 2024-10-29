using Bot.Core.Model;
using Bot.Core.Service;
using Bot.Core.src.Model.Enum;
using Bot.Siga;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bot.App.Controls
{
    public partial class HomeControl : UserControl
    {

        private Estudante estudante;
        private IniciadorColeta iniciadorColeta;
        public bool isBotEmExecucao = false;
        private TextBox consoleOutput;
        private CancellationTokenSource? _cancellationTokenSource;


        public HomeControl(Estudante estudante)
        {
            this.estudante = estudante;
            iniciadorColeta = new IniciadorColeta();
            InitializeComponent();

            this.consoleOutput = new TextBox()
            {
                Multiline = true,
                Dock = DockStyle.Fill,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical,
                BackColor = Color.FromArgb(33, 33, 33),
                ForeColor = Color.White,
                Font = new Font("Consolas", 12, FontStyle.Regular)
            };

            panelConsoleContainer.Controls.Add(consoleOutput);

            iniciadorColeta = new IniciadorColeta();
            iniciadorColeta.SetLogAction(WriteToConsoleOutput);
        }


        private void btnStartStop_Click(object sender, EventArgs e)
        {
            this.btnStartStop.Enabled = false;
            this.isBotEmExecucao = true;
            this.btnStop.Enabled = true;
            _cancellationTokenSource = new CancellationTokenSource();
            var token = _cancellationTokenSource.Token;

            this.WriteToConsoleOutput("Iniciando Robô...");

            Task.Run(() =>
            {
                try
                {
                    this.iniciadorColeta.IniciarColeta(estudante, new List<EnumTipoDeExecucao>() { EnumTipoDeExecucao.COLETAR_NOTA });
                }
                catch (OperationCanceledException)
                {
                    CustomMessageBox.CustomMessageBox.Show("A coleta foi cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    CustomMessageBox.CustomMessageBox.Show($"Um erro inesperado aconteceu\n\nMensagem: {ex.Message}", "Erro inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    isBotEmExecucao = false;
                    this.Invoke((Action)(() =>
                    {
                        this.btnStartStop.Enabled = true; 
                    }));
                }
            }, token);
        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            this.WriteToConsoleOutput("Solicitando cancelamento...");
            _cancellationTokenSource?.Cancel();
            this.btnStop.Enabled = false;
        }

        private void WriteToConsoleOutput(string message)
        {
            if (consoleOutput.InvokeRequired)
            {
                consoleOutput.Invoke(new Action(() => consoleOutput.AppendText(message + Environment.NewLine)));
            }
            else
            {
                consoleOutput.AppendText(message + Environment.NewLine);
            }
        }


        private void customToggleButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

      
    }
}
