﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RESTServices.Dominio;
using RESTServices.Persistencia;

namespace RESTServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Reservas" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Reservas.svc o Reservas.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Reservas : IReservas
    {
        private ReservaDAO dao = new ReservaDAO();
        public Reserva crearReserva(Reserva reservaACrear)
        {
            return dao.crear(reservaACrear);
        }

        public Reserva obtenerReserva(string id)
        {
            int idx = Int32.Parse(id);
            return dao.obtener(idx);
        }
    }
}
