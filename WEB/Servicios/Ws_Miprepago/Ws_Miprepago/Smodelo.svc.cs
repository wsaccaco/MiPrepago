using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Script.Serialization;
using WS_MiPrepago.Dominio;
using WS_MiPrepago.Errores;
using WS_MiPrepago.Persistencia;

namespace WS_MiPrepago
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Smodelo" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Smodelo.svc or Smodelo.svc.cs at the Solution Explorer and start debugging.
    public class Smodelo : ISmodelo
    {
        private ModeloDAO modeloDAO = new ModeloDAO();

        public string calcular(int number)
        {
            Tools tools = new Tools();
            return tools.calcular(number);
        }

        public Modelo crearModelo(Modelo modeloCrear)
        {
            if (modeloDAO.obtener(modeloCrear.modelo_id) != null)
            {
                throw new FaultException<ModeloRepetidoException>(
                    new ModeloRepetidoException()
                    {
                        modelo_id = "101",
                        nombre = "error",
                        marca_marca_id = "1"
                    }, new FaultReason("error por una razon"));
            }
            return modeloDAO.crear(modeloCrear);
        }

    

        public List<Modelo> listarModelo()
        {
            return modeloDAO.Listar();
        }

        public Modelo obtenerModelo(int Id)
        {
 
            return modeloDAO.obtener(Id);
        }
        public List<Modelo> Listar_ModeloxMarca(int id)
        {

            return modeloDAO.Listar_ModeloxMarca(id);
        }
        public List<Modelo> Listado_ModeloxMarca_Proveedor(string nombre) {
            
           
            String[] filtros = { "Google", "Microsoft" };
            if (Array.IndexOf(filtros, nombre) > -1)
            {
                throw new FaultException<ExceptionGeneral>(
                    new ExceptionGeneral()
                    {
                        codigo = "1",
                        descripcion = "Error 404"
                    }, new FaultReason("No se aceptan estas marcas"));
            }

            HttpWebRequest req2 = (HttpWebRequest)WebRequest
               .Create("http://localhost:12855/Modelos.svc/modelo/marca/"+ nombre);
            req2.Method = "GET";
            HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
            StreamReader reader2 = new StreamReader(res2.GetResponseStream());
            string ModeloJson2 = reader2.ReadToEnd();

            List<Modelo> list = new List<Modelo>();
            Modelo mo = new Modelo();
            var resultado = JsonConvert.DeserializeObject<dynamic>(ModeloJson2);
            int total = resultado.Count;
            if (total > 0)
            {
                foreach (var r in resultado) {
                    mo = new Modelo
                    {
                        modelo_id = r.id,
                        nombre = r.nombre,
                        fec_fab = r.anio
                    };
                    list.Add(mo);

                }
            }
            //Tuple<List<Modelo>, string> t = new Tuple<List<Modelo>, string>(list, "");
            

            //JavaScriptSerializer js2 = new JavaScriptSerializer();
            //Modelo MarcaObtenido = js2.Deserialize<Modelo>(ModeloJson2);

            return list;
        }

    }
   
}
