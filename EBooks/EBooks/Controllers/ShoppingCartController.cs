using System.Threading.Tasks;
using BLL_core.DTO;
using BLL_core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EBooks.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ICartService _cartService;
        private readonly IUserService _userService;
        private readonly IProductService _productService;

        public ShoppingCartController(ICartService cartService, IUserService userService, IProductService productService)
        {
            _cartService = cartService;
            _userService = userService;
            _productService = productService;
        }
        public IActionResult ViewCart()
        {
            var cart = _cartService.GetCart();
            if (cart != null)
            {
                ViewBag.Total = _cartService.GetTotalCost(cart);
            }

            return View(cart);
        }
        [HttpPost]
        public async Task<JsonResult> AddToCart([FromBody]ProductModel model)
        {
            var product = await _productService.GetProductById(model.Id);
            var productModel = new ProductModel() { Id = product.Id, Quantity = model.Quantity, Price = product.Price, Title = product.Title };
            if (_userService.IsAuthentificated(User))
            {
                if (await _cartService.CheckQuantity(productModel))
                {
                    _cartService.AddItemToCart(productModel);
                    return Json("Товар был добален в корзину");
                }
                return Json("Введите положительное число!");
            }

            return Json("Пожалуйста, воидите или зарегистрируйтесь!");
        }
        [HttpPost]
        public IActionResult RemoveFromCart(int id)
        {
            _cartService.RemoveFromCart(id);
            return RedirectToAction("ViewCart");
        }

    }
}