using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Text;
using System.IO;
using System.Web.Script.Serialization;

namespace RestTest
{
    [TestClass]
    public class CrearReservaError
    {
        [TestMethod]
        public void MarcaError()
        {
            string postdata = "{\"cantidad\":\"10000\",\"modeloId\":1}"; //JSON
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://localhost:12855/Reservas.svc/reserva");
            req.Method = "POST";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";
            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            HttpWebResponse res = null;
            try
            {
                res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string MarcaJson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Reserva ReservaCreado = js.Deserialize<Reserva>(MarcaJson);
                Assert.AreEqual(1, ReservaCreado.modeloId);
                Assert.AreEqual(10000, ReservaCreado.cantidad);
            }
            catch (WebException e)
            {
                HttpStatusCode code = ((HttpWebResponse)e.Response).StatusCode;
                string message = ((HttpWebResponse)e.Response).StatusDescription;
                StreamReader reader = new StreamReader(e.Response.GetResponseStream());
                string error = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                string mensaje = js.Deserialize<string>(error);
                Assert.AreEqual("Stock Insuficiente", mensaje);
            }

        }
    }
}
