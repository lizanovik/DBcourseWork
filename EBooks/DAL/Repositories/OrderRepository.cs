
using DAL.EntityFramework;
using DAL.Interfaces;
using System.Linq;
using System.Threading.Tasks;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        private readonly EBooksContext _context;

        public OrderRepository(EBooksContext context) : base(context)
        {
            _context = context;
        }
        public IQueryable<Order> GetOrders()
        {
            return _context.Orders
                .Include(orderDetails => orderDetails.OrderDetails)
                .ThenInclude(product => product.Product);
        }

        public async Task<Order> GetOrder(int id)
        {
            return await _context.Orders.Where(order => order.Id == id)
                .Include(orderDetails => orderDetails.OrderDetails)
                .ThenInclude(product => product.Product).FirstOrDefaultAsync();
        }
    }
}