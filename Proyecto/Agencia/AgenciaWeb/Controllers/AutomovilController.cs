using AgenciaLogica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgenciaWeb.Controllers
{
    public class AutomovilController : Controller
    {
        private readonly AutomovilLogica LAutomovil;
        public AutomovilController()
        {
            LAutomovil = new AutomovilLogica();
        }

        // GET: Automovil
        public ActionResult Automovil()
        {
            return View();
        }

        //Metodo que retorna un json con los datos de la tabla Automovil
        public JsonResult consultarAutomovil()
        {
            Dictionary<string, dynamic> parametros = new Dictionary<string, dynamic>(){};
            var datos = LAutomovil.consultaAutomovil(parametros);
            var jsonResult = Json(datos, "application/json", System.Text.Encoding.UTF8, JsonRequestBehavior.AllowGet);
            jsonResult.MaxJsonLength = int.MaxValue;
            return jsonResult;
        }

        //Metodo que inserta un registro a la tabla Automovil
        public JsonResult insertarAutomovil(string marca, string modelo, int anio, decimal precio)
        {
            Dictionary<string, dynamic> parametros = new Dictionary<string, dynamic>()
            {
                {"Marca", marca },
                {"Modelo", modelo },
                {"Anio", anio },
                {"Precio", precio },
            };
            var datos = LAutomovil.insertarAutomovil(parametros);
            var jsonResult = Json(new { success = true, data = datos }, "application/json", System.Text.Encoding.UTF8, JsonRequestBehavior.AllowGet);
            jsonResult.MaxJsonLength = int.MaxValue;
            return jsonResult;
        }

        //Metodo que actualiza un registro de la tabla Automovil
        public JsonResult actualizarAutomovil(int automovilId, string marca, string modelo, int anio, decimal precio)
        {
            Dictionary<string, dynamic> parametros = new Dictionary<string, dynamic>()
            {
                {"AutomovilId", automovilId },
                {"Marca", marca },
                {"Modelo", modelo },
                {"Anio", anio },
                {"Precio", precio },
            };
            var datos = LAutomovil.actualizarAutomovil(parametros);
            var jsonResult = Json(new { success = true, data = datos }, "application/json", System.Text.Encoding.UTF8, JsonRequestBehavior.AllowGet);
            jsonResult.MaxJsonLength = int.MaxValue;
            return jsonResult;
        }

        //Metodo que consulta un registro de la tabla Automovil
        public JsonResult consultarAutomovilXId(int automovilId)
        {
            Dictionary<string, dynamic> parametros = new Dictionary<string, dynamic>()
            {
                {"AutomovilId", automovilId },
            };
            var datos = LAutomovil.consultarAutomovilXId(parametros);
            var jsonResult = Json(new { success = true, data = datos }, "application/json", System.Text.Encoding.UTF8, JsonRequestBehavior.AllowGet);
            jsonResult.MaxJsonLength = int.MaxValue;
            return jsonResult;
        }

        //Metodo que elimina un registro de la tabla Automovil
        public JsonResult eliminarAutomovil(int automovilId)
        {
            Dictionary<string, dynamic> parametros = new Dictionary<string, dynamic>()
            {
                {"AutomovilId", automovilId },
            };
            var datos = LAutomovil.eliminarAutomovil(parametros);
            var jsonResult = Json(new { success = true, data = datos }, "application/json", System.Text.Encoding.UTF8, JsonRequestBehavior.AllowGet);
            jsonResult.MaxJsonLength = int.MaxValue;
            return jsonResult;
        }

    }
}