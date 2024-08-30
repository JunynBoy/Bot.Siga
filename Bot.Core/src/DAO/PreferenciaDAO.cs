using Bot.Core.Model;
using Bot.Core.src.DAO.Interface;
using Bot.Core.src.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Core.DAO
{
    public class PreferenciaDAO : GenericDAO<Preferencia>, IPreferenciaDAO
    {
        public PreferenciaDAO(DbContext context) : base(context) { }

    }
}
