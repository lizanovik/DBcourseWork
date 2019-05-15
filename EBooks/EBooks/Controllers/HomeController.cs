using System;
using System.Diagnostics;
using System.Threading.Tasks;
using BLL_core.Interfaces;
using BLL_core.Pagination;
using DAL_core.Entities;
using DAL_core.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace EBooks.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult HomePage()
        {
            return View();
        }

        public async Task<IActionResult> EBooks(string searchString, int page = 1, SortState sortState = SortState.Price, SortOrder sortOrder = SortOrder.Asc)
        {
            var ebooks = _productService.GetProductsByCategory(3);
            var sortedBooks = _productService.GetSortOrder(sortState, sortOrder, ebooks);
            var pageModel = await _productService.AddPaginationSortingFiltering(sortedBooks, page, 5, sortState, sortOrder, searchString);
            return View(pageModel);
        }

        public async Task<IActionResult> Accessories(string searchString, int page = 1, SortState sortState = SortState.Price, SortOrder sortOrder = SortOrder.Asc)
        {
            var accessories = _productService.GetProductsByCategory(4);
            var sortedAccessories = _productService.GetSortOrder(sortState, sortOrder, accessories);
            var pageModel = await _productService.AddPaginationSortingFiltering(sortedAccessories, page, 5, sortState, sortOrder, searchString);
            return View(pageModel);
        }

        public async Task<IActionResult> Search(string searchString, int page = 1, SortState sortState = SortState.Price, SortOrder sortOrder = SortOrder.Asc)
        {
            if (!String.IsNullOrEmpty(searchString))
            {
                var products = _productService.FullTextSearch(searchString);
                var sortedProducts = _productService.GetSortOrder(sortState, sortOrder, products);
                var pageModel = await _productService.AddPaginationSortingFiltering(sortedProducts, page, 5, sortState, sortOrder, searchString);
                return View(pageModel);
            }

            return View("EmptySearch");
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
