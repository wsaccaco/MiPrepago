using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RESTServices.Dominio
{
    [DataContract]
    public class Marca
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember(IsRequired=false)]
        public string nombre { get; set; }
    }
}