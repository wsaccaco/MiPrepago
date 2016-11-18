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
   
    [ServiceContract]
    public interface IMarcas
    {
        [OperationContract]
        [WebInvoke(Method="POST", UriTemplate="marca", ResponseFormat=WebMessageFormat.Json)]
        Marca crearMarca(Marca MarcaACrear);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "marca/{Id}", ResponseFormat = WebMessageFormat.Json)]
        Marca ObtenerMarca(string Id);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "marca", ResponseFormat = WebMessageFormat.Json)]
        Marca ModificarMarca(Marca MarcaAModificar);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "marca/{Id}", ResponseFormat = WebMessageFormat.Json)]
        void EliminarMarca(string Id);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "marca", ResponseFormat = WebMessageFormat.Json)]
        List<Marca> ListarMarcas();
    }
}
