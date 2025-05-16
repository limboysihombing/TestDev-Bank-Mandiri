using Microsoft.AspNetCore.Mvc;
using Model.DTO;
using Service.Interfaces;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] ProductPayload payload)
        {
            await _productService.CreateProduct(payload);
            return Ok(new { Message = "Product created successfully" });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, [FromBody] ProductPayload payload)
        {
            await _productService.UpdateProduct(id, payload);
            return Ok(new { Message = "Product updated successfully" });
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _productService.GetProductById(id);
            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpGet("search")]
        public async Task<IActionResult> Search([FromQuery] string name)
        {
            var result = await _productService.SearchProducts(name);
            return Ok(result);
        }
    }
}
