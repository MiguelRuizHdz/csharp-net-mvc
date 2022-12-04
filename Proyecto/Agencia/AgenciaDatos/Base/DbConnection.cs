using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDatos.Base
{
    public class DbConnection
    {
        private string conexion = "";

        public DbConnection(string _conexion)
        {
            conexion = ConfigurationManager.ConnectionStrings[_conexion].ToString();
        }
    }
}
