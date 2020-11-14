using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsAPI.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public String Name { get; set; }
        public String Brand { get; set; }
    }
}
