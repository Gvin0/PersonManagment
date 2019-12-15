using Person.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Person.Services
{
    public abstract class BaseService<TEntity, TRepository> : IBaseService<TEntity>
             where TEntity : class
             where TRepository : IBaseRepository<TEntity>
    {
        protected TRepository _repository;

        public BaseService(TRepository repository)
        {
            if (repository == null)
            {
                throw new ArgumentNullException("Repository is null.");
            }
            _repository = repository;
        }

        public IQueryable<TEntity> Set()
        {
            return _repository.Set();
        }
        public TEntity Delete(int id)
        {
            return _repository.Delete(id);
        }

        public TEntity Delete(TEntity entity)
        {
            return _repository.Delete(entity);
        }

        public TEntity Fetch(int id)
        {
            return _repository.Fetch(id);
        }

        public TEntity Save(TEntity entity)
        {
            return _repository.Save(entity);
        }    

        public TEntity Update(TEntity entity)
        {
            return _repository.Update(entity);
        }
        public void Commit()
        {
            _repository.Commit();
        }
    }
}
