using Microsoft.AspNetCore.Mvc;
using ServerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly DataContext _dataContext;

        public ProductController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        [HttpGet("{id}")]
        public Product GetProduct(long id)
        {
            var prod = _dataContext.Products.Find(id);
            return prod;
        }
    }
}
