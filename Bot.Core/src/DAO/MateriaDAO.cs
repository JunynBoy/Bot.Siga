using Bot.Core.Model;
using Bot.Core.src.DAO.Interface;
using Microsoft.EntityFrameworkCore;

namespace Bot.Core.DAO
{
    public class MateriaDAO : GenericDAO<Materia>, IMateriaDAO
    {

        public MateriaDAO(DbContext context) : base(context) { }


        public List<Materia> GetByEstudanteId(int estudanteId)
        {
            return context.Set<Materia>().Include(mm => mm.Notas)
                          .Where(m => m.EstudanteId == estudanteId)
                          .ToList();
        }
    }
}
