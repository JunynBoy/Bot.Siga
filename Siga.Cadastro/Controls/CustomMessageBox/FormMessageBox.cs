﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomMessageBox.Private
{
public partial class FormMessageBox : Form
{
    private Color primaryColor = Color.FromArgb(66, 84, 96);
    private int borderSize = 2;

    public Color PrimaryColor
    {
        get { return primaryColor; }
        set
        {
            primaryColor = value;
            this.BackColor = primaryColor;
            this.panelTitleBar.BackColor = PrimaryColor;
        }
    }

    public FormMessageBox(string text)
    {
        InitializeComponent();
        InitializeItems();
        this.PrimaryColor = primaryColor;
        this.labelMessage.Text = text;
        this.labelCaption.Text = "";
        SetFormSize();
        SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1);
    }
    public FormMessageBox(string text, string caption)
    {
        InitializeComponent();
        InitializeItems();
        this.PrimaryColor = primaryColor;
        this.labelMessage.Text = text;
        this.labelCaption.Text = caption;
        SetFormSize();
        SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1);
    }
    public FormMessageBox(string text, string caption, MessageBoxButtons buttons)
    {
        InitializeComponent();
        InitializeItems();
        this.PrimaryColor = primaryColor;
        this.labelMessage.Text = text;
        this.labelCaption.Text = caption;
        SetFormSize();
        SetButtons(buttons, MessageBoxDefaultButton.Button1);
    }
    public FormMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
    {
        InitializeComponent();
        InitializeItems();
        this.PrimaryColor = primaryColor;
        this.labelMessage.Text = text;
        this.labelCaption.Text = caption;
        SetFormSize();
        SetButtons(buttons, MessageBoxDefaultButton.Button1);
        SetIcon(icon);
    }
    public FormMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
    {
        InitializeComponent();
        InitializeItems();
        this.PrimaryColor = primaryColor;
        this.labelMessage.Text = text;
        this.labelCaption.Text = caption;
        SetFormSize();
        SetButtons(buttons, defaultButton);
        SetIcon(icon);
    }

    private void InitializeItems()
    {
        this.FormBorderStyle = FormBorderStyle.None;
        this.Padding = new Padding(borderSize);
        this.labelMessage.MaximumSize = new Size(550, 0);
        this.btnClose.DialogResult = DialogResult.Cancel;
        this.button1.DialogResult = DialogResult.OK;
        this.button1.Visible = false;
        this.button2.Visible = false;
        this.button3.Visible = false;
    }
    private void SetFormSize()
    {
        int widht = this.labelMessage.Width + this.pictureBoxIcon.Width + this.panelBody.Padding.Left;
        int height = this.panelTitleBar.Height + this.labelMessage.Height + this.panelButtons.Height + this.panelBody.Padding.Top;
        this.Size = new Size(widht, height);
    }
    private void SetButtons(MessageBoxButtons buttons, MessageBoxDefaultButton defaultButton)
    {
        int xCenter = (this.panelButtons.Width - button1.Width) / 2;
        int yCenter = (this.panelButtons.Height - button1.Height) / 2;

        switch (buttons)
        {
            case MessageBoxButtons.OK:
                button1.Visible = true;
                button1.Location = new Point(xCenter, yCenter);
                button1.Text = "Ok";
                button1.DialogResult = DialogResult.OK;

                SetDefaultButton(defaultButton);
                break;
            case MessageBoxButtons.OKCancel:
                button1.Visible = true;
                button1.Location = new Point(xCenter - (button1.Width / 2) - 5, yCenter);
                button1.Text = "Ok";
                button1.DialogResult = DialogResult.OK;

                button2.Visible = true;
                button2.Location = new Point(xCenter + (button2.Width / 2) + 5, yCenter);
                button2.Text = "Cancel";
                button2.DialogResult = DialogResult.Cancel;
                button2.BackColor = Color.DimGray;

                if (defaultButton != MessageBoxDefaultButton.Button3)
                    SetDefaultButton(defaultButton);
                else SetDefaultButton(MessageBoxDefaultButton.Button1);
                break;

            case MessageBoxButtons.RetryCancel:

                button1.Visible = true;
                button1.Location = new Point(xCenter - (button1.Width / 2) - 5, yCenter);
                button1.Text = "Reiniciar";
                button1.DialogResult = DialogResult.Retry;
                button2.Visible = true;
                button2.Location = new Point(xCenter + (button2.Width / 2) + 5, yCenter);
                button2.Text = "Cancelar";
                button2.DialogResult = DialogResult.Cancel;
                button2.BackColor = Color.DimGray;

                if (defaultButton != MessageBoxDefaultButton.Button3)
                    SetDefaultButton(defaultButton);
                else SetDefaultButton(MessageBoxDefaultButton.Button1);
                break;

            case MessageBoxButtons.YesNo:
                button1.Visible = true;
                button1.Location = new Point(xCenter - (button1.Width / 2) - 5, yCenter);
                button1.Text = "Sim";
                button1.DialogResult = DialogResult.Yes;
                button2.Visible = true;
                button2.Location = new Point(xCenter + (button2.Width / 2) + 5, yCenter);
                button2.Text = "Não";
                button2.DialogResult = DialogResult.No;
                button2.BackColor = Color.IndianRed;

                if (defaultButton != MessageBoxDefaultButton.Button3)
                    SetDefaultButton(defaultButton);
                else SetDefaultButton(MessageBoxDefaultButton.Button1);
                break;
            case MessageBoxButtons.YesNoCancel:
                button1.Visible = true;
                button1.Location = new Point(xCenter - button1.Width - 5, yCenter);
                button1.Text = "Sim";
                button1.DialogResult = DialogResult.Yes;

                button2.Visible = true;
                button2.Location = new Point(xCenter, yCenter);
                button2.Text = "Não";
                button2.DialogResult = DialogResult.No;
                button2.BackColor = Color.IndianRed;

                button3.Visible = true;
                button3.Location = new Point(xCenter + button2.Width + 5, yCenter);
                button3.Text = "Cancelar";
                button3.DialogResult = DialogResult.Cancel;
                button3.BackColor = Color.DimGray;

                SetDefaultButton(defaultButton);
                break;

            case MessageBoxButtons.AbortRetryIgnore:
                button1.Visible = true;
                button1.Location = new Point(xCenter - button1.Width - 5, yCenter);
                button1.Text = "Cancelar";
                button1.DialogResult = DialogResult.Abort;
                button1.BackColor = Color.Goldenrod;

                button2.Visible = true;
                button2.Location = new Point(xCenter, yCenter);
                button2.Text = "Tentar Novamente";
                button2.DialogResult = DialogResult.Retry;               

                button3.Visible = true;
                button3.Location = new Point(xCenter + button2.Width + 5, yCenter);
                button3.Text = "Ignorar";
                button3.DialogResult = DialogResult.Ignore;
                button3.BackColor = Color.IndianRed;

                SetDefaultButton(defaultButton);
                break;
        }
    }
    private void SetDefaultButton(MessageBoxDefaultButton defaultButton)
    {
        switch (defaultButton)
        {
            case MessageBoxDefaultButton.Button1:
                button1.Select();
                button1.ForeColor = Color.White;
                button1.Font = new Font(button1.Font, FontStyle.Bold);
                break;
            case MessageBoxDefaultButton.Button2:
                button2.Select();
                button2.ForeColor = Color.White;
                button2.Font = new Font(button2.Font, FontStyle.Bold);
                break;
            case MessageBoxDefaultButton.Button3:
                button3.Select();
                button3.ForeColor = Color.White;
                button3.Font = new Font(button3.Font, FontStyle.Bold);
                break;
        }
    }
    private void SetIcon(MessageBoxIcon icon)
    {
        switch (icon)
        {
            case MessageBoxIcon.Error: 
                this.pictureBoxIcon.Image = Bot.App.Properties.Resources.error;
                PrimaryColor = Color.FromArgb(224, 79, 95);
                this.btnClose.FlatAppearance.MouseOverBackColor = Color.Crimson;
                break;
            case MessageBoxIcon.Information:
                this.pictureBoxIcon.Image = Bot.App.Properties.Resources.information;
                PrimaryColor = Color.FromArgb(38, 191, 166);
                break;
            case MessageBoxIcon.Question:
                this.pictureBoxIcon.Image = Bot.App.Properties.Resources.question;
                PrimaryColor = Color.FromArgb(10, 119, 232);
                break;
            case MessageBoxIcon.Exclamation:
                this.pictureBoxIcon.Image = Bot.App.Properties.Resources.exclamation;
                PrimaryColor = Color.FromArgb(255, 140, 0);
                break;
            case MessageBoxIcon.None:
                this.pictureBoxIcon.Image = Bot.App.Properties.Resources.chat;
                PrimaryColor = Color.FromArgb(66, 84, 96);
                break;
        }
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    #region -> Drag Form
    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();
    private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
    {
        ReleaseCapture();
        SendMessage(this.Handle, 0x112, 0xf012, 0);
    }
    #endregion
}
}
