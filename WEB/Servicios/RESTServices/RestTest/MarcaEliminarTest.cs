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
    /// Summary description for MarcaEliminarTest
    /// </summary>
    [TestClass]
    public class MarcaEliminarTest
    {
        [TestMethod]
        public void EliminarOk()
        {

            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://localhost:12855/Marcas.svc/marca/2");
            req.Method = "DELETE";
            req.ContentType = "application/json";
            var reqStream = req.GetRequestStream();
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();

            HttpWebRequest req2 = (HttpWebRequest)WebRequest
                .Create("http://localhost:12855/Marcas.svc/marca/2");
            req2.Method = "GET";
            HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
            StreamReader reader2 = new StreamReader(res2.GetResponseStream());
            string MarcaJson2 = reader2.ReadToEnd();
            JavaScriptSerializer js2 = new JavaScriptSerializer();
            Marca MarcaObtenido = js2.Deserialize<Marca>(MarcaJson2);
            Assert.AreEqual(null, MarcaObtenido);
            
        }
    }
}
