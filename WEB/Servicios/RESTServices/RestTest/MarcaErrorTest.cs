using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;

namespace RestTest
{
    /// <summary>
    /// Summary description for MarcaErrorTest
    /// </summary>
    [TestClass]
    public class MarcaErrorTest
    {

        [TestMethod]
        public void MarcaError()
        {
            // Prueba de creación de Marca vía HTTP POST
            string postdata = "{\"Id\":\"1\",\"nombre\":\"Google\",\"estado\":\"ACTIVO\"}"; //JSON
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://localhost:12855/Marcas.svc/marca");
            req.Method = "POST";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";
            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            HttpWebResponse res = null;
            try {
                res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string MarcaJson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Marca MarcaCreado = js.Deserialize<Marca>(MarcaJson);
                Assert.AreEqual(3, MarcaCreado.Id);
                Assert.AreEqual("Motorola", MarcaCreado.nombre);
            }catch(WebException e){
                HttpStatusCode code = ((HttpWebResponse)e.Response).StatusCode;
                string message = ((HttpWebResponse)e.Response).StatusDescription;
                StreamReader reader = new StreamReader(e.Response.GetResponseStream());
                string error = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                string mensaje = js.Deserialize<string>(error);
                Assert.AreEqual("Esa Marca no se acepta", mensaje);
            }

        }

    }
}
