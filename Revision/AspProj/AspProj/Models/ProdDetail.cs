using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspProj.Models
{
    public class ProdDetail
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Range(1000, 100000, ErrorMessage = "Price must be between 1000 and 100000")]
        public int Price { get; set; }

        [Required(ErrorMessage = "A BrandName is required")]
        public string Brand { get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}
