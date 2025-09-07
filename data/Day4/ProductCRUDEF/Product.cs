using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ProductCRUDEF
{
    public  class Product
    {
        [Key]
        [StringLength(10)]
        public string ProductID { get; set; }
        [StringLength(20)]
        public string ProductName { get; set; } 
        public int Price { get; set; }
    }
}
