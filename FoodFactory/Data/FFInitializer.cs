using FoodFactory.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodFactory.Data
{
    public class FFInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<FoodfactoryDbContext>();
                if (!context.Product.Any())
                {
                    context.Product.AddRange(new Products()


                    {
                        ProductName = "Maggie",
                        Price = 12,
                        IsAvailable = true
                    },
                          new Products()
                          {
                              ProductName = "Cake",
                              Price = 40,
                              IsAvailable = false
                          });

                   
                        context.SaveChanges();
                }












            }
        }
    }
}
            
    

