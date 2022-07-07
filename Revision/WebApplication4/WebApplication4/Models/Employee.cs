using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Employee
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Fn { get; set; }
        [Required]
        public string Ln { get; set; }
        [Required]
        public string Address { get; set; }


    }
}
