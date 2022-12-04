using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaEntidad.Base
{
    public class ResponseModel
    {
        public dynamic Data { get; set; }
        public bool Success{ get; set; }
        public string Message { get; set; }
    }
}
