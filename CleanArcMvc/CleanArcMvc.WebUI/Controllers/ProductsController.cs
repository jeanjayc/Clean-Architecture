using CleanArcMvc.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CleanArcMvc.WebUI.Controllers
{
    public class ProductsController: Controller
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var products = await _productService.GetProductDTOs();
            return View(products);
        }
    }
}
