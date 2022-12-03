using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clase2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewData["Nombre"] = "Miguel Ruiz";
            ViewData["Matricula"] = "8078179";
            ViewData["Modulo"] = "ASP.NET MVC";

            ViewBag.Direccion = "Guadalupe, Nuevo León";
            ViewBag.Telefono = "8181888600";
            ViewBag.CorreoElectronico = "miguel.ruizhz@uanl.edu.mx";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}