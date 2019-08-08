using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductOrderApplication.Models
{
    public class CategoryOfProducts
    {
        [Key]
        public int CategoryID { get; set; }
        [Required, StringLength(100), Display(Name = "Name")]
        public string CategoryName { get; set; }
        [Display(Name = "Product Description")]
        public string Description { get; set; }
        public virtual ICollection<ProductCategoryContext> Products { get; set; }
    }
}