using Proyectofinal2.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyectofinal2.Controllers.db_subcategoria
{
    public class SubcategoriaController : Controller
    {
        //
        // GET: /Subcategoria/
        public ActionResult Listar(int Id_categoria)
        {
            SubcategoriaDAL DAL = new SubcategoriaDAL();
            ViewBag.Subcategorias = DAL.Listar_sub(Id_categoria);
            return View();
        }



        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Subcategoria/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Subcategoria/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Subcategoria/Create

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

        //
        // GET: /Subcategoria/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Subcategoria/Edit/5

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

        //
        // GET: /Subcategoria/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Subcategoria/Delete/5

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
