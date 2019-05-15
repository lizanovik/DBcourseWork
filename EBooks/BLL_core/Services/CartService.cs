using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BLL_core.DTO;
using BLL_core.Interfaces;
using BLL_core.SessionExtensions;
using DAL_core.Interfaces;
using Microsoft.AspNetCore.Http;

namespace BLL_core.Services
{
    public class CartService : ICartService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        private IUnitOfWork Database { get; set; }
        private readonly IMapper _mapper;

        public CartService(IUnitOfWork uow, IMapper mapper, IHttpContextAccessor accessor)
        {
            Database = uow;
            _httpContextAccessor = accessor;
            _mapper = mapper;
        }
        public async Task<bool> CheckQuantity(ProductModel model)
        {
            if (model.Quantity <= 0) return false;
            var product = await Database.Products.Get(model.Id);
            var amountInStock = product.AmountInStock;
            if (model.Quantity <= 0 || amountInStock <= 0) return false;
            if (model.Quantity > amountInStock)
            {
                model.Quantity = amountInStock;
            }
            return true;
        }
        public void AddItemToCart(ProductModel model)
        {

            if (_session.GetObjectFromJson<List<ProductModel>>("cart") == null)
            {
                var cart = new List<ProductModel>
                {
                    model
                };
                _session.SetObjectAsJson("cart", cart);
            }
            else
            {
                var cart = _session.GetObjectFromJson<List<ProductModel>>("cart");
                if (TryGetCartItemIndex(model.Id, out int itemIndex))
                {
                    cart[itemIndex].Quantity += model.Quantity;
                }
                else
                {
                    cart.Add(model);
                }
                _session.SetObjectAsJson("cart", cart);

            }
        }
        public bool TryGetCartItemIndex(int id, out int itemIndex)
        {
            List<ProductModel> cart = _session.GetObjectFromJson<List<ProductModel>>("cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Id == id)
                {
                    itemIndex = i;
                    return true;
                }
            }
            itemIndex = 1;
            return false;
        }

        public List<ProductModel> GetCart()
        {
            return _session.GetObjectFromJson<List<ProductModel>>("cart");
        }

        public void RemoveFromCart(int id)
        {
            List<ProductModel> cart = _session.GetObjectFromJson<List<ProductModel>>("cart");
            if (TryGetCartItemIndex(id, out int itemIndex))
            {
                cart.RemoveAt(itemIndex);
                _session.SetObjectAsJson("cart", cart);
            }

        }

        public double GetTotalCost(List<ProductModel> products)
        {
            double totalCost = 0;
            foreach (var product in products)
            {
                totalCost += (product.Quantity * product.Price);
            }
            return totalCost;
        }

        public void UpdateCart(List<ProductModel> cart)
        {
            _session.SetObjectAsJson("cart", cart);
        }
    }
}

