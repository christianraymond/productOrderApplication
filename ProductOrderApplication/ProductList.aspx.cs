using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProductOrderApplication.Models;
using System.Web.ModelBinding;


namespace ProductOrderApplication
{
    public partial class ProductList : System.Web.UI.Page
    {

        public int? CategoryID { get; private set; }
        public int? ProductID { get; internal set; }

        protected void Page_Load(object sender, EventArgs e)
        {
        }
        //Comment this code because The database is not being initialized, I am getting the following error that I have tried to replicate but the error still persisting
        //A network-related or instance-specific error occurred while establishing a connection to SQL Server. The server was not found or was not accessible. Verify that the instance name is correct and that SQL Server is configured to allow remote connections. (provider: SQL Network Interfaces, error: 50 - Local Database Runtime error occurred. The specified LocalDB instance does not exist.


        /*public IQueryable<ProductList> GetProducts([QueryString("productID")] int? categoryId)
        {
            var _db = new ProductOrderApplication.Models.ProductCategoryContext();
            IQueryable<ProductList> query = _db.Products;
            if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.CategoryID == categoryId);
            }
            else
            {
                query = null;
            }
            return query;
        }*/

      //Because of the Database bug, maybe makeing a manual loop to this list of product can be great to avoid hard coding the code list.
        public static List<ListOfProducts> GetProducts()
        {
            var products = new List<ListOfProducts> {
                
                 new ListOfProducts
                 {
                     ProductID = 5,
                     ProductName = "Old Style Racer",
                     Description = "This old style racer can fly (with user assistance). Gravity controls flight duration." +
                                   "No batteries required.",
                     ImagePath="carracer.png",
                     UnitPrice = 34.95,
                     CategoryID = 1
                 },
                 new ListOfProducts
                 {
                     ProductID = 6,
                     ProductName = "Ace Plane",
                     Description = "Authentic airplane toy. Features realistic color and details.",
                     ImagePath="planeace.png",
                     UnitPrice = 95.00,
                     CategoryID = 2
                 },
                 new ListOfProducts
                 {
                     ProductID = 7,
                     ProductName = "Glider",
                     Description = "This fun glider is made from real balsa wood. Some assembly required.",
                     ImagePath="planeglider.png",
                     UnitPrice = 4.95,
                     CategoryID = 2
                 },
                 new ListOfProducts
                 {
                     ProductID = 8,
                     ProductName = "Paper Plane",
                     Description = "This paper plane is like no other paper plane. Some folding required.",
                     ImagePath="planepaper.png",
                     UnitPrice = 2.95,
                     CategoryID = 2
                 },
                 new ListOfProducts
                 {
                     ProductID = 9,
                     ProductName = "Propeller Plane",
                     Description = "Rubber band powered plane features two wheels.",
                     ImagePath="planeprop.png",
                     UnitPrice = 32.95,
                     CategoryID = 2
                 },
                 new ListOfProducts
                 {
                     ProductID = 10,
                     ProductName = "Early Truck",
                     Description = "This toy truck has a real gas powered engine. Requires regular tune ups.",
                     ImagePath="truckearly.png",
                     UnitPrice = 15.00,
                     CategoryID = 3
                 },
                 new ListOfProducts
                 {
                     ProductID = 11,
                     ProductName = "Fire Truck",
                     Description = "You will have endless fun with this one quarter sized fire truck.",
                     ImagePath="truckfire.png",
                     UnitPrice = 26.00,
                     CategoryID = 3
                 },
                 new ListOfProducts
                 {
                     ProductID = 12,
                     ProductName = "Big Truck",
                     Description = "This fun toy truck can be used to tow other trucks that are not as big.",
                     ImagePath="truckbig.png",
                     UnitPrice = 29.00,
                     CategoryID = 3
                 },
                 new ListOfProducts
                 {
                     ProductID = 13,
                     ProductName = "Big Ship",
                     Description = "Is it a boat or a ship. Let this floating vehicle decide by using its " +
                                   "artifically intelligent computer brain!",
                     ImagePath="boatbig.png",
                     UnitPrice = 95.00,
                     CategoryID = 4
                 },
                 new ListOfProducts
                 {
                     ProductID = 14,
                     ProductName = "Paper Boat",
                     Description = "Floating fun for all! This toy boat can be assembled in seconds. Floats for minutes!" +
                                   "Some folding required.",
                     ImagePath="boatpaper.png",
                     UnitPrice = 4.95,
                     CategoryID = 4
                 },
                 new ListOfProducts
                 {
                     ProductID = 15,
                     ProductName = "Sail Boat",
                     Description = "Put this fun toy sail boat in the water and let it go!",
                     ImagePath="boatsail.png",
                     UnitPrice = 42.95,
                     CategoryID = 4
                 },
                 new ListOfProducts
                 {
                     ProductID = 16,
                     ProductName = "Rocket",
                     Description = "This fun rocket will travel up to a height of 200 feet.",
                     ImagePath="rocket.png",
                     UnitPrice = 122.95,
                     CategoryID = 5
                 }
             };

            return products;
        }
    }


}
