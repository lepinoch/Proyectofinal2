using Proyectofinal2.Models.DAL;
using Proyectofinal2.Models.Menajes_db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyectofinal2.Controllers.db_categoria
{
    public class CategoriaController : Controller
    {
        //
        // GET: /Categoria/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Categoria/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Categoria/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Categoria/Create

        [HttpPost]
        public ActionResult Create(FormCollection p)
        {
            try
            {

                MenajedbEntities ctx = new MenajedbEntities();



                Categoria pro = new Categoria();

                pro.Id_categoria = Int16.Parse(p["Id_categoria"]);
                pro.Nombre_categoria = (p["Nombre_categoria"]);
                pro.Tipo = (p["Tipo"]);
                pro.Cantidad = Int16.Parse(p["Cantidad"]);
                
                
                CategoriasDAL DAL = new CategoriasDAL();
                if (ModelState.IsValid)
                {

                    DAL.IngresarCategoria(pro);

                }




                return RedirectToAction("Index");

            }
            catch
            {
                return View("piconchetumare");
            }
        }

        //
        // GET: /Categoria/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Categoria/Edit/5

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
        // GET: /Categoria/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Categoria/Delete/5

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
