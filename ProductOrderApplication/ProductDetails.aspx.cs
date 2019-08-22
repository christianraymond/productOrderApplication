using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.ModelBinding;
using ProductOrderApplication.Models;

namespace ProductOrderApplication
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        //Using Model binding to Bind Data from the database. But databaseInitializer is not sending the data to the database, still replicationg the cause.
        public IQueryable<ListOfProducts> GetSingleProduct([QueryString("productID")] int? productId)
        {
            var _db = new ProductOrderApplication.Models.ProductCategoryContext();
            IQueryable<ListOfProducts> query = _db.Products;
            if (productId.HasValue && productId > 0)
            {
                query = query.Where(p => p.ProductID == productId);
            }
            else
            {
                query = null;
            }
            return query;
        }
    }
}

