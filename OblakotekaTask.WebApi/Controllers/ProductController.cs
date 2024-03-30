using Microsoft.AspNetCore.Mvc;
using OblakotekaTask.Application.Interfaces;
using OblakotekaTask.Domain.ViewModels.ProductModels;
using OblakotekaTask.WebApi.Models;
using System.Diagnostics;

namespace OblakotekaTask.WebApi.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService) =>
            _productService = productService;

        [HttpGet]
        public async Task<IActionResult> Index(string? searchName)
        {
            IEnumerable<ProductViewModel> response;
            if (string.IsNullOrEmpty(searchName))
            {
                response = await _productService.GetAll();
            }
            else
            {
                response = await _productService.GetAllByName(searchName);
            }
            return View(response);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var response = await _productService.Create(vm);

                return RedirectToAction(nameof(Index));
            }

            return View(vm);
        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            var response = await _productService.GetById(id);

            return PartialView(response);
        }

        [HttpPost]
        public async Task<IActionResult> Update(ProductViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var response = await _productService.Update(vm);
                return RedirectToAction(nameof(Index));
            }

            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _productService.Delete(id);

            return RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
