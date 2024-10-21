using Bot.Core.DAO;
using Bot.Core.Model;
using Bot.Core.src.DAO;
using Bot.Core.src.DAO.Interface;

namespace Bot.Core.Service
{
    public class FaltasService : IService<Faltas>
    {
        private IFaltasDAO _dao;

        public FaltasService()
        {
            var dbContext = DbContextFactory.GetDbContext();
            _dao = new FaltasDAO(dbContext);
        }

        public IEnumerable<Faltas> GetAll()
        {
            return _dao.GetAll();
        }

        public Faltas? GetById(int id)
        {
            return _dao.GetById(id);
        }

        public Faltas? GetByMateriaId(int materiaMatriculadoId)
        {
            return _dao.GetByMateriaId(materiaMatriculadoId);
        }

        public void Remove(Faltas entity)
        {
            _dao.Remove(entity);
        }

        public void Save(Faltas entity)
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
