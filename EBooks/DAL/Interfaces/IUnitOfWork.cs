using System;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomerRepository Customers { get; }
        IOrderRepository Orders { get; }
        IOrderDetailRepository OrderDetails { get; }
        IProductRepository Products { get; }
        IProductCategoryRepository ProductCategories { get; }
        ISupplierRepository Suppliers { get; }
        IUserRepository Users { get; }
        Task Save();
    }
}