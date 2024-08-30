using Bot.Core.Model;

namespace Bot.Core.src.DAO.Interface
{
    public interface INotasDAO : IGenericDAO<Notas>
    {

        Notas? GetByMateriaId(int id);

    }
}
