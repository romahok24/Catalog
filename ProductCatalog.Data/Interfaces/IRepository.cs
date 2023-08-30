using ProductCatalog.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ProductCatalog.Data.Interfaces
{
    public interface IRepository<T>
    {
        T Get(int id);
        IEnumerable<T> Get();
        IEnumerable<T> GetWhere(Func<T, bool> predicate);
        T FirstOrDefault(Func<T, bool> predicate);
        void Create(T item); 
        void Remove(T item);
        void Update(T item);
        IEnumerable<T> Include(params Expression<Func<T, object>>[] includeProperties);
        IEnumerable<T> Include(Func<T, bool> predicate, params Expression<Func<T, object>>[] includeProperties);
    }
}