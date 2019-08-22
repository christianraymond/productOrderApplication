using System;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductOrderApplication.Models
{
    public class ProductCategoryContext : DbContext
    {        
        public ProductCategoryContext() : base("name=ProductOrderApplication")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ProductCategoryContext>());

        }
        public DbSet<CategoryOfProducts> CategoryOfProducts { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
        public IQueryable<ListOfProducts> Products { get; internal set; }
    }
}
