using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL_core.DTO;
using DAL_core.Entities;

namespace BLL_core.Interfaces
{
    public interface IAdminService
    {
        List<OrderModel> GetNewOrders();
        Task ConfirmOrder(int id);
        Task RejectOrder(int id);
        Task SendRejectionMessage(int id);
        Task SendConfirmationMessage(int id);
        Task<bool> AddProduct(AddProductModel model);
        Task AddSupplier(AddSupplierModel model);
        IEnumerable<ProductCategory> GetProductCategories();
        IEnumerable<Supplier> GetSuppliers();
    }
}
