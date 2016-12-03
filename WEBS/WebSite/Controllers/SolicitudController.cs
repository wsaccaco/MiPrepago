using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSite.Models;
namespace WebSite.Controllers
{
    public class SolicitudController : Controller
    {
        // GET: Solicitud
        S_MiPrepago_Proveedor_Rest.ProveedorServiceClient p = new S_MiPrepago_Proveedor_Rest.ProveedorServiceClient();
       
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
                    stock=r.stock
                };
                m_pro.ListaProveedor.Add(prov);
            }
            return View(m_pro);
            //return View(new { Values = prov.ListaProveedor });
            //return View();

            //var prov= p.consultarDisponibilidad(marca, modelo);

            //return Json(new
            //{
            //    rows = prov,
            //    msg = "",
            //    total = 0
            //}, JsonRequestBehavior.AllowGet);
            //return View();
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
