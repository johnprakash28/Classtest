using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPi_LTI.Models
{
    public class Categories
    {
        [Key]
        public int CatId { get; set; }
        public string CatName { get; set; }
    }
}
