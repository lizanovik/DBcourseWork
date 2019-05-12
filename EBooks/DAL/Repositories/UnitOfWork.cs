using System.Threading.Tasks;
using DAL.EntityFramework;
using DAL.Interfaces;

namespace DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EBooksContext _context;
        private ICustomerRepository customerRepository;
        private IOrderDetailRepository orderDetailRepository;
        private IOrderRepository orderRepository;
        private IProductCategoryRepository productCategoryRepository;
        private IProductRepository productRepository;
        private ISupplierRepository supplierRepository;
        private IUserRepository userRepository;
        public UnitOfWork(EBooksContext context)
        {
            _context = context;
        }
        public ICustomerRepository Customers
        {
            get
            {
                if (customerRepository == null)
                {
                    customerRepository = new CustomerRepository(_context);
                }
                return customerRepository;
            }
        }
        public IOrderRepository Orders
        {
            get
            {
                if (orderRepository == null)
                {
                    orderRepository = new OrderRepository(_context);
                }
                return orderRepository;
            }
        }
        public IOrderDetailRepository OrderDetails
        {
            get
            {
                if (orderDetailRepository == null)
                {
                    orderDetailRepository = new OrderDetailRepository(_context);
                }
                return orderDetailRepository;
            }
        }
        public IProductRepository Products
        {
            get
            {
                if (productRepository == null)
                {
                    productRepository = new ProductRepository(_context);
                }
                return productRepository;
            }
        }

        public IProductCategoryRepository ProductCategories
        {
            get
            {
                if (productCategoryRepository == null)
                {
                    productCategoryRepository = new ProductCategoryRepository(_context);
                }
                return productCategoryRepository;
            }
        }
        public ISupplierRepository Suppliers
        {
            get
            {
                if (supplierRepository == null)
                {
                    supplierRepository = new SupplierRepository(_context);
                }
                return supplierRepository;
            }
        }

        public IUserRepository Users
        {
            get
            {
                if (userRepository == null)
                {
                    userRepository = new UserRepository(_context);
                }
                return userRepository;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}

