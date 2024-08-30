using Bot.Core.Model;

namespace Bot.Core.src.DAO.Interface
{
    public interface IFaltasDAO : IGenericDAO<Faltas>
    {
        public Faltas? GetByMateriaId(int id);
    }
}
