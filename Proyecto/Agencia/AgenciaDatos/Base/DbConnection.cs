using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
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

        public List<T> Query<T>(Dictionary<string, dynamic> Parametros, string SP)
        {
            List<T> res;
            try
            {
                using ( IDbConnection conn = new SqlConnection(conexion))
                {
                    var parametros = new DynamicParameters();
                    foreach (KeyValuePair<string,dynamic> item in Parametros)
                    {
                        parametros.Add(item.Key, item.Value);
                    }
                    res = conn.Query<T>(SP, param: parametros, commandType: CommandType.StoredProcedure).ToList();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo completar el proceso", ex);
            }
            return res;
        }

        public T QuerySingle<T>(Dictionary<string, dynamic> Parametros, string SP)
        {
            T res;
            try
            {
                using (IDbConnection conn = new SqlConnection(conexion))
                {
                    var parametros = new DynamicParameters();
                    foreach (KeyValuePair<string, dynamic> item in Parametros)
                    {
                        parametros.Add(item.Key, item.Value);
                    }
                    res = conn.QueryFirst<T>(SP, param: parametros, commandType: CommandType.StoredProcedure);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo completar el proceso", ex);
            }
            return res;
        }
    }
}
