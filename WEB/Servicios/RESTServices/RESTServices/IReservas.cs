using RESTServices.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RESTServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IReservas" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IReservas
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "reserva", ResponseFormat = WebMessageFormat.Json)]
        Reserva crearReserva(Reserva reservaACrear);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "reserva/{id}", ResponseFormat = WebMessageFormat.Json)]
        Reserva obtenerReserva(string id);
    }
}
