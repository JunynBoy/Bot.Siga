using Bot.Core.Model;
using Bot.Core.src.DAO.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Core.DAO
{
    public class EstudanteDAO : GenericDAO<Estudante>, IEstudanteDAO
    {
        public EstudanteDAO(DbContext context) : base(context) { }

        public Estudante? GetByCpf(string cpf)
        {
            return context.Set<Estudante>().Include(e => e.Preferencia).Where(a => a.Cpf == cpf).FirstOrDefault();  
        }
    }
}
