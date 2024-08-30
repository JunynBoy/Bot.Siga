using Bot.Core.DAO;
using Bot.Core.src.DAO.Interface;
using Bot.Core.src.Model;

namespace Bot.Core.Service
{
    public class PreferenciaService : IService<Preferencia>
    {
        private IPreferenciaDAO _dao;

        public PreferenciaService()
        {
            _dao = new PreferenciaDAO(new ApplicationDbContext());
        }

        public IEnumerable<Preferencia> GetAll()
        {
            return _dao.GetAll();
        }

        public Preferencia? GetById(int id)
        {
            return _dao.GetById(id);
        }

        public void Remove(Preferencia entity)
        {
            _dao.Remove(entity);
        }

        public void Save(Preferencia entity)
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
