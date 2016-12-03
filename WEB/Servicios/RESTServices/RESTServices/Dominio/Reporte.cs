using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RESTServices.Dominio
{
    public class Reporte
    {
        [DataMember]
        public string proveedor { get; set; }

        [DataMember(IsRequired = false)]
        public string ruta { get; set; }

        [DataMember(IsRequired = false)]
        public string fecha { get; set; }

        [DataMember(IsRequired = false)]
        public string marca { get; set; }

        [DataMember(IsRequired = false)]
        public string modelo { get; set; }
    }
}