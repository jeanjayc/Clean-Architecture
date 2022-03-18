using CleanArcMvc.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CleanArcMvc.WebUI.Controllers
{
    public class CategoriesController: Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                var categories = await _categoryService.GetCategories();
                return View(categories);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
            
        }
    }
}
