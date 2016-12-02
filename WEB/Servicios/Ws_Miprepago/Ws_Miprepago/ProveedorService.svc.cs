using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WS_MiPrepago.Dominio;

namespace WS_MiPrepago
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ProveedorService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ProveedorService.svc o ProveedorService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ProveedorService : IProveedorService
    {
        public List<ModeloProveedor> consultarDisponibilidad(string marca, string modelo)
        {
            HttpWebRequest req2 = (HttpWebRequest)WebRequest
               .Create("http://localhost:12855/Modelos.svc/modelo/"+ modelo + "/marca/"+ marca);
            req2.Method = "GET";
            HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
            StreamReader reader2 = new StreamReader(res2.GetResponseStream());
            string ModeloJson2 = reader2.ReadToEnd();

            List<ModeloProveedor> list = new List<ModeloProveedor>();
            ModeloProveedor mo = new ModeloProveedor();
            var resultado = JsonConvert.DeserializeObject<dynamic>(ModeloJson2);
            int total = resultado.Count;
            if (total > 0)
            {
                foreach (var r in resultado)
                {
                    mo = new ModeloProveedor
                    {
                        id = r.id,
                        anio = r.anio,
                        nombre = r.nombre,
                        precio = r.precio,
                        stock = r.stock,
                        marcaId = r.marcaId
                    };
                    list.Add(mo);

                }
            }






            //JavaScriptSerializer js2 = new JavaScriptSerializer();
            //Modelo MarcaObtenido = js2.Deserialize<Modelo>(ModeloJson2);

            return list;
        }

    }
}
