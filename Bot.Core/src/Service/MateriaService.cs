using Bot.Core.DAO;
using Bot.Core.Model;
using Bot.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Core.Service
{
    public class MateriaService : IService<Estudante>
    {
        private MateriaMatriculadoDAO _dao;

        public MateriaService()
        {
            _dao = new MateriaMatriculadoDAO(new ApplicationDbContext());
        }

        public IEnumerable<Estudante> GetAll()
        {
            return _dao.GetAll();
        }

        public Estudante? GetById(int id)
        {
            return _dao.GetById(id);
        }

        public void Remove(Estudante entity)
        {
            _dao.Remove(entity);
        }

        public void Save(Estudante entity)
        {
            if (entity.Id == 0)
            {
                _dao.Insert(entity);
            }
            else
            {
                _dao.Update(entity);
            }
        }


    }

}
