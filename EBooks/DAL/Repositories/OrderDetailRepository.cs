using DAL.EntityFramework;
using DAL.Interfaces;
using DAL.Entities;

namespace DAL.Repositories
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
