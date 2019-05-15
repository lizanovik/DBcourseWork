using BLL_core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_core.Interfaces
{
    public interface IOrderService
    {
        Task AddOrder(List<ProductModel> cart, string userId);
        Task<List<OrderModel>> ViewOrderDetails(string id);
        Task<OrderModel> GetOrder(int id);
    }
}
