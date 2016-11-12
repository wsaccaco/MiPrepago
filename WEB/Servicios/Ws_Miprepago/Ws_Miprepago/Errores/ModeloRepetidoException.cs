using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WS_MiPrepago.Errores
{
    [DataContract]
    public class ModeloRepetidoException
    {
        [DataMember]
        public string modelo_id { get; set; }
        [DataMember]
        public string nombre { get; set; }
        [DataMember]
        public string marca_marca_id { get; set; }
    }
}