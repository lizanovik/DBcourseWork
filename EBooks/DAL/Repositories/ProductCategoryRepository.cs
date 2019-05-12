using DAL.EntityFramework;
using DAL.Interfaces;
using DAL.Entities;

namespace DAL.Repositories
{
    class ProductCategoryRepository : Repository<ProductCategory>, IProductCategoryRepository
    {
        private readonly EBooksContext _context;
        public ProductCategoryRepository(EBooksContext context) : base(context)
        {
            _context = context;
        }
    }
}
