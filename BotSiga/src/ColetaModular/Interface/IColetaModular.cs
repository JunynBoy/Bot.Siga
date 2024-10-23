using Bot.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Siga.src.ColetaModular.Interface
{
    public interface IColetaModular
    {
        public Task ColetarDados(Estudante estudante);
    }
}
