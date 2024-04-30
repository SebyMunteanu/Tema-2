using Lab4Web.Services.Linq;
using Lab4Web.Services.Linq.Product;
using Microsoft.AspNetCore.Mvc;

namespace Lab4Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestLinqController : ControllerBase
    {
        private readonly ILinqService _linqService;

        public TestLinqController(ILinqService linqService)
        {
            _linqService = linqService;
        }

        [HttpGet("get-products-by-category")]
        public List<Product> GetProductsByCategory(string category)
        {
            return _linqService.GetProductsByCategory(category);
        }

        [HttpGet("get-product-names")]
        public List<string> GetProductNames()
        {
            return _linqService.GetProductNames();
        }

        [HttpGet("get-product-count")]
        public int GetProductCount()
        {
            return _linqService.GetProductCount();
        }

        [HttpGet("get-products-by-price")]
        public List<Product> GetProductsByPrice(decimal price)
        {
            return _linqService.GetProductsByPrice(price);
        }

        [HttpGet("get-products-with-stock")]
        public List<Product> GetProductsWithStock()
        {
            return _linqService.GetProductsWithStock();
        }

        [HttpGet("group-products-by-category")]
        public Dictionary<string, List<Product>> GroupProductsByCategory()
        {
            return _linqService.GroupProductsByCategory();
        }
    }
}
