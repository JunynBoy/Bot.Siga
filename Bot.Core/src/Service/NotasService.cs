using Bot.Core.DAO;
using Bot.Core.Model;
using Bot.Core.src.DAO;
using Bot.Core.src.DAO.Interface;

namespace Bot.Core.Service
{
    public class NotasService : IService<Notas>
    {
        private INotasDAO _dao;

        public NotasService()
        {
            var dbContext = DbContextFactory.GetDbContext();
            _dao = new NotasDAO(dbContext);
        }

        public IEnumerable<Notas> GetAll()
        {
            return _dao.GetAll();
        }

        public Notas? GetById(int id)
        {
            return _dao.GetById(id);
        }

        public Notas? GetByMateriaId(int materiaMatriculadoId)
        {
            return _dao.GetByMateriaId(materiaMatriculadoId);
        }

        public void Remove(Notas entity)
        {
            _dao.Remove(entity);
        }

        public void Save(Notas entity)
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
