using System.Linq;
using DAL_core.Entities;

namespace DAL_core.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        IQueryable<Product> GetProducts();
        IQueryable<Product> FullTextSearch(string text);
    }
}

