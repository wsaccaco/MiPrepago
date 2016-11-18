using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RESTServices.Dominio;
using RESTServices.Persistencia;

namespace RESTServices
{
    public class Modelos : IModelos
    {
        private ModeloDAO dao = new ModeloDAO();
        public List<Modelo> ListarModelos(string nombre)
        {
            return dao.ListarModelos(nombre);
        }

        public List<Modelo> ListarModelo(string nombreModelo, string nombreMarca)
        {
            return dao.ListarModelo(nombreModelo, nombreMarca);
        }
    }
}
