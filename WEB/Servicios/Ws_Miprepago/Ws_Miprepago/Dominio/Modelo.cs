using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WS_MiPrepago.Dominio
{
    [DataContract]
    public class Modelo
    {
        [DataMember]
        public int modelo_id { get; set; }
        [DataMember]
        public string nombre { get; set; }
        [DataMember]
        public int marca_marca_id { get; set; }
        [DataMember]
        public string fec_fab { get; set; }
        [DataMember]
        public string marca { get; set; }
    }
}