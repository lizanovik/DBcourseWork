using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL_core.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        Task<T> Get(int id);
        Task Create(T item);
        void Delete(int id);
        IEnumerable<T> Find(Func<T, Boolean> predicate);
        void Update(T item);
    }
}

