using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WS_MiPrepago.Dominio
{
    [DataContract]
    public class Proveedor
    {
        [DataMember]
        public int proveedor_id { get; set; }
        [DataMember]
        public string nombre { get; set; }
        [DataMember]
        public string ruta { get; set; }
        [DataMember]
        public string tipo { get; set; }
    }
}