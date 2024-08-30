using Bot.Core.Model;

namespace Bot.Core.src.DAO.Interface
{
    public interface IMateriaDAO : IGenericDAO<Materia>
    {
        List<Materia> GetByEstudanteId(int id);
    }
}
