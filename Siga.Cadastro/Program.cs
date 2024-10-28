using Bot.App.Telas;

namespace Siga.Cadastro
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new TelaLogin());
        }
    }
}