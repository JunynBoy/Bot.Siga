using Bot.Core.DAO;
using Bot.Core.Model;
using Bot.Core.src.DAO.Interface;
using Microsoft.EntityFrameworkCore;

namespace Bot.Core.src.DAO
{
    public class NotasDAO : GenericDAO<Notas>, INotasDAO
    {

        public NotasDAO(DbContext context) : base(context) { }

        public Notas? GetByMateriaMatriculadoId(int materiaMatriculadoId)
        {
            var materiaMatriculado = context.Set<MateriaMatriculado>()
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
