using System.Linq;
using System.Threading.Tasks;
using DAL_core.Entities;

namespace DAL_core.Interfaces
{
    public interface IOrderRepository : IRepository<Order>
    {
        IQueryable<Order> GetOrders();
        Task<Order> GetOrder(int id);
    }
}