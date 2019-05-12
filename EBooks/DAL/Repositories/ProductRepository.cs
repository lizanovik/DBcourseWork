using System.Linq;
using DAL.EntityFramework;
using DAL.Interfaces;
using DAL.Entities;
using Korzh.EasyQuery.Linq;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
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
