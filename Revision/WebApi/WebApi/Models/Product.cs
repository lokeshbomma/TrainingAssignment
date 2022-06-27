using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Product
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public string productBarnd { get; set; }
        public int productPrice { get; set; }
    }
}
