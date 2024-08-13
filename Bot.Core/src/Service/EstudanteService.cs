using Bot.Core.DAO;
using Bot.Core.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Core.Service
{
    public class EstudanteService : IService<Estudante>
    {
        private EstudanteDAO _dao;

        public EstudanteService()
        {
            _dao = new EstudanteDAO(new ApplicationDbContext());
        }

        public IEnumerable<Estudante> GetAll()
        {
            return _dao.GetAll();
        }

        public Estudante? GetById(int id)
        {
            return _dao.GetById(id);
        }

        public Estudante? GetByCpf(string cpf)
        {
            return _dao.GetByCpf(cpf);
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
