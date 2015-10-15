﻿using Proyectofinal2.Models.DAL;
using Proyectofinal2.Models.Menajes_db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyectofinal2.Controllers.Home
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }


        //
        // GET: /Acerca/
        public ActionResult Acerca()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Acerca(FormCollection collection)
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
                
           
                //MenajedbEntities ctx = new MenajedbEntities();

                //Producto pro = new Producto();
           
                //pro.Nombre = p["Nombre"];
                //pro.Precio = Int16.Parse(p["Precio"]);
                //pro.Stock = Int16.Parse(p["Stock"]);
                //pro.Imagen = (p["Imagen"]);
                //pro.Descripcion = (p["Descripcion"]);
                //pro.Id_subcategoria = Int16.Parse(p["Id_subcategoria"]);
   
                //ProductoDAL DAL = new ProductoDAL();
                //if (ModelState.IsValid) 
                //DAL.IngresarProducto(pro);

                //return RedirectToAction("Index");




        //
        // GET: /Contacto/
        public ActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contacto(FormCollection c)
        {
            try
            {
                string n, a, e, m;
                n = c["Nombre"];
                a = c["Asunto"];
                e = c["Email"];
                m = c["Mensaje"];

                if (n != null && a != null && e != null && m != null)
                {
                    Contacto con = new Contacto();
                    ContactoDAL dal = new ContactoDAL();
                    con.Nombre = c["Nombre"];
                    con.Asunto = c["Asunto"];
                    con.Email = c["Email"];
                    con.Mensaje = c["Mensaje"];
                    dal.IngresarContacto(con);

                  
 
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }



        //









        // GET: /Home/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Home/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Home/Create

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
        // GET: /Home/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Home/Edit/5

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
        // GET: /Home/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Home/Delete/5

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
