using FoodFactory.Data.Services;
using FoodFactory.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodFactory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public ProductService _productService;
            public ProductController(ProductService productService)
         {  _ProductService = productServicee;
        }
        [HttpPost("add-Product")]
        public IActionResult AddProducts([FromBody] ProductVM Products)
        {
            _productServices.AddProduct(Products);
            return Ok();
        }
                

    }
}
