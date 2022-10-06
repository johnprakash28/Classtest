using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPi_LTI.Models;

namespace WebAPi_LTI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCatController : ControllerBase
    {
        public ProductCatController(AppDbContext context)
        {
            _context = context;
        }

        public AppDbContext _context { get; }


        [HttpGet]
        public ActionResult get()
        {
            var data = _context.CatWiseProducts.FromSqlInterpolated($"dbo.SP_ProductCategory");
            return Ok(data);
        }
        [HttpGet]
        [Route("GetProductByCatId/{CatId=int}")]
        public ActionResult GetProductByCatId(int CatId)
        {
            var data = _context.CatWiseProducts.FromSqlInterpolated($"dbo.SP_ProductBYCatId {CatId}");
            return Ok(data);

        }
    }
}
