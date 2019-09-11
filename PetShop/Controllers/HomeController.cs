using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(); //Este mae devuelve la vista, en esta caso es home
        }
        [Route("Prueba/{Id}")] //Le cambie el routing, puedo ponerlo aqui y mas simple, puede pasar parametros en el query string
        public ActionResult Prueba(string id)
        {
            //Para pasar datos a las vistas, se usa el viewbag
            ViewBag.CualquierCosa = id;
            return View();
        }

        public JsonResult PruebaJson()
        {
            //A este le puede hacer un request con Ajax, jquery, javascript, y con eso lo puede manejar como un Json.
            return new JsonResult { Data = new { Name = "Juan", JuegosGanados = new List<string>() { "Mario Bros", "Otro" } }, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}// para ver algo