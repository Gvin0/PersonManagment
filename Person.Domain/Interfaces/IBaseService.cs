using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Person.Domain.Interfaces
{
    public interface IBaseService<T> where T : class
    {
        T Fetch(int id);
        IQueryable<T> Set();
        T Save(T entity);
        T Delete(int id);
        T Delete(T entity);
        T Update(T entity);
        void Commit();
    }
}

