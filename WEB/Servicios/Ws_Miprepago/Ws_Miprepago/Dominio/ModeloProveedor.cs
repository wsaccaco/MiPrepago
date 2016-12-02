using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WS_MiPrepago.Dominio
{
    public class ModeloProveedor
    {
        [DataMember]
        public int id { get; set; }

        [DataMember(IsRequired = false)]
        public string nombre { get; set; }

        [DataMember(IsRequired = false)]
        public string anio { get; set; }

        [DataMember(IsRequired = false)]
        public float precio { get; set; }

        [DataMember(IsRequired = false)]
        public int stock { get; set; }

        [DataMember(IsRequired = false)]
        public int marcaId { get; set; }

        [DataMember(IsRequired = false)]
        public string proveedor { get; set; }
    }
}