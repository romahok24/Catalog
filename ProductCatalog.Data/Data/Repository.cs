using Microsoft.EntityFrameworkCore;
using ProductCatalog.Data.Interfaces;
using ProductCatalog.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ProductCatalog.Data.Data
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        ApplicationContext _context;
        DbSet<T> _dbSet;

        public Repository(ApplicationContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public IEnumerable<T> Get()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public IEnumerable<T> GetWhere(Func<T, bool> predicate)
        {
            return _dbSet.AsNoTracking().Where(predicate).ToList();
        }

        public T FirstOrDefault(Func<T, bool> predicate)
        {
            return _dbSet.AsNoTracking().FirstOrDefault(predicate);
        }

        public T Get(int id)
        {
            return _dbSet.Find(id);
        }

        public void Create(T item)
        {
            _dbSet.Add(item);
        }

        public void Update(T item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }

        public void Remove(T item)
        {
            _dbSet.Remove(item);
        }

        public IEnumerable<T> Include(params Expression<Func<T, object>>[] includeProperties)
        {
            return GetWithInclude(includeProperties).ToList();
        }

        public IEnumerable<T> Include(Func<T, bool> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            var query = GetWithInclude(includeProperties);
            return query.Where(predicate).ToList();
        }

        private IQueryable<T> GetWithInclude(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _dbSet.AsNoTracking();
            return includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }
    }
}