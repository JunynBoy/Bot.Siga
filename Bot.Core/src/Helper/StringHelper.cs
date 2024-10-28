using System.Text.RegularExpressions;

namespace Bot.Core.src.Helper
{
    public static class StringHelper
    {
        public static void ConsoleColoredLog(ConsoleColor color, params string[] args)
        {

            Console.ForegroundColor = color;

            foreach (string text in args)
            {
                Console.WriteLine(text);
            }

            Console.ResetColor();

        }

        public static void ConsoleColoredLogFixed(ConsoleColor cor, params string[] mensagens)
        {
            Console.ForegroundColor = cor;
            string mensagemCompleta = string.Join("\n", mensagens);
            if (Console.CursorTop > 0)
            {
                Console.SetCursorPosition(0, Console.CursorTop - 1);
            }
            Console.Write(mensagemCompleta);
            Console.ResetColor();
        }

        public static void ClearCurrentConsoleLine()
        {
            if (Console.CursorTop > 0)
            {
                int currentLineCursor = Console.CursorTop - 1;
                Console.SetCursorPosition(0, currentLineCursor);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, currentLineCursor);
            }
        }

        public static bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        public static string cpfCast(string cpf)
        {
            cpf = cpf.Replace(",", "").Replace("-", "");
            return cpf;
        }
    }
}
