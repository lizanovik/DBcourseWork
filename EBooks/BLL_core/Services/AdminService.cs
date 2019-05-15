using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BLL_core.DTO;
using BLL_core.Interfaces;
using DAL_core.Entities;
using DAL_core.Interfaces;

namespace BLL_core.Services
{
    public class AdminService : IAdminService
    {
        private IUnitOfWork Database { get; set; }
        private readonly IUserService _userService;
        private readonly IEmailService _emailService;
        private readonly IMapper _mapper;
        public AdminService(IUnitOfWork db, IUserService userService, IEmailService emailService, IMapper mapper)
        {
            Database = db;
            _userService = userService;
            _emailService = emailService;
            _mapper = mapper;
        }

        public List<OrderModel> GetNewOrders()
        {
            var newOrders = Database.Orders.GetOrders()
                .Where(order => order.Status == OrderStatus.New)
                .ToList();
            var orderModel = _mapper.Map<List<Order>, List<OrderModel>>(newOrders);
            return orderModel;
        }

        public async Task SendConfirmationMessage(int id)
        {
            var order = await Database.Orders.Get(id);
            var user = await _userService.FindByIdAsync(order.CustomerId);
            await _emailService.SendOrderConfirmationMessage(user.Email);
        }

        public async Task SendRejectionMessage(int id)
        {
            var order = await Database.Orders.Get(id);
            var user = await _userService.FindByIdAsync(order.CustomerId);
            await _emailService.SendOrderRejectionMessage(user.Email);
        }
        public async Task ConfirmOrder(int id)
        {
            var order = await Database.Orders.GetOrder(id);
            order.Status = OrderStatus.Confirmed;
            Database.Orders.Update(order);
            foreach (var product in order.OrderDetails)
            {
                product.Product.AmountInStock -= product.Quantity;
                if (product.Product.AmountInStock <= 0) product.Product.ProductInStock = false;
                Database.Products.Update(product.Product);
            }
            await Database.Save();
        }

        public async Task RejectOrder(int id)
        {
            var order = await Database.Orders.Get(id);
            order.Status = OrderStatus.Rejected;
            Database.Orders.Update(order);
            await Database.Save();
        }

        public async Task<bool> AddProduct(AddProductModel model)
        {
            if (await Database.Suppliers.Get(model.SupplierId) == null || (await Database.ProductCategories.Get(model.ProductCategotyId) == null)
                || model.Price <= 0 || model.AmountInStock <= 0)
            {
                return false;
            }
            var product = _mapper.Map<AddProductModel, Product>(model);
            product.ProductInStock = true;
            await Database.Products.Create(product);
            await Database.Save();
            return true;
        }

        public async Task AddSupplier(AddSupplierModel model)
        {
            var supplier = _mapper.Map<AddSupplierModel, Supplier>(model);
            await Database.Suppliers.Create(supplier);
            await Database.Save();
        }

        public IEnumerable<ProductCategory> GetProductCategories()
        {
            return Database.ProductCategories.GetAll();
        }

        public IEnumerable<Supplier> GetSuppliers()
        {
            return Database.Suppliers.GetAll();
        }
    }
}

