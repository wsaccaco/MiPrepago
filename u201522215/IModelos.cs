using System;
using System.Collections.Generic;
using System.Linq;
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

    [ServiceContract]
    public interface IModelos
    {
        [FaultContract(typeof(RepetidoException))]
        [OperationContract]
        Marca crearModelo(Marca marcaACrear);

        [OperationContract]
        Marca obtenerModelo(int Id);

        [OperationContract]
        List<Marca> listarModelo();

    }
}