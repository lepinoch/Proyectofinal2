using Proyectofinal2.Models.Menajes_db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyectofinal2.Models.DAL
{
    public class SubcategoriaDAL
    {
        public List<Subcategoria> listar()
        {
            MenajedbEntities1 ctx = new MenajedbEntities1();
            var lista = (from o in ctx.Subcategoria
                         select o).ToList();
            return lista;
        }



        // buscar por ciudad
        public String Listar_sub(int Id_categoria)
        {
            MenajedbEntities1 ctx = new MenajedbEntities1();
            var a = (from o in ctx.Subcategoria where o.Id_categoria == Id_categoria select o.Nombre).ToString();
            return a;
        }
    }
}