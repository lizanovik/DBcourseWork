using DAL_core.EntityFramework;
using DAL_core.Interfaces;
using DAL_core.Entities;

namespace DAL_core.Repositories
{
    class SupplierRepository : Repository<Supplier>, ISupplierRepository
    {
        private readonly EBooksContext _context;
        public SupplierRepository(EBooksContext context) : base(context)
        {
            _context = context;
        }
    }
}