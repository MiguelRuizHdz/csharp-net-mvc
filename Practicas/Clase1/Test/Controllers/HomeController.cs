using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Test.Controllers
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewData["Message"] = "Bienvenido a ASP.NET MVC. del Sabado";
            ViewData["Receso"] = "El receso es a las 11:00 A.M.";
            ViewBag.Nombre = "Miguel Ruiz";
            ViewBag.Direccion = "Guadalupe, Nuevo León";
            ViewBag.Telefono = "8181888600";
            ViewBag.Correo = "Miguel Ruiz";
            ViewBag.Modulo= "ASP.NET MVC";

            return View();
        }
        
        //public ActionResult About()
        //{
        //    ViewBag.Message = "Mensaje desde el controlador en el momento del partido Mexico vs Argentina";
        //    return View();
        //}

        //public HttpStatusCodeResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return new HttpStatusCodeResult(404);
        //}

        //public ContentResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return Content("Miguel Ruiz");
        //}

        //public JsonResult About()
        //{
        //    var persona1 = new Persona() { Nombre="Miguel", Edad=10};
        //    var persona2 = new Persona() { Nombre="Juan", Edad=20};
        //    List<Persona> Lista = new List<Persona>();
        //    Lista.Add(persona1);
        //    Lista.Add(persona2);

        //    return Json(Lista, JsonRequestBehavior.AllowGet);
        //}

        //public RedirectResult About()
        //{
        //    return Redirect("https://www.google.mx");
        //}

        //public RedirectToRouteResult About()
        //{
        //    return RedirectToAction("About", "Home");
        //}

        //public HttpStatusCodeResult About()
        //{
        //    return new HttpStatusCodeResult(301);
        //}

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}