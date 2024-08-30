using Bot.Core.src.DAO.Interface;
using Bot.Core.src.Model;
using Microsoft.EntityFrameworkCore;

namespace Bot.Core.DAO
{
    public class PreferenciaDAO : GenericDAO<Preferencia>, IPreferenciaDAO
    {
        public PreferenciaDAO(DbContext context) : base(context) { }

    }
}
