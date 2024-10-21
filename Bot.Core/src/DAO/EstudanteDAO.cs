using Bot.Core.Model;
using Bot.Core.src.DAO.Interface;
using Microsoft.EntityFrameworkCore;

namespace Bot.Core.DAO
{
    public class EstudanteDAO : GenericDAO<Estudante>, IEstudanteDAO
    {
        private readonly ApplicationDbContext _context;

        public EstudanteDAO(ApplicationDbContext context)
        {
            _context = context;
        }
        public Estudante? GetByCpf(string cpf)
        {
            return _context.Set<Estudante>()
                .Include(e => e.Preferencia)
                .Include(e => e.Materias)
                .Where(a => a.Cpf == cpf).FirstOrDefault();
        }
    }
}
