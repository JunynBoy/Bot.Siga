using Bot.Core.DAO;
using Bot.Core.Model;
using Bot.Core.src.DAO;
using Bot.Core.src.DAO.Interface;

namespace Bot.Core.Service
{
    public class MateriaService : IService<Materia>
    {
        private IMateriaDAO _dao;

        public MateriaService()
        {
            var dbContext = DbContextFactory.GetDbContext();
            _dao = new MateriaDAO(dbContext);
        }

        public IEnumerable<Materia> GetAll()
        {
            return _dao.GetAll();
        }

        public Materia? GetById(int id)
        {
            return _dao.GetById(id);
        }

        public List<Materia> GetByEstudanteId(int id)
        {
            return _dao.GetByEstudanteId(id);
        }

        public void Remove(Materia entity)
        {
            _dao.Remove(entity);
        }

        public void Save(Materia entity)
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
