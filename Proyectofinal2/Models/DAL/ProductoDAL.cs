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
            catch (Exception )
            {
                
                return false;
                
            }
        }

        public List<Producto> listar()
        {
            MenajedbEntities ctx = new MenajedbEntities();
            var lista = (from o in ctx.Producto
                         select o).ToList();
            return lista;
        }

        
    
    
    }


    
}