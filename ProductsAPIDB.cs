using Microsoft.EntityFrameworkCore;
using ProductsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsAPI
{
    public class ProductsAPIDB : DbContext
    {
        public ProductsAPIDB(DbContextOptions<ProductsAPIDB> options) : base(options)
        { }

        public DbSet<Product> Products { get; set; }
    }
}
