using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodFactory.Data.Models
{
    public class Products
    { [Key]
        public int ProductId{ get; set; }
        public string ProductName { get; set; }
        public long Price { get; set; }
        public bool IsAvailable { get; set; }
        public int FoodfactoryId { get; set; }
    }
}