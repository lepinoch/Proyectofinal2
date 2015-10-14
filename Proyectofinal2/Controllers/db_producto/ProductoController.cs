﻿using Proyectofinal2.Models.DAL;
using Proyectofinal2.Models.Menajes_db;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyectofinal2.Controllers.db_producto
{
    public class ProductoController : Controller
    {
        //
        // GET: /Producto/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Producto/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Producto/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Producto/Create
   
        [HttpPost]
        public ActionResult Create(FormCollection p)
        {
            try
            {
           
                MenajedbEntities ctx = new MenajedbEntities();
     
      

                Producto pro = new Producto();
           
                pro.Nombre = p["Nombre"];
                pro.Precio = Int16.Parse(p["Precio"]);
                pro.Stock = Int16.Parse(p["Stock"]);
                pro.Imagen = (p["Imagen"]);
                pro.Descripcion = (p["Descripcion"]);
                pro.Id_subcategoria = Int16.Parse(p["Id_subcategoria"]);
       
                ProductoDAL DAL = new ProductoDAL();
                if (ModelState.IsValid)
	{
		 
                DAL.IngresarProducto(pro);
               
	}
                



                return RedirectToAction("Index");

            }
            catch
            {
                return View("piconchetumare");
            }
        }


        




        //
        // GET: /Producto/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Producto/Edit/5

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
        // GET: /Producto/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Producto/Delete/5

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
