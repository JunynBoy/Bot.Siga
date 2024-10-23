using Bot.Core.DAO;
using Bot.Core.Model;
using Bot.Core.src.DAO;
using Bot.Core.src.DAO.Interface;

namespace Bot.Core.Service
{
    public class EstudanteService : IService<Estudante>
    {
        private IEstudanteDAO _dao;

        public EstudanteService()
        {
            var dbContext = DbContextFactory.GetDbContext();
            _dao = new EstudanteDAO(dbContext);
        }

        public IEnumerable<Estudante> GetAll()
        {
            return _dao.GetAll();
        }

        public Estudante? GetById(int id)
        {
            return _dao.GetByIdComplete(id);
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
