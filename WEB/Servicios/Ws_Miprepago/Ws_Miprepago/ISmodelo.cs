using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WS_MiPrepago.Dominio;
using WS_MiPrepago.Errores;

namespace WS_MiPrepago
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISmodelo" in both code and config file together.
    [ServiceContract]
    public interface ISmodelo
    {
        [FaultContract(typeof(ModeloRepetidoException))]
        [OperationContract]
        Modelo crearModelo(Modelo marcaACrear);

        [OperationContract]
        Modelo obtenerModelo(int Id);

        [OperationContract]
        List<Modelo> listarModelo();
    }
}
