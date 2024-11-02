using Bot.Core.Model;
using Bot.Core.src.Model;

namespace Bot.Core.src.DAO.Interface
{
    public interface IMensagemDAO : IGenericDAO<Mensagem>
    {
        List<Mensagem> GetByPreferenciaId(int id);
    }
}
