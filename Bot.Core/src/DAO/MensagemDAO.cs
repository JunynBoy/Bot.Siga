using Bot.Core.Model;
using Bot.Core.src.DAO.Interface;
using Bot.Core.src.Model;
using Microsoft.EntityFrameworkCore;

namespace Bot.Core.DAO
{
    public class MensagemDAO : GenericDAO<Mensagem>, IMensagemDAO
    {

        private readonly ApplicationDbContext _context;

        public MensagemDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Mensagem> GetByPreferenciaId(int preferenciaId)
        {
            return _context.Set<Mensagem>().Include(mm => mm.Preferencia)
                          .Where(m => m.PreferenciaId == preferenciaId)
                          .ToList();
        }
    }
}
