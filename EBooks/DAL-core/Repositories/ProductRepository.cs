using System.Linq;
using DAL_core.EntityFramework;
using DAL_core.Interfaces;
using DAL_core.Entities;
using Korzh.EasyQuery.Linq;
using Microsoft.EntityFrameworkCore;

namespace DAL_core.Repositories
{
    class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly EBooksContext _context;
        public ProductRepository(EBooksContext context) : base(context)
        {
            _context = context;
        }
        public IQueryable<Product> GetProducts()
        {
            return _context.Products
                .Include(supplier => supplier.Supplier);
        }

        public IQueryable<Product> FullTextSearch(string text)
        {
            return _context.Products.Include(p => p.Supplier).FullTextSearchQuery(text);
        }
    }
}
