using RESTServices.Dominio;
using RESTServices.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RESTServices
{
    public class Marcas : IMarcas
    {
        private MarcaDAO dao = new MarcaDAO();

        public Marca crearMarca(Marca MarcaACrear)
        {
            String[] filtros = { "Google", "Motorola", "Microsoft" };
            if (Array.IndexOf(filtros, MarcaACrear.nombre)>-1)
            {
                throw new WebFaultException<string>("Esa Marca no se acepta", HttpStatusCode.Conflict);
            }
            return dao.crear(MarcaACrear);
        }

        public Marca ObtenerMarca(string Id)
        {
            int Idx = Int32.Parse(Id);
            return dao.obtener(Idx);
        }

        public Marca ModificarMarca(Marca MarcaAModificar)
        {
            return dao.modificar(MarcaAModificar);
        }

        public List<Marca> ListarMarcas()
        {
            return dao.Listar();
        }


        public void EliminarMarca(string Id)
        {
            int Idx = Int32.Parse(Id);
            dao.eliminar(Idx);
        }
    }
}
