using Bot.Core.Model;
using Bot.Core.src.DAO.Interface;
using Microsoft.EntityFrameworkCore;

namespace Bot.Core.DAO
{
    public class EstudanteDAO : GenericDAO<Estudante>, IEstudanteDAO
    {
        public EstudanteDAO(DbContext context) : base(context) { }

        public Estudante? GetByCpf(string cpf)
        {
            return context.Set<Estudante>()
                .Include(e => e.Preferencia)
                .Include(e => e.Materias)
                .Where(a => a.Cpf == cpf).FirstOrDefault();
        }
    }
}
