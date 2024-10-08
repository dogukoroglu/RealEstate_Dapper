using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper.Repositories.ProductRepository;

namespace RealEstate_Dapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProduct()
        {
            var values = await _productRepository.GetAllProductAsync();
            return Ok(values);
        }

        [HttpGet("GetAllProductWithCategory")]
        public async Task<IActionResult> GetAllProductWithCategory()
        {
            var values = await _productRepository.GetAllProductWithCategoriesAsync();
            return Ok(values);
        }
    }
}
