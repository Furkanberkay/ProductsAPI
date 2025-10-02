using Microsoft.AspNetCore.Mvc;
using ProductAPI.Models;

namespace ProductAPI.Controller
{

    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {

        private  static List<Product>? _products;
        public ProductsController()
        {
            _products =
            [
                new Product { ProductId = 1, ProductName = "IPhone 11", Price = 25000, IsActive = true },
                new Product{ProductId = 2, ProductName = "IPhone 12", Price = 35000, IsActive = true},
                new Product{ProductId = 3, ProductName = "IPhone 13", Price = 45000, IsActive = true},
                new Product{ProductId = 4, ProductName = "IPhone 14", Price = 55000, IsActive = true},
            ];
            
            
        }
        [HttpGet]
        public List<Product> GetProducts()
        {
            return _products == null ? new List<Product>() : _products;
        }

        [HttpGet("{id}")]
        public Product GetProduct(int id)
        {
            return _products?.FirstOrDefault(x => x.ProductId == id) ?? new Product();
        }

    }

}