using System.ComponentModel.DataAnnotations;

namespace WebAPi_LTI.Models
{
    public class ProductCatViewModel
    {
        [Key]
        public int CatId { get; set; }
        public string ProductName { get; set; }
        public string CatName { get; set; }

        public int ProductId { get; set; }
        public decimal Price { get; set; }

    
    }
}