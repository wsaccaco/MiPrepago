﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WS_MiPrepago.Dominio
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