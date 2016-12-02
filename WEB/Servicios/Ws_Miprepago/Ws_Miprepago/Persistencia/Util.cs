using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS_MiPrepago.Persistencia
{
    public class Util
    {
        public static string CadenaConexion
        {
            get
            {
                return "Data source=.\\SQLEXPRESS; Initial catalog=BD_MiPrepago; Integrated security=SSPI;";
            }
        }
    }
}