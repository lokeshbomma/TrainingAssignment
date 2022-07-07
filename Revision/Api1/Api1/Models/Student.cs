using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api1.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Price { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }
    }
}
