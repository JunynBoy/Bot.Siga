using Bot.Core.Model;

namespace Bot.Core.src.DAO.Interface
{
    public interface IEstudanteDAO : IGenericDAO<Estudante>
    {
        public Estudante? GetByCpf(string cpf);
        public Estudante? GetByIdComplete(int id);

    }
}
