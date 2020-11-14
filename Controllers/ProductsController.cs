using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductsAPI.Models;
using ProductsAPI.Services;

namespace ProductsAPI.APIControllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController
    {
        public ILogger _logger;
        private IProductsService _service;


        public ProductsController(ILogger<ProductsController> logger, IProductsService service)
        {
            _logger = logger;
            _service = service;

        }

        [HttpGet("/api/products")]
        public ActionResult<List<Product>> GetProducts()
        {
            return _service.GetProducts();
        }

        [HttpPost("/api/products")]
        public ActionResult<Product> AddProduct(Product product)
        {
            _service.AddProduct(product);
            return product;
        }

        [HttpPut("/api/products/{id}")]
        public ActionResult<Product> UpdateProduct(Product product)
        {
            _service.UpdateProduct(product);
            return product;
        }

        [HttpDelete("/api/products/{id}")]
        public ActionResult<int> DeleteProduct(int id)
        {
            _service.DeleteProduct(id);
            //_logger.LogInformation("products", _products);
            return id;
        }
    }
}
