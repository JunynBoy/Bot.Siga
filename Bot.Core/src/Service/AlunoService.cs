using Bot.Core.DAO;
using Bot.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Core.Service
{
    public class AlunoService : IService<Aluno>
    {
        private AlunoDAO _dao;

        public AlunoService()
        {
            _dao = new AlunoDAO(new ApplicationDbContext());
        }

        public IEnumerable<Aluno> GetAll()
        {
            return _dao.GetAll();
        }

        public Aluno? GetById(int id)
        {
            return _dao.GetById(id);
        }

        public void Remove(Aluno entity)
        {
            _dao.Remove(entity);
        }

        public void Save(Aluno entity)
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
