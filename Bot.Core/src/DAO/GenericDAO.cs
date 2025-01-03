﻿using Bot.Core.src.DAO;
using Bot.Core.src.DAO.Interface;
using Bot.Core.src.Model.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Bot.Core.DAO
{
    public class GenericDAO<T> : IGenericDAO<T> where T : class
    {

        protected readonly ApplicationDbContext context;

        public GenericDAO()
        {
            this.context = DbContextFactory.GetDbContext();
        }

        public void Insert(T entity)
        {
            if (entity is IOrdinaryEntity ordinaryEntity)
            {
                ordinaryEntity.CreatedAt = DateTime.Now; 
                ordinaryEntity.UpdatedAt = DateTime.Now; 
            }

            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity is IOrdinaryEntity ordinaryEntity)
            {
                ordinaryEntity.UpdatedAt = DateTime.Now; 
            }

            context.Attach(entity);
            context.SaveChanges();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return context.Set<T>().Where(expression);
        }

        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public T? GetById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public void Remove(T entity)
        {
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }
    }
}
