using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WS_MiPrepago.Dominio
{
    [DataContract]
    public class Reserva
    {
        [DataMember(IsRequired =false)]
        public int reserva_id { get; set; }
        [DataMember(IsRequired = false)]
        public string nombre { get; set; }
        [DataMember(IsRequired = false)]
        public string apellido { get; set; }
        [DataMember(IsRequired = false)]
        public string email { get; set; }
        [DataMember(IsRequired = false)]
        public string celular { get; set; }
        [DataMember(IsRequired = false)]
        public int cantidad { get; set; }
        [DataMember(IsRequired = false)]
        public int proveedor_id { get; set; }

        [DataMember(IsRequired = false)]
        public string proveedor { get; set; }

        [DataMember(IsRequired = false)]
        public string codigoReserva { get; set; }

        [DataMember(IsRequired = false)]
        public int modeloId { get; set; }

    }
}
