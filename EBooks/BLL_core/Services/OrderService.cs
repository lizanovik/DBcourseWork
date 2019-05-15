using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL_core.DTO;
using AutoMapper;
using BLL_core.Interfaces;
using DAL_core.Entities;
using DAL_core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BLL_core.Services
{
    public class OrderService : IOrderService
    {
        private IUnitOfWork Database { get; set; }
        private readonly IMapper _mapper;
        public OrderService(IUnitOfWork iow, IMapper mapper)
        {
            Database = iow;
            _mapper = mapper;
        }

        public async Task AddOrder(List<ProductModel> cart, string userId)
        {
            var order = new Order() { CustomerId = userId, OrderDate = DateTime.Now, Status = OrderStatus.New };
            await Database.Orders.Create(order);
            foreach (var product in cart)
            {
                var orderDetail = new OrderedProduct() { OrderId = order.Id, ProductId = product.Id, PricePerItem = product.Price, Quantity = product.Quantity };
                await Database.OrderDetails.Create(orderDetail);
            }
            await Database.Save();
        }

        public async Task<List<OrderModel>> ViewOrderDetails(string id)
        {
            var orders = Database.Orders.GetOrders();
            var confirmedOrders = await orders.Where(order => order.CustomerId == id)
                .ToListAsync();
            var orderModel = _mapper.Map<List<Order>, List<OrderModel>>(confirmedOrders);
            return orderModel;
        }

        public async Task<OrderModel> GetOrder(int id)
        {
            var order = await Database.Orders.GetOrder(id);
            var orderModel = _mapper.Map<Order, OrderModel>(order);
            return orderModel;
        }
    }
}
