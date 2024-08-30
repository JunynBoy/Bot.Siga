using System.Text.RegularExpressions;

namespace Bot.Core.Helper
{
    public class Validacoes
    {

        public bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        public string cpfCast(string cpf)
        {
            cpf = cpf.Replace(",", "").Replace("-", "");
            return cpf;
        }

    }
}
