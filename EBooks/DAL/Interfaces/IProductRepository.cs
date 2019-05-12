using System.Linq;
using DAL.Entities;

namespace DAL.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        IQueryable<Product> GetProducts();
        IQueryable<Product> FullTextSearch(string text);
    }
}

