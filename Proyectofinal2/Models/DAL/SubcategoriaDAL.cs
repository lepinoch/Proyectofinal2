using Proyectofinal2.Models.Menajes_db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyectofinal2.Models.DAL
{
    public class SubcategoriaDAL
    {
        //       public List<Subcategoria> listar_sub(int Id_categoria)
        //{
        //    MenajedbEntities ctx = new MenajedbEntities();
        //    var listar = (from o in ctx.Categoria
        //                  join c in ctx.Subcategoria 
        //                  on o.Id_categoria 
        //                  equals c.Id_categoria
        //                  select c).ToList();

        //    return listar;
        //}



        // buscar por ciudad
        public String Listar_sub(int Id_categoria)
        {
            MenajedbEntities ctx = new MenajedbEntities();
            var a = (from o in ctx.Subcategoria where o.Id_categoria == Id_categoria select o.Nombre).ToString();
            return a;
        }
    }
}