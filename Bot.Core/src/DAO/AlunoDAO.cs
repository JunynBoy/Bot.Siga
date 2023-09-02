using Bot.Core.DAO;
using Bot.Core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Core.DAO
{
    public class AlunoDAO : GenericDAO<Aluno>, IAlunoDAO
    {
        public AlunoDAO(DbContext context) : base(context) { }


        //EXEMPLO DE COMO É FEITO A CONSULTA
        //public Oab? GetByNumeroOAB(string numeroOAB)
        //{
        //    return context.Set<Oab>().Where(o => o.Numero == numeroOAB).FirstOrDefault();
        //}
    }
}
