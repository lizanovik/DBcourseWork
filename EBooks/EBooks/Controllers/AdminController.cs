using System;
using System.Threading.Tasks;
using BLL_core.DTO;
using BLL_core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EBooks.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        public IActionResult ViewNewOrders()
        {
            var newOrders = _adminService.GetNewOrders();
            return View(newOrders);
        }

        public IActionResult AddProduct()
        {
            SelectList suppliers = new SelectList(_adminService.GetSuppliers(), "Id", "CompanyName");
            SelectList productCategories = new SelectList(_adminService.GetProductCategories(), "Id", "Name");
            ViewBag.Suppliers = suppliers;
            ViewBag.Categories = productCategories;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(AddProductModel model)
        {

            if (!await _adminService.AddProduct(model))
            {
                ModelState.AddModelError(String.Empty, "You have entered incorrect data.");
                return View(model);
            }

            return RedirectToAction("AddProduct");
        }

        public IActionResult AddSupplier()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddSupplier(AddSupplierModel model)
        {
            await _adminService.AddSupplier(model);
            return RedirectToAction("Add");
        }
        public async Task<IActionResult> ConfirmOrder(int id)
        {
            await _adminService.ConfirmOrder(id);
            //await _adminService.SendConfirmationMessage(id);
            return RedirectToAction("HomePage", "Home");
        }

        public async Task<IActionResult> RejectOrder(int id)
        {
            await _adminService.RejectOrder(id);
            //await _adminService.SendRejectionMessage(id);
            return RedirectToAction("HomePage", "Home");
        }
    }
}
