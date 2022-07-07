using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
    public class Employe
    {
        [Key]
        public int EmployeId { get; set; }
        public int EmployeFn { get; set; }
        public int EmployeLn { get; set; }
        public int EmployeAddr { get; set; }
    }
}
