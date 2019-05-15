using System.Threading.Tasks;
using BLL_core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EBooks.Controllers
{
    public class OrderController : Controller
    {
        private readonly ICartService _cartService;
        private readonly IOrderService _orderService;
        private readonly IUserService _userService;

        public OrderController(ICartService cartService, IOrderService orderService, IUserService userService)
        {
            _cartService = cartService;
            _orderService = orderService;
            _userService = userService;
        }

        public async Task<IActionResult> MakeOrder()
        {
            var cart = _cartService.GetCart();
            var userId = _userService.GetUserId(User);
            await _orderService.AddOrder(cart, userId);
            _cartService.UpdateCart(null);
            return View("WaitForTheMessage");
        }
        public async Task<IActionResult> ViewOrderHistory()
        {
            var userId = _userService.GetUserId(User);
            var orders = await _orderService.ViewOrderDetails(userId);
            if (orders.Count == 0)
            {
                return View("EmptyOrderHistory");
            }
            return View(orders);
        }

        public async Task<IActionResult> OrderDetails(int id)
        {
            var order = await _orderService.GetOrder(id);
            return PartialView("OrderDetailsPartial", order);
        }
    }
}