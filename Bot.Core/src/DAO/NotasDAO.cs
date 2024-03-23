using Bot.Core.DAO;
using Bot.Core.Model;
using Bot.Core.src.DAO.Interface;
using Microsoft.EntityFrameworkCore;

namespace Bot.Core.src.DAO
{
    public class NotasDAO : GenericDAO<Estudante>, INotasDAO
    {

        public NotasDAO(DbContext context) : base(context) { }


        //EXEMPLO DE COMO É FEITO A CONSULTA
        //public Oab? GetByNumeroOAB(string numeroOAB)
        //{
        //    return context.Set<Oab>().Where(o => o.Numero == numeroOAB).FirstOrDefault();
        //}
    }
}
