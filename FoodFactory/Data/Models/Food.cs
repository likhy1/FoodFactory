using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodFactory.Data.Models
{
    public class Food
    {
        [Key]
        public int FoodfactoryId { get; set; }
        public string FoodfactoryName { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
       
    }
}

