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
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void ModificarOk()
        {

            string postdata = "{\"Id\":\"1\",\"nombre\":\"Huawei\",\"estado\":\"ACTIVO\"}"; //JSON
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://localhost:12855/Marcas.svc/Marcas");
            req.Method = "PUT";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";
            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string MarcaJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Marca MarcaCreado = js.Deserialize<Marca>(MarcaJson);
            Assert.AreEqual(1, MarcaCreado.Id);
            Assert.AreEqual("Huawei", MarcaCreado.nombre);

        }
    }
}
