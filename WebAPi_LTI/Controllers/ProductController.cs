using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Cryptography;
using WebAPi_LTI.Models;
using WebAPI_LTI.Models;

namespace WebAPI_LTI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        public AppDbContext _context { get; }
        [HttpGet]
        public ActionResult Get()
        {
            var data = _context.Products.ToList();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public ActionResult get(int id)
        {
            var data = _context.Products.FirstOrDefault(p => p.ProductId == id);
            return Ok(data);
        }

        [HttpPost]
        public ActionResult post(Product newproduct)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                _context.Products.Add(newproduct);
                _context.SaveChanges();
                return Ok();
            }
        }
        [HttpPut("{id}")]


        public ActionResult put(int? id, Product prod)

        {
            if (id == null)

                return NotFound();

            else
            {
                var data = _context.Products.FirstOrDefault(p => p.ProductId == id);

                if (!ModelState.IsValid)

                    return BadRequest();

                else

                    data.ProductName = prod.ProductName;
                data.ProductId = prod.ProductId;
                data.ProductId = prod.ProductId;



                _context.SaveChanges();
                return Ok();

            }


        }

    }

}