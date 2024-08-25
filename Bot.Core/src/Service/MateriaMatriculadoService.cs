﻿using Bot.Core.DAO;
using Bot.Core.Model;
using Bot.Core.Service;
using Bot.Core.src.DAO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Core.Service
{
    public class MateriaMatriculadoService : IService<MateriaMatriculado>
    {
        private IMateriaMatriculadoDAO _dao;

        public MateriaMatriculadoService()
        {
            _dao = new MateriaMatriculadoDAO(new ApplicationDbContext());
        }

        public IEnumerable<MateriaMatriculado> GetAll()
        {
            return _dao.GetAll();
        }

        public MateriaMatriculado? GetById(int id)
        {
            return _dao.GetById(id);
        }

        public List<MateriaMatriculado> GetByEstudanteId(int id)
        {
            return _dao.GetByEstudanteId(id);
        }

        public void Remove(MateriaMatriculado entity)
        {
            _dao.Remove(entity);
        }

        public void Save(MateriaMatriculado entity)
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