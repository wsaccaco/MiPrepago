﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WS_MiPrepago.Dominio
{
    public class ReservaProveedor
    {
        [DataMember(IsRequired = false)]
        public int id { get; set; }

        [DataMember(IsRequired = false)]
        public string estado { get; set; }
        [DataMember]
        public int cantidad { get; set; }
        [DataMember(IsRequired = false)]
        public DateTime fecha { get; set; }
        [DataMember]
        public string codigoReserva { get; set; }
        [DataMember]
        public int modeloId { get; set; }
    }
}