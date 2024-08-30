using DemoRestApi3.Models;
using DemoRestApi3.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoRestApi3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var categories = await _categoryService.GetAllAsync();
            return Ok(categories);
        }

        [HttpPost] 
        public async Task<IActionResult> Post(Category category)
        {
            await _categoryService.CreateAsync(category);
            return Ok("Create Successful");
        }
    }
}
