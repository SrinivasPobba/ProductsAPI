using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductsAPI.Models;

namespace ProductsAPI.Services
{
    public class ProductsService: IProductsService
    {
        public ProductsAPIDB _context;

        public ProductsService(ProductsAPIDB context)
        {
            _context = context;
        }

        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public Product AddProduct(Product productToAdd)
        {
            _context.Add(productToAdd);
            _context.SaveChanges();
            return productToAdd;
        }

        public Product UpdateProduct(Product productToUpdate)
        {
            _context.Products.Update(productToUpdate);
            _context.SaveChanges();
            return productToUpdate;
        }

        public int DeleteProduct(int id)
        {
            var productToDelete = _context.Products.Find(id);
            _context.Products.Remove(productToDelete);
            _context.SaveChanges();
            return id;
        }

    }
}
