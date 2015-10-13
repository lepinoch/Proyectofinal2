using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyectofinal2.Controllers.db_producto
{
    public class ProductoController : Controller
    {
        //
        // GET: /Producto/

        [HttpGet]
        public ActionResult IngresoProducto()
        {
            return View();
        }

    }
}
