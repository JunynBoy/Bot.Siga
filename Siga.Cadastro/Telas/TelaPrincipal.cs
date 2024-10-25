﻿using Bot.App.Shared;
using CustomMessageBox;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bot.App.Telas
{
    public partial class TelaPrincipal : Form
    {
        private NotifyIcon trayIcon;
        private ContextMenuStrip trayMenu;

        public TelaPrincipal()
        {
            InitializeComponent();

            // Configura o menu de contexto do ícone na bandeja
            trayMenu = new ContextMenuStrip();
            trayMenu.Items.Add("Restaurar", null, OnRestore);
            trayMenu.Items.Add("Sair", null, OnExit);

            // Configura o ícone da bandeja
            trayIcon = new NotifyIcon
            {
                Text = "Meu Aplicativo",
                Icon = SystemIcons.Application,
                ContextMenuStrip = trayMenu, 
                Visible = false
            };

            // Evento de duplo clique para restaurar a janela
            trayIcon.DoubleClick += OnRestore;
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NativeMethods.ReleaseCapture();
                NativeMethods.SendMessage(this.Handle, NativeMethods.WM_NCLBUTTONDOWN, NativeMethods.HTCAPTION, 0);
            }
        }

        private void btnSigaImage_Click(object sender, EventArgs e)
        {
            // Ação ao clicar no botão btnSigaImage
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            DialogResult result = CustomMessageBox.CustomMessageBox.Show("O Robô está em execução, gostaria de minimizar a aplicação para a barra de tarefas?",
                "Atenção",
                MessageBoxButtons.YesNo);


            if (result == DialogResult.Yes)
            {
                trayIcon.Visible = true;
                this.Hide();
            }
            else
            {
                this.Dispose();
            }
        }

        private void OnRestore(object sender, EventArgs e)
        {
            // Restaura a janela
            this.Show();
            this.WindowState = FormWindowState.Normal;
            trayIcon.Visible = false;
        }

        private void OnExit(object sender, EventArgs e)
        {
            // Sai do aplicativo
            trayIcon.Dispose();
            Application.Exit();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            // Minimiza para a bandeja se for minimizado
            if (this.WindowState == FormWindowState.Minimized)
            {
                trayIcon.Visible = true;
                this.Hide();
            }
        }
    }
}
