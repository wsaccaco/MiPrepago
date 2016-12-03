using IronSharp.Core;
using IronSharp.IronMQ;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Script.Serialization;
using WS_MiPrepago.Dominio;
using WS_MiPrepago.Persistencia;

namespace WS_MiPrepago
{
    public class ProveedorService : IProveedorService
    {
        private ProveedorDAO proveedorDAO = new ProveedorDAO();
        private ReservaDAO reservaDAO = new ReservaDAO();
        public List<ModeloProveedor> consultarDisponibilidad(string marca, string modelo)
        {

            List<ModeloProveedor> list = new List<ModeloProveedor>();

            foreach (var pro in proveedorDAO.Listar()) {

                try {

                    HttpWebRequest req2 = (HttpWebRequest)WebRequest
                       .Create(pro.ruta + modelo + "/marca/" + marca);
                    req2.Method = "GET";
                    HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
                    StreamReader reader2 = new StreamReader(res2.GetResponseStream());
                    string ModeloJson2 = reader2.ReadToEnd();

                    ModeloProveedor mo = new ModeloProveedor();
                    var resultado = JsonConvert.DeserializeObject<dynamic>(ModeloJson2);
                    int total = resultado.Count;
                    if (total > 0)
                    {
                        foreach (var r in resultado)
                        {
<<<<<<< HEAD
                            id = r.id,
                            anio = r.anio,
                            nombre = r.nombre,
                            precio = r.precio,
                            stock = r.stock,
                            marcaId = r.marcaId,
                            proveedor = pro.nombre,
                            proveedor_id=pro.proveedor_id,
                           
                        };
                        list.Add(mo);
=======
                            mo = new ModeloProveedor
                            {
                                id = r.id,
                                anio = r.anio,
                                nombre = r.nombre,
                                precio = r.precio,
                                stock = r.stock,
                                marcaId = r.marcaId,
                                proveedor = pro.nombre,
                                proveedor_id = pro.proveedor_id
                            };
                            list.Add(mo);
>>>>>>> 34d84d5a0db0b65f074c8a028447a11f014ee5c7

                        }
                    }

                }
                catch (WebException e) {
                    // Install-Package Iron.IronMQ -Pre
                    var ironMq = IronSharp.IronMQ.Client.New(
                        new IronClientConfig
                        {
                            ProjectId = "583f91c0d9cc19000737b89d",
                            Token = "MfA9AIYOrPzopPYkR6vC",
                            Host = "mq-aws-eu-west-1-1.iron.io",
                            Scheme = "http",
                            Port = 80
                        });

                    var queues = ironMq.Queues();

                    foreach (var queueInfo in queues)
                        Console.WriteLine(queueInfo.Name);

                    QueueClient queue = ironMq.Queue("colanew");
                    string messageId = queue.Post(pro.nombre + "|" + pro.ruta+ "|"+ DateTime.Now.ToString()+ "|" + marca + "|" + modelo);
                    QueueMessage message = queue.Reserve();
                    Console.WriteLine(message.Body);
                    Console.WriteLine(message.ReservationId);
                }

            }
            
            return list;
        }

        public Reserva crearReserva(Reserva reservaAllegar)
        {

            Reserva reservaAMostrar = new Reserva();
            string postdata = "{\"cantidad\": "+ reservaAllegar.cantidad + ", \"modeloId\": "+reservaAllegar.modeloId + " }"; //JSON
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
            ReservaProveedor ReservaCreado = js.Deserialize<ReservaProveedor>(MarcaJson);


            reservaAMostrar = reservaDAO.crear(reservaAllegar);
            reservaAMostrar.codigoReserva = ReservaCreado.codigoReserva;
            return reservaAMostrar;
        }
    }
}
