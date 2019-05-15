using DAL_core.EntityFramework;
using DAL_core.Interfaces;
using DAL_core.Entities;

namespace DAL_core.Repositories
{
    class OrderDetailRepository : Repository<OrderedProduct>, IOrderDetailRepository
    {
        private readonly EBooksContext _context;
        public OrderDetailRepository(EBooksContext context) : base(context)
        {
            _context = context;
        }
    }
}
