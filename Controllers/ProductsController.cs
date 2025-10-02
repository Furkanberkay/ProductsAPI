using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductAPI.Models;

namespace ProductAPI.Controller
{

    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {

        private  readonly ProductsContext _context;
        public ProductsController(ProductsContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            if (await _context.Products.ToListAsync() == null)
            {
                return NotFound();
            }

            return Ok(await _context.Products.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var p = await _context.Products.FirstOrDefaultAsync(x => x.ProductId == id);

            if (p == null)
            {
                return NotFound();
            }
            return Ok(p);
        }

    }

}