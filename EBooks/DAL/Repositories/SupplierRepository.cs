using DAL.EntityFramework;
using DAL.Interfaces;
using DAL.Entities;

namespace DAL.Repositories
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