using ProductOrderApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductOrderApplication
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public static List<CategoryOfProducts> GetCategories()
        {
            var categories = new List<CategoryOfProducts> {
                new CategoryOfProducts
                {
                    CategoryID = 1,
                    CategoryName = "Cars"
                },
                new CategoryOfProducts
                {
                    CategoryID = 2,
                    CategoryName = "Planes"
                },
                new CategoryOfProducts
                {
                    CategoryID = 3,
                    CategoryName = "Trucks"
                },
                new CategoryOfProducts
                {
                    CategoryID = 4,
                    CategoryName = "Boats"
                },
                new CategoryOfProducts
                {
                    CategoryID = 5,
                    CategoryName = "Rockets"
                },
            };

            return categories;
        }
    }
}