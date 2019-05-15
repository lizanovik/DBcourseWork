using DAL_core.EntityFramework;
using DAL_core.Interfaces;
using DAL_core.Entities;

namespace DAL_core.Repositories
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
