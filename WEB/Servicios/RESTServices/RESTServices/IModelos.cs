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
    public interface IModelos
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "modelo/marca/{nombre}", ResponseFormat = WebMessageFormat.Json)]
        List<Modelo> ListarModelos(string nombre);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "modelo/{nombreModelo}/marca/{nombreMarca}", ResponseFormat = WebMessageFormat.Json)]
        List<Modelo> ListarModelo(string nombreModelo, string nombreMarca);
    }
}
