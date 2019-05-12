using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ICartService
    {
        void AddItemToCart(ProductModel model);
        bool TryGetCartItemIndex(int id, out int itemIndex);
        List<ProductModel> GetCart();
        Task<bool> CheckQuantity(ProductModel model);
        void RemoveFromCart(int id);
        double GetTotalCost(List<ProductModel> products);
        void UpdateCart(List<ProductModel> cart);
    }
}
