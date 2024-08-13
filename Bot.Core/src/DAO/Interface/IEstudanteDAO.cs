using Bot.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Core.src.DAO.Interface
{
    public interface IEstudanteDAO : IGenericDAO<Estudante>
    {

        public Estudante? GetByCpf(string cpf);


    }
}
