using Proyectofinal2.Models.Menajes_db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyectofinal2.Models.DAL
{
    public class ProductoDAL
    {

        public bool IngresarProducto (Producto p)
        {
            try
            {
                      MenajedbEntities ctx = new MenajedbEntities();
     
                ctx.Producto.Add(p);
                ctx.SaveChanges();


                return true;
            }
            catch (Exception e)
            {
                
                return false;
                
            }
        }
    
    
    }


    
}