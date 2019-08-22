using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProductOrderApplication.Models;
using System.Web.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace ProductOrderApplication
{
    public partial class ProductList  : System.Web.UI.Page
    {
        [Key]
        public int? CategoryID { get; private set; }
        public int? ProductID { get; internal set; }

        protected void Page_Load(object sender, EventArgs e)
        {
        }
        public IQueryable<ListOfProducts> GetProducts([QueryString("id")] int? categoryId, [RouteData] string categoryName)
        {
            var _db = new ProductCategoryContext();
            IQueryable<ListOfProducts> query = _db.Products;

            if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.CategoryID == categoryId);
            }

           /* if (!string.IsNullOrEmpty(categoryName))
            {
                query = query.Where(p => string.Compare(p.Category.CategoryName, categoryName) == 0);
            }*/

            return query;
        }
    }
}
