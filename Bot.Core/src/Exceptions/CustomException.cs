using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Core.src.Exceptions
{
    public class CustomException : Exception
    {
        public CustomException() : base("Uma exceção ocorreu.")
        {
        }

        public CustomException(string mensagem) : base(mensagem)
        {
        }

        public CustomException(string mensagem, Exception excecaoInterna) : base(mensagem, excecaoInterna)
        {
        }
    }
}
