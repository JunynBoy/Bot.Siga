using Bot.Core.Model;
using Bot.Core.src.DAO.Interface;
using Microsoft.EntityFrameworkCore;

namespace Bot.Core.DAO
{
    public class MateriaDAO : GenericDAO<Materia>, IMateriaDAO
    {

        private readonly ApplicationDbContext _context;

        public MateriaDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Materia> GetByEstudanteId(int estudanteId)
        {
            return _context.Set<Materia>().Include(mm => mm.Faltas).Include(mm => mm.Notas)
                          .Where(m => m.EstudanteId == estudanteId)
                          .ToList();
        }
    }
}
