using FoodFactory.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodFactory.Data.Models;

namespace FoodFactory.Data.Services

{
    public class ProductService
    {

        private FoodfactoryDbContext context;
        public ProductService(FoodfactoryDbContext context)
        {
            this.context = context;
        }
        public void AddProduct(ProductVM Products)
        {
            var _Product = new Products()
            {
                ProductName = Products.ProductName,
                price = Products.Price,
                IsAvailable = Products.IsAvailable
            };
            this.context.Product.Add(_Product);
            this.context.SaveChanges();


        }
    }
}
