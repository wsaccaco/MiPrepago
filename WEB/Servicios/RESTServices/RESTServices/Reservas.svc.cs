using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RESTServices.Dominio;
using RESTServices.Persistencia;
using System.ServiceModel.Web;
using System.Net;

namespace RESTServices
{
   
    public class Reservas : IReservas
    {

        private string generateID() {
            return Guid.NewGuid().ToString().Substring(0, 8);
        }

        private ReservaDAO dao = new ReservaDAO();
        private ModeloDAO modeloDAO = new ModeloDAO();
        public Reserva crearReserva(Reserva reservaALlegar)
        {

            if (modeloDAO.obtener(reservaALlegar.modeloId).stock < reservaALlegar.cantidad)
            {
                throw new WebFaultException<string>("Stock Insuficiente", HttpStatusCode.NotAcceptable);
            }

            Reserva reservaACrear = new Reserva();
            reservaACrear.estado = "Reserva";
            reservaACrear.codigoReserva = generateID();
            reservaACrear.modeloId = reservaALlegar.modeloId;
            reservaACrear.cantidad = reservaALlegar.cantidad;
            return dao.crear(reservaACrear);
        }

        public Reserva obtenerReserva(string id)
        {
            int idx = Int32.Parse(id);
            return dao.obtener(idx);
        }
    }
}
