using Bot.App.Controls;
using Bot.App.Shared;
using Bot.Core.Model;
using CustomMessageBox;
using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Drawing;
using System.Linq.Expressions;
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
            this.StartPosition = FormStartPosition.CenterScreen;
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
            this.configureBtnColors();

            this._loadingService.StopLoadingAsync(panelContainer);
        }

        private void ConfigureTrayMenu()
        {
            trayMenu = new ContextMenuStrip();
            trayMenu.Items.Add("Voltar", Properties.Resources._return, OnRestore!);
            trayMenu.Items.Add("Sair", Properties.Resources.CloseRed, OnExit!);
            trayIcon = new NotifyIcon
            {
                Text = "AutoSiga",
                Icon = Properties.Resources.BotIco,
                ContextMenuStrip = trayMenu,
                Visible = true
            };
            trayIcon.DoubleClick += OnRestore!;
        }

        private async void SwitchTo(EnumTelaPrincipalControls enumControls)
        {
            this._loadingService.StartLoading(panelContainer);

            await Task.Delay(100);

            if (currentControl != null && currentControl != homeControl)
            {
                panelContainer.Controls.Remove(currentControl);
                currentControl.Dispose();
            }

            configureBtnColors();

            currentControl = GetNewControl(enumControls);
            currentControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(currentControl);
            currentControl.BringToFront();

            this._loadingService.StopLoading(panelContainer);
        }

        private UserControl GetNewControl(EnumTelaPrincipalControls enumControls)
        {
            switch (enumControls)
            {
                case EnumTelaPrincipalControls.PERFIL:
                    return new PerfilControl(estudante.Id);
                case EnumTelaPrincipalControls.MATERIASNOTASFALTAS:
                    return new MateriasNotasFaltasControl(estudante.Id);
                case EnumTelaPrincipalControls.PREFERENCIAS:
                    return new PreferenciasControl(estudante.Id);
                case EnumTelaPrincipalControls.HOME:
                    return this.homeControl;
                default:
                    return this.homeControl;
            }
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
        

        private void btnHome_Click(object sender, EventArgs e)
        {
            SwitchTo(EnumTelaPrincipalControls.HOME);
            ChangeButtonColor(btnHome, btnHome.FlatAppearance.MouseOverBackColor);
        }

        private void btnPreferencias_Click(object sender, EventArgs e)
        {
            if (currentControl is PreferenciasControl)
            {
                return;
            }

            SwitchTo(EnumTelaPrincipalControls.PREFERENCIAS);
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


        private void btnPerfil_Click(object sender, EventArgs e)
        {
            if (currentControl is PerfilControl)
            {
                return;
            }

            SwitchTo(EnumTelaPrincipalControls.PERFIL);
            ChangeButtonColor(btnPerfil, btnPerfil.FlatAppearance.MouseOverBackColor);
            ChangeButtonColor(btnHome, DefaultButtonColor());
        }

        private void btnMateriasNotas_Click(object sender, EventArgs e)
        {
            if (currentControl is MateriasNotasFaltasControl)
            {
                return;
            }

            SwitchTo(EnumTelaPrincipalControls.MATERIASNOTASFALTAS);
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
