using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_LTI.Models;

namespace WebAPi_LTI.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }

        //This model is imaginary table. not available in database. 
        //To catch data coming from stored procedure
        public DbSet<ProductCatViewModel> CatWiseProducts { get; set; }
    }
}