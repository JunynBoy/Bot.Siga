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
        private TextBox consoleOutput;
        private CancellationTokenSource? _cancellationTokenSource;
        private int loopingTime = 1;
        private int execucoesCompletas = 0;
        public bool isBotEmExecucao = false;
        public event EventHandler? IsBotEmExecucaoChanged;
        private Thread executionThread;

        private void DisplayAsciiArt()
        {
            string asciiArt = @"
  ___          _            _____  _               
 / _ \        | |          /  ___|(_)              
/ /_\ \ _   _ | |_   ___   \ `--.  _   __ _   __ _ 
|  _  || | | || __| / _ \   `--. \| | / _` | / _` |
| | | || |_| || |_ | (_) | /\__/ /| || (_| || (_| |
\_| |_/ \__,_| \__| \___/  \____/ |_| \__, | \__,_|
                                       __/ |       
                                      |___/        
 ______                 _     _ _           _       
(____  \               (_)   (_|_)         | |      
 ____)  )_____ ____     _     _ _ ____   __| | ___  
|  __  (| ___ |    \   | |   | | |  _ \ / _  |/ _ \ 
| |__)  ) ____| | | |   \ \ / /| | | | ( (_| | |_| |
|______/|_____)_|_|_|    \___/ |_|_| |_|\____|\___/   

Bem-vindo ao sistema de coleta de dados do siga automatizado
            ";
            WriteToConsoleOutput(asciiArt);
        }

        public HomeControl(Estudante estudante)
        {
            InitializeComponent();

            
            this.estudante = estudante;
            this.iniciadorColeta = new IniciadorColeta();
            this.loopingTime = 1;
            this.lblLoopingtime.Text = loopingTime + "m";

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
            this.DisplayAsciiArt();
            this.VerificarMateriaMaisRecente();
        }

        private void VerificarMateriaMaisRecente()
        {
            DateTime? materiaMaisAtualizada = null;

            if (this.estudante.Materias != null && this.estudante.Materias.Any())
            {
                foreach (Materia materia in this.estudante.Materias)
                {
                    if (materiaMaisAtualizada == null || materia.UpdatedAt > materiaMaisAtualizada)
                    {
                        materiaMaisAtualizada = materia.UpdatedAt;
                    }
                }

                if (materiaMaisAtualizada.HasValue)
                {
                    this.lblUltimaModificacaoTitle.Visible = true;
                    this.lblUltimaModificacao.Visible = true;
                    this.lblUltimaModificacao.Text = materiaMaisAtualizada.Value.ToString("dd/MM HH:mm");
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.btnStart.Enabled = false;
            this.btnLooping.Enabled = false;
            this.btnStop.Enabled = true;

            this.isBotEmExecucao = true;
            _cancellationTokenSource = new CancellationTokenSource();
            var token = _cancellationTokenSource.Token;

            this.WriteToConsoleOutput("Iniciando Looping de execução...\n");
            this.atualizarLabelStatus();

            Task.Run(async () =>
            {
                bool primeiraExec = true;

                try
                {
                    token.ThrowIfCancellationRequested();

                    if (!primeiraExec)
                    {
                        this.WriteToConsoleOutput($"Esperando {loopingTime} minuto(s) para reiniciar - {DateTime.Now:dd/MM HH:mm}\n");
                        await Task.Delay(loopingTime * 60 * 1000, token);
                    }

                    primeiraExec = false;

                    try
                    {
                        this.iniciadorColeta.IniciarColeta(estudante, getExecucoesHabilitadas());
                    }
                    catch (Exception ex)
                    {
                        this.WriteToConsoleOutput($"Esperando {loopingTime} minuto para reiniciar - {DateTime.Now:dd/MM HH:mm}\n");
                        CustomMessageBox.CustomMessageBox.Show($"Um erro inesperado aconteceu\n\nMensagem: {ex.Message}", "Erro inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (OperationCanceledException)
                {
                    CustomMessageBox.CustomMessageBox.Show("A coleta foi cancelada.", "Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    isBotEmExecucao = false;
                    this.Invoke((Action)(() =>
                    {
                        this.btnStart.Enabled = true;
                        this.btnLooping.Enabled = true;
                        this.btnStop.Enabled = false;
                        execucoesCompletas++;
                        this.lblContador.Text = execucoesCompletas.ToString();
                        this.atualizarLabelStatus();

                    }));
                }

            }, token);
        }

        private async void btnLooping_Click(object sender, EventArgs e)
        {
            this.btnLooping.Enabled = false;
            this.btnStart.Enabled = false;
            this.btnStop.Enabled = true;
            this.isBotEmExecucao = true;

            _cancellationTokenSource = new CancellationTokenSource();
            var token = _cancellationTokenSource.Token;

            this.WriteToConsoleOutput("Iniciando Looping de execução...\n");
            this.atualizarLabelStatus();

            await Task.Run(async () =>
            {
                bool primeiraExec = true;

                try
                {
                    while (!token.IsCancellationRequested)  
                    {
                        token.ThrowIfCancellationRequested();

                        if (!primeiraExec)
                        {
                            this.WriteToConsoleOutput($"Esperando {loopingTime} minuto para reiniciar - {DateTime.Now:dd/MM HH:mm}\n");
                            await Task.Delay(loopingTime * 60 * 1000, token); 
                        }

                        primeiraExec = false;

                        try
                        {
                            token.ThrowIfCancellationRequested();
                            this.iniciadorColeta.IniciarColeta(estudante, getExecucoesHabilitadas());
                        }
                        catch (Exception ex)
                        {
                            this.WriteToConsoleOutput($"Esperando {loopingTime} minuto para reiniciar - {DateTime.Now:dd/MM HH:mm}\n");
                            CustomMessageBox.CustomMessageBox.Show($"Um erro inesperado aconteceu\n\nMensagem: {ex.Message}", "Erro inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }
                }
                catch (OperationCanceledException)
                {
                    CustomMessageBox.CustomMessageBox.Show("A coleta foi cancelada.", "Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    isBotEmExecucao = false;
                    this.Invoke((Action)(() =>
                    {
                        this.btnStart.Enabled = true;
                        this.btnLooping.Enabled = true;
                        this.btnStop.Enabled = false;
                        execucoesCompletas++;
                        this.lblContador.Text = execucoesCompletas.ToString();
                        this.atualizarLabelStatus();
                    }));
                }
            }, token);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.WriteToConsoleOutput("Solicitando cancelamento...");
            _cancellationTokenSource?.Cancel(); // Solicita o cancelamento pelo token
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

        private List<EnumTipoDeExecucao> getExecucoesHabilitadas()
        {
            List<EnumTipoDeExecucao> tiposExecList = new List<EnumTipoDeExecucao>();
            if (this.tbColetarNotas.Checked)
                tiposExecList.Add(EnumTipoDeExecucao.COLETAR_NOTA);

            if (this.tbColetarFaltas.Checked)
                tiposExecList.Add(EnumTipoDeExecucao.COLETAR_FALTA);

            if (this.tbColetarMaterias.Checked)
                tiposExecList.Add(EnumTipoDeExecucao.COLETAR_MATERIA);

            return tiposExecList;
        }

        private void btnMoreTime_Click(object sender, EventArgs e)
        {
            this.loopingTime++;
            this.lblLoopingtime.Text = loopingTime + "m";
        }

        private void btnLessTime_Click(object sender, EventArgs e)
        {
            if (this.loopingTime > 1) 
            {
                this.loopingTime--;
                this.lblLoopingtime.Text = loopingTime + "m";
            }
        }

        private void atualizarLabelStatus()
        {
            if (isBotEmExecucao)
            {
                this.lblStatus.Text = "Em Execução";
                this.lblStatus.BackColor = Color.FromArgb(118, 209, 118);
                this.lblStatus.ForeColor = Color.White;
            }
            else
            {
                this.lblStatus.Text = "Parado";
                this.lblStatus.BackColor = Color.FromArgb(176, 0, 0);
                this.lblStatus.ForeColor = Color.White;
            }


            this.VerificarMateriaMaisRecente();
        }
    }
}
