using AgenciaDatos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDatos
{
    public class AutomovilDatos
    {
        private DbConnection db;
        public AutomovilDatos(string conexion)
        {
            db = new DbConnection(conexion);
        }
        // Método para consultar a la tabla automovil
        public List<T> consultarAutomovil<T>(Dictionary<string, dynamic> Parametros)
        {
            return db.Query<T>(Parametros, "AutomovilConsulta");
        }
        // Método para buscar Automovil X Id
        public T consultarAutomovilXId<T>(Dictionary<string, dynamic> Parametros)
        {
            return db.QuerySingle<T>(Parametros, "AutomovilConsultaXId");
        }
        // Método para almacenar un automovil en la tabla de Automovil
        public T insertarAutomovil<T>(Dictionary<string, dynamic> Parametros)
        {
            return db.QuerySingle<T>(Parametros, "AutomovilInserta");
        }
        // Método para actualizar Automovil
        public T actualizarAutomovil<T>(Dictionary<string, dynamic> Parametros)
        {
            return db.QuerySingle<T>(Parametros, "AutomovilActualiza");
        }
        // Método para eliminar Automovil
        public T eliminarAutomovil<T>(Dictionary<string, dynamic> Parametros)
        {
            return db.QuerySingle<T>(Parametros, "AutomovilElimina");
        }
    }
}
