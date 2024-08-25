using Bot.Core.DAO;
using Bot.Core.Model;
using Bot.Core.Service;
using Bot.Core.src.DAO;
using Bot.Core.src.DAO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Core.Service
{
    public class NotasService : IService<Notas>
    {
        private INotasDAO _dao;

        public NotasService()
        {
            _dao = new NotasDAO(new ApplicationDbContext());
        }

        public IEnumerable<Notas> GetAll()
        {
            return _dao.GetAll();
        }

        public Notas? GetById(int id)
        {
            return _dao.GetById(id);
        }

        public Notas? GetByMateriaMatriculadoId(int materiaMatriculadoId)
        {
            return _dao.GetByMateriaMatriculadoId(materiaMatriculadoId);
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
