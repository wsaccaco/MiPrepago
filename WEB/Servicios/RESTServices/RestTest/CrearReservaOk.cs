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
    public class CrearReservaOk
    {

        [TestMethod]
        public void ModificarOk()
        {

            string postdata = "{\"cantidad\":\"1\",\"modeloId\":1}"; //JSON
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://localhost:12855/Reservas.svc/reserva");
            req.Method = "POST";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";
            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string MarcaJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Reserva ReservaCreado = js.Deserialize<Reserva>(MarcaJson);
            Assert.AreEqual(1, ReservaCreado.cantidad);
            Assert.AreEqual(1, ReservaCreado.modeloId);

        }
    }
}
