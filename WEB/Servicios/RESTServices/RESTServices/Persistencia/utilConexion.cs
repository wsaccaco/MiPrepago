using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTServices.Persistencia
{
    public class utilConexion
    {
        public static string CadenaConexion
        {
            get
            {
                return "Data source=(local); Initial catalog=BD_PROVEEDOR; Integrated security=SSPI;";
            }
        }
       
    }
}