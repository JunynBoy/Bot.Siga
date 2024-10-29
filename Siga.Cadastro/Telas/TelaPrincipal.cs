using Bot.App.Controls;
using Bot.App.Shared;
using Bot.Core.Model;
using CustomMessageBox;
using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bot.App.Telas
{
    public partial class TelaPrincipal : Form
    {

        private NotifyIcon? trayIcon;
        private ContextMenuStrip? trayMenu;
        private UserControl? currentControl;
        private HomeControl homeControl;
        private LoadingService _loadingService;
        private Estudante estudante;


        public TelaPrincipal(Estudante estudante)
        {
            this._loadingService = new LoadingService();
            this.estudante = estudante;

            InitializeComponent();
            ConfigureTrayMenu();
            InitComponents();

            UpdatelblEstudateNome(estudante);

        }



        private void InitComponents()
        {
            this._loadingService.StartLoading(panelContainer);

            homeControl = new HomeControl(estudante);
            homeControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(homeControl);

            this._loadingService.StopLoadingAsync(panelContainer);
        }

        private void ConfigureTrayMenu()
        {
            trayMenu = new ContextMenuStrip();
            trayMenu.Items.Add("Voltar", Properties.Resources._return, OnRestore!);
            trayMenu.Items.Add("Sair", Properties.Resources.CloseRed, OnExit!);
            trayIcon = new NotifyIcon
            {
                Text = "Robôzinho do Siga",
                Icon = Properties.Resources.BotIco,
                ContextMenuStrip = trayMenu,
                Visible = true
            };
            trayIcon.DoubleClick += OnRestore!;
        }

        private async Task SwitchTo(UserControl newControl)
        {
            this._loadingService.StartLoading(panelContainer);

            if (currentControl != null && currentControl != homeControl)
            {
                panelContainer.Controls.Remove(currentControl);
                currentControl.Dispose();
            }

            configureBtnColors();

            currentControl = newControl;
            currentControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(currentControl);
            currentControl.BringToFront();

            this._loadingService.StopLoading(panelContainer);
        }

        private void configureBtnColors()
        {
            if (currentControl is PerfilControl)
            {
                ChangeButtonColor(btnPerfil, DefaultButtonColor());
            }

            if (currentControl is MateriasNotasFaltasControl)
            {
                ChangeButtonColor(btnMateriasNotas, DefaultButtonColor());
            }

            if (currentControl is PreferenciasControl)
            {
                ChangeButtonColor(btnPreferencias, DefaultButtonColor());
            }

            if (currentControl is HomeControl)
            {
                ChangeButtonColor(btnHome, DefaultButtonColor());
            }

        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NativeMethods.ReleaseCapture();
                NativeMethods.SendMessage(this.Handle, NativeMethods.WM_NCLBUTTONDOWN, NativeMethods.HTCAPTION, 0);
            }
        }

        
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (this.homeControl.isBotEmExecucao)
            {
                DialogResult result = CustomMessageBox.CustomMessageBox.Show("O Robô está em execução, gostaria de minimizar a aplicação para a barra de tarefas?",
                                "Atenção",
                                MessageBoxButtons.YesNo);


                if (result == DialogResult.Yes)
                {
                    trayIcon!.Visible = true;
                    this.Hide();
                }
                else
                {
                    Application.Exit(); 
                }
            }
            else
            {
                Application.Exit();
            }

        }

        private void OnRestore(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            trayIcon!.Visible = false;
        }

        private void OnExit(object sender, EventArgs e)
        {
            trayIcon!.Dispose();
            Application.Exit();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (this.WindowState == FormWindowState.Minimized)
            {
                trayIcon!.Visible = true;
                this.Hide();
            }
        }
        

        private async void btnHome_Click(object sender, EventArgs e)
        {
            await this.SwitchTo(homeControl);
            ChangeButtonColor(btnHome, btnHome.FlatAppearance.MouseOverBackColor);
        }

        private async void btnPreferencias_Click(object sender, EventArgs e)
        {
            if (currentControl is PreferenciasControl)
            {
                return;
            }

            await SwitchTo(new PreferenciasControl());
            ChangeButtonColor(btnPreferencias, btnPreferencias.FlatAppearance.MouseOverBackColor);
            ChangeButtonColor(btnHome, DefaultButtonColor());
        }

        private void btnSigaImage_Click(object sender, EventArgs e)
        {
            string url = "https://siga.cps.sp.gov.br/aluno/login.aspx?"; 

            if (Uri.IsWellFormedUriString(url, UriKind.Absolute))
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true 
                });
            }
            else
            {
                MessageBox.Show("URL inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void btnPerfil_Click(object sender, EventArgs e)
        {
            if (currentControl is PerfilControl)
            {
                return;
            }

            await this.SwitchTo(new PerfilControl());
            ChangeButtonColor(btnPerfil, btnPerfil.FlatAppearance.MouseOverBackColor);
            ChangeButtonColor(btnHome, DefaultButtonColor());
        }

        private async void btnMateriasNotas_Click(object sender, EventArgs e)
        {
            if (currentControl is MateriasNotasFaltasControl)
            {
                return;
            }

            await SwitchTo(new MateriasNotasFaltasControl());
            ChangeButtonColor(btnMateriasNotas, btnMateriasNotas.FlatAppearance.MouseOverBackColor);
            ChangeButtonColor(btnHome, DefaultButtonColor());
        }

        private void ChangeButtonColor(Button button, Color color)
        {
            button.BackColor = color;
        }

        private Color DefaultButtonColor()
        {
            return Color.FromArgb(176, 0, 0);
        }


        private void UpdatelblEstudateNome(Estudante estudante)
        {
            if (estudante.Nome != null)
            {
                this.lblNomeUsuario.Text = estudante.Nome;
            }
            else
            {
                this.lblNomeUsuario.Text = "";

            }
        }
    }
}
