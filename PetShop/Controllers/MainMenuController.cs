using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetShop.Controllers
{
    public class MainMenuController : Controller
    {
        // GET: MainMenu
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Menu()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contacto()
        {
            return View();
        }

        public ActionResult Productos()
        {
            return View();
        }
        public ActionResult ProductosDetalles()
        {
            return View();
        }
        public ActionResult Bionic()
        {
            return View();
        }
        public ActionResult PlanetDog()
        {
            return View();
        }
        public ActionResult Petstage()
        {
            return View();
        }
        public ActionResult OutwardHound()
        {
            return View();
        }
        public ActionResult Pagos()
        {
            return View();
        }
    }
}