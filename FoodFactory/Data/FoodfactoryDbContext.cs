using FoodFactory.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodFactory.Data
{
    public class FoodfactoryDbContext : DbContext
    {
        public FoodfactoryDbContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Products> Product { get; set; }
        public DbSet<Food> FoodFactory { get; set; }
        public object Food { get; internal set; }
    }
}
