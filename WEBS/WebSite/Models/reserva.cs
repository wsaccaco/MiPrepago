using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSite.Models
{
    public class reserva
    {
     
        public int reserva_id { get; set; }
     
        public string nombre { get; set; }
    
        public string apellido { get; set; }
       
        public string email { get; set; }
      
        public string celular { get; set; }
       
        public int cantidad { get; set; }
      
        public int proveedor_id { get; set; }

        public string codigoReserva { get; set; }

        public int modeloId { get; set; }
    }
}