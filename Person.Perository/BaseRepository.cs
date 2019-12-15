using Microsoft.EntityFrameworkCore;
using Person.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Person.Repository
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        internal AppDbContext _context { get; private set; }
        protected DbSet<T> objectSet;

        public BaseRepository(IAppDbContext context)
        {
            _context = context as AppDbContext;
            objectSet = _context.Set<T>();
        }

        public T Fetch(int id)
        {
            return objectSet.Find(id);
        }

        public T Save(T entity)
        {
            return Save(objectSet, entity);
        }

        public IQueryable<T> Set()
        {
            return objectSet;
        }

        public T Update(T entity)
        {
            objectSet.Attach(entity);
            _context.Entry<T>(entity).State = EntityState.Modified;
            return entity;
        }
        public T Delete(int id)
        {
            return Delete(Fetch(id));
        }

        public T Delete(T entity)
        {
            return Delete(objectSet, entity);
        }

        private T Save(DbSet<T> set, T entity)
        {
            var entry = _context.Entry(entity);
            if (entry == null || entry.State == EntityState.Detached)
                set.Add(entity);
            return entity;
        }

        private T Delete(DbSet<T> set, T entity)
        {
            set.Remove(entity);
            return entity;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}