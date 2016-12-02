using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSite.Controllers
{
    public class HomeController : Controller
    {
        S_MiPrepago_Marca.MarcasClient objc = new S_MiPrepago_Marca.MarcasClient();
        S_MiPrepago_Modelo.SmodeloClient objm = new S_MiPrepago_Modelo.SmodeloClient();
        // GET: Home
        public ActionResult Index()
        {
            var cbo_marca = objc.listarMarca();
            ViewBag.cbo_marca = new SelectList(cbo_marca, "marca_id", "nombre");
            return View();
        }
        public ActionResult Listar_ModelosxMarcas(int id)
        {
            var n = objm.Listar_ModeloxMarca(id);
            return Json(new
            {
                rows = n,
                msg = "",
                total = 0
            }, JsonRequestBehavior.AllowGet);
            //return View();
        }
        public ActionResult Listar_Marca_Proveedor(string nombre)
        {
            var n = objm.Listado_ModeloxMarca_Proveedor(nombre);
            return Json(new
            {
                rows = n,
                msg = "",
                total = 0
            }, JsonRequestBehavior.AllowGet);
            //return View();
        }
        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
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

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home/Edit/5
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

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home/Delete/5
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
