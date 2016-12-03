using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WS_MiPrepago.Dominio;

namespace WS_MiPrepago
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IProveedorService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IProveedorService
    {
        [OperationContract]
        List<ModeloProveedor> consultarDisponibilidad(string marca, string modelo);
   
        [OperationContract]
        Reserva crearReserva(Reserva reservaAcrear);

    }
}
