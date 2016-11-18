using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;

namespace RestTest
{

    [TestClass]
    public class MarcasTest
    {

        [TestMethod]
        public void CRUDTest()
        {
            // Prueba de creación de Marca vía HTTP POST
            string postdata = "{\"Id\":\"3\",\"nombre\":\"Motorola\",\"estado\":\"ACTIVO\"}"; //JSON
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://localhost:12855/Marcas.svc/Marcas");
            req.Method = "POST";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";
            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string MarcaJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Marca MarcaCreado = js.Deserialize<Marca>(MarcaJson);
            Assert.AreEqual(3, MarcaCreado.Id);
            Assert.AreEqual("Motorola", MarcaCreado.nombre);

            // Prueba de obtención de Marca vía HTTP GET
            HttpWebRequest req2 = (HttpWebRequest)WebRequest
                .Create("http://localhost:12855/Marcas.svc/Marcas/3");
            req2.Method = "GET";
            HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
            StreamReader reader2 = new StreamReader(res2.GetResponseStream());
            string MarcaJson2 = reader2.ReadToEnd();
            JavaScriptSerializer js2 = new JavaScriptSerializer();
            Marca MarcaObtenido = js2.Deserialize<Marca>(MarcaJson2);
            Assert.AreEqual(3, MarcaObtenido.Id);
            Assert.AreEqual("Motorola", MarcaObtenido.nombre);
        }
    }
}
