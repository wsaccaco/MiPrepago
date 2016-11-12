using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Services;
using WS_MiPrepago.Dominio;
using WS_MiPrepago.Errores;

namespace WS_MiPrepago
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IPerdidas" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IMarcas
    {
        [FaultContract(typeof(RepetidoException))]
        [OperationContract]
        Marca crearMarca(Marca marcaACrear);

        [OperationContract]
        Marca ObtenerMarca(int Id);

        [OperationContract]
        [WebInvoke(Method = "*")]
        List<Marca> listarMarca();

        [OperationContract]
        string calcular(int number);
    }
}
