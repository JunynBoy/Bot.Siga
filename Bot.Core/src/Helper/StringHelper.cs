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
