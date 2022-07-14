using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OmlineStore.Model;
using Services.InterFaces;

namespace OnlineStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductInterFase _productService;

        public ProductController(ProductInterFase productService)
        {
            _productService = productService;
        }

        [HttpGet("products")]
        public async Task<IActionResult> GetProducts()
        {
            var result = await _productService.GetProducts();
            return Ok(result);
        }

        [HttpPut("createProducts")]
        public async Task<IActionResult> CreateProduct([FromBody] Product product)
        {
            throw new NotImplementedException();
        }



        [HttpPost("updateProducts")]
        public async Task<IActionResult> UpdateProduct([FromBody] Product product)
        {
            throw new NotImplementedException();
        }
    }
}
