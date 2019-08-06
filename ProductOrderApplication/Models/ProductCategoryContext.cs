using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductOrderApplication.Models
{
    public class ProductCategoryContext : DbContext
    {

        internal IQueryable<CategoryOfProducts> Categories { get; set; }
        
        public ProductCategoryContext() : base("ProductOrderApplication")
        {
          
        }
        public DbSet<CategoryOfProducts> CategoryOfProducts { get; set; }
        public DbSet<ListOfProducts> ListOfProducts { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
        public IQueryable<ProductList> Products { get; internal set; }
    }
}