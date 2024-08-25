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
    public class MateriaMatriculadoDAO : GenericDAO<MateriaMatriculado>, IMateriaMatriculadoDAO
    {

        public MateriaMatriculadoDAO(DbContext context) : base(context) { }


        public List<MateriaMatriculado> GetByEstudanteId(int estudanteId)
        {
            return context.Set<MateriaMatriculado>().Include(mm => mm.Notas)
                          .Where(m => m.EstudanteId == estudanteId)
                          .ToList();
        }
    }
}
