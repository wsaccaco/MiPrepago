using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSite.Models;
using Newtonsoft.Json;
namespace WebSite.Controllers
{
    public class SolicitudController : Controller
    {
        // GET: Solicitud
        S_MiPrepago_Proveedor_Rest.ProveedorServiceClient p = new S_MiPrepago_Proveedor_Rest.ProveedorServiceClient();
        S_MiPrepago_Proveedor_Rest.Reserva reserva_s = new S_MiPrepago_Proveedor_Rest.Reserva();
        public ActionResult Solicitud(string marca,string modelo)
        {
            
            
            Proveeedor prov = new Proveeedor();
            Model_Proveedor m_pro = new Model_Proveedor();
            m_pro.ListaProveedor = new List<Proveeedor>();
            var dato = p.consultarDisponibilidad(marca, modelo).ToList();
            foreach (var r in dato) {
                
                prov = new Proveeedor
                {
                    id=r.id,
                    marca_id=r.marcaId,
                    nombre =r.nombre,
                    precio=r.precio,
                    proveedor=r.proveedor,
                    stock=r.stock,
                    proveedor_id=r.proveedor_id
                   
                };
                m_pro.ListaProveedor.Add(prov);
            }
            return View(m_pro);
         }
        public ActionResult Reserva(string dato)
        {
            var resultado = JsonConvert.DeserializeObject<dynamic>(dato);
            int total = resultado.Count;
            foreach (var r in resultado) {
                //reserva re = new reserva();
                reserva_s.nombre = r.nombre.Value;
                reserva_s.apellido = r.apellidos.Value;
                reserva_s.email = r.email.Value;
                reserva_s.celular = r.celular.Value;
                reserva_s.cantidad =Convert.ToInt32( r.cantidad.Value);
                reserva_s.modeloId = r.modelo_id;
                reserva_s.proveedor_id = r.proveedor_id;
            }
            var res = p.crearReserva(reserva_s);
            string datos_de_reserva = "Puede ir a su proveedor " + res.proveedor + " a recoger su equipo, tiene dos dias y su codigo es " + res.codigoReserva;
            return Content(JsonConvert.SerializeObject(datos_de_reserva), "application/json");
        }


        public ActionResult Index()
        {
            return View();
        }

        // GET: Solicitud/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Solicitud/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Solicitud/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Solicitud/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Solicitud/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Solicitud/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Solicitud/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
