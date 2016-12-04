using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestTest
{
    class Reserva
    {
        public int id { get; set; }

        public string estado { get; set; }
        public int cantidad { get; set; }
        public DateTime fecha { get; set; }
        public string codigoReserva { get; set; }
        public int modeloId { get; set; }
    }
}
