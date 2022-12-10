using AgenciaDatos;
using AgenciaEntidad;
using AgenciaEntidad.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaLogica
{
    public class AutomovilLogica
    {
        private readonly AutomovilDatos automovilDatos;
        public AutomovilLogica()
        {
            automovilDatos = new AutomovilDatos("conexion");
        }

        // Método para consultar a la tabla de Automovil
        public ResponseModel consultaAutomovil(Dictionary<string, dynamic> parametros)
        {
            ResponseModel m = new ResponseModel();
            try
            {
                var res = automovilDatos.consultarAutomovil<AutomovilModel>(parametros);
                m.Data = res;
                m.Success = true;
                m.Message = "";
            }
            catch (Exception ex)
            {
                m.Data = null;
                m.Success = false;
                m.Message = ex.Message + ". " + ex.InnerException;
            }
            return m;
        }
        // Método para agregar un Automovil
        public RespuestaModel insertarAutomovil(Dictionary<string, dynamic> parametros)
        {
            RespuestaModel m = new RespuestaModel();
            try
            {
                m = automovilDatos.insertarAutomovil<RespuestaModel>(parametros);
            }
            catch (Exception ex)
            {
                m.ErrorId = -2;
                m.Id = 0;
                m.MensajeRespuesta = ex.Message + ". " + ex.InnerException;
            }
            return m;
        }
        // Método para actualizar un Automovil
        public RespuestaModel actualizarAutomovil(Dictionary<string, dynamic> parametros)
        {
            RespuestaModel m = new RespuestaModel();
            try
            {
                m = automovilDatos.actualizarAutomovil<RespuestaModel>(parametros);
            }
            catch (Exception ex)
            {
                m.ErrorId = -2;
                m.Id = 0;
                m.MensajeRespuesta = ex.Message + ". " + ex.InnerException;
            }
            return m;
        }
        // Método para buscar Automovil X Id
        public RespuestaModel consultarAutomovilXId(Dictionary<string, dynamic> parametros)
        {
            RespuestaModel m = new RespuestaModel();
            try
            {
                m = automovilDatos.consultarAutomovilXId<RespuestaModel>(parametros);
            }
            catch (Exception ex)
            {
                m.ErrorId = -2;
                m.Id = 0;
                m.MensajeRespuesta = ex.Message + ". " + ex.InnerException;
            }
            return m;
        }

        // Método para eliminar un Automovil
        public RespuestaModel eliminarAutomovil(Dictionary<string, dynamic> parametros)
        {
            RespuestaModel m = new RespuestaModel();
            try
            {
                m = automovilDatos.eliminarAutomovil<RespuestaModel>(parametros);
            }
            catch (Exception ex)
            {
                m.ErrorId = -2;
                m.Id = 0;
                m.MensajeRespuesta = ex.Message + ". " + ex.InnerException;
            }
            return m;
        }
    }
}

