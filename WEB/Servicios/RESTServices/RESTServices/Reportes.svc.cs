using IronSharp.Core;
using IronSharp.IronMQ;
using RESTServices.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RESTServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Reportes" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Reportes.svc o Reportes.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Reportes : IReportes
    {
        public List<Reporte> ListarErrores()
        {
            //Install-Package Iron.IronMQ -Pre

            List<Reporte> ListReserva = new List<Reporte>();

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
            QueueInfo d = queue.Info();

            MessageCollection message = queue.Reserve(d.Size);

            foreach (var msg in message.Messages)
            {
                string[] data = msg.Body.Split('|');
                Reporte ReporteNew = new Reporte();
                ReporteNew.proveedor = data[0];
                ReporteNew.ruta = data[1];
                ReporteNew.fecha = data[2];
                ReporteNew.marca = data[3];
                ReporteNew.modelo = data[4];
                ListReserva.Add(ReporteNew);
                //msg.Delete();
            }

            return ListReserva;
        }
    }
}
