using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodFactory.Data.ViewModels
{
    public class ProductVM
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public long Price { get; set; }
        public bool IsAvailable { get; set; }
        public int FoodfactoryId { get; set; }
    }
}
}
