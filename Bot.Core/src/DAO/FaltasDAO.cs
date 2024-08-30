using Bot.Core.Model;
using Bot.Core.src.DAO.Interface;
using Microsoft.EntityFrameworkCore;

namespace Bot.Core.DAO
{
    public class FaltasDAO : GenericDAO<Faltas>, IFaltasDAO
    {

        public FaltasDAO(DbContext context) : base(context) { }

        public Faltas? GetByMateriaId(int materiaMatriculadoId)
        {
            var materiaMatriculado = context.Set<Materia>()
                                            .Include(mm => mm.Notas)
                                            .FirstOrDefault(mm => mm.Id == materiaMatriculadoId);

            if (materiaMatriculado == null || materiaMatriculado.Faltas == null)
            {
                return null;
            }

            return materiaMatriculado.Faltas;
        }
    }
}
