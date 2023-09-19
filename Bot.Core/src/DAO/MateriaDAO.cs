using Bot.Core.Model;
using Bot.Core.src.DAO.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Core.DAO
{
    public class MateriaDAO : GenericDAO<Aluno>, INotaDAO
    {

        public MateriaDAO(DbContext context) : base(context) { }


        //EXEMPLO DE COMO É FEITO A CONSULTA
        //public Oab? GetByNumeroOAB(string numeroOAB)
        //{
        //    return context.Set<Oab>().Where(o => o.Numero == numeroOAB).FirstOrDefault();
        //}
    }
}
