using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DotNetDrinks.Data;  
using DotNetDrinks.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetDrinksWebUI.Models;
using DotNetDrinksWebUI.Data;

namespace DotNetDrinks.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }
    }
}
