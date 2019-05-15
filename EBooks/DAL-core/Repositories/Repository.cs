using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL_core.EntityFramework;
using DAL_core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL_core.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private DbSet<T> _entity;
        private EBooksContext _db;
        public Repository(EBooksContext db)
        {
            _entity = db.Set<T>();
            _db = db;
        }
        public async Task Create(T item)
        {
            await _entity.AddAsync(item);
        }

        public void Delete(int id)
        {
            var entity = _entity.Find(id);
            if (entity != null)
                _entity.Remove(entity);
        }

        public void Update(T item)
        {
            _db.Entry(item).State = EntityState.Modified;
        }
        public IEnumerable<T> Find(Func<T, bool> predicate)
        {
            return _entity.Where(predicate).ToList();
        }

        public async Task<T> Get(int id)
        {
            return await _entity.FindAsync(id);

        }

        public IEnumerable<T> GetAll()
        {
            return _entity;
        }

    }
}

