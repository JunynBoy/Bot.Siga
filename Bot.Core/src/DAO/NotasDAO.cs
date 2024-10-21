using Bot.Core.DAO;
using Bot.Core.Model;
using Bot.Core.src.DAO.Interface;
using Microsoft.EntityFrameworkCore;

namespace Bot.Core.src.DAO
{
    public class NotasDAO : GenericDAO<Notas>, INotasDAO
    {

        private readonly ApplicationDbContext _context;

        public NotasDAO(ApplicationDbContext context)
        {
            _context = context;
        }
        public Notas? GetByMateriaId(int materiaMatriculadoId)
        {
            var materiaMatriculado = _context.Set<Materia>()
                                            .Include(mm => mm.Notas)
                                            .FirstOrDefault(mm => mm.Id == materiaMatriculadoId);

            if (materiaMatriculado == null || materiaMatriculado.Notas == null)
            {
                return null;
            }

            return materiaMatriculado.Notas;
        }
    }
}
