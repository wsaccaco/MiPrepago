using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace u201522215.Dominio
{
    [DataContract]
    public class Marca
    {
        [DataMember]
        public int marca_id { get; set; }
        [DataMember]
        public string nombre{ get; set; }
    }
}