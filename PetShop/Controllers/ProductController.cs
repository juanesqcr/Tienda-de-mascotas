using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PetShop.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        [Route("Product/{id}")]
        public ActionResult Index(int id)
        {
            try
            {
                Models.Product modProduct = new Models.Product { JsonPath = System.Web.HttpContext.Current.Server.MapPath("/Content/Products.json") };
                var productObj = modProduct.GetProductById(id);
          
                return View(productObj);
            }
            catch (Exception ex)
            {
            
                ViewBag["Error"] = "ERR0001";

            }

            return View();
        }
    }
}