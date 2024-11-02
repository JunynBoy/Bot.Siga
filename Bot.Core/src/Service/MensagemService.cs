using Bot.Core.DAO;
using Bot.Core.Model;
using Bot.Core.src.DAO;
using Bot.Core.src.DAO.Interface;
using Bot.Core.src.Model;

namespace Bot.Core.Service
{
    public class MensagemService : IService<Mensagem>
    {
        private IMensagemDAO _dao;

        public MensagemService()
        {
            var dbContext = DbContextFactory.GetDbContext();
            _dao = new MensagemDAO(dbContext);
        }

        public IEnumerable<Mensagem> GetAll()
        {
            return _dao.GetAll();
        }

        public Mensagem? GetById(int id)
        {
            return _dao.GetById(id);
        }

        public List<Mensagem> GetByPreferenciaId(int id)
        {
            return _dao.GetByPreferenciaId(id);
        }

        public void Remove(Mensagem entity)
        {
            _dao.Remove(entity);
        }

        public void Save(Mensagem entity)
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
