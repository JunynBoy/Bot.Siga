using Bot.Core.src.DAO.Interface;
using Bot.Core.src.Model;
using Microsoft.EntityFrameworkCore;

namespace Bot.Core.DAO
{
    public class PreferenciaDAO : GenericDAO<Preferencia>, IPreferenciaDAO
    {
        private readonly ApplicationDbContext _context;

        public PreferenciaDAO(ApplicationDbContext context)
        {
            _context = context;
        }

    }
}
