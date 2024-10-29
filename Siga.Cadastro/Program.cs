using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Bot.App.Telas;

namespace Siga.Cadastro
{
    internal static class Program
    {
       
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            Application.Run(new TelaLogin());
        }
    }
}
