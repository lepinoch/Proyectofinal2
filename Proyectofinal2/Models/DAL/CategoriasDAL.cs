using Proyectofinal2.Models.Menajes_db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyectofinal2.Models.DAL
{
    public class CategoriasDAL
    {
        public bool IngresarCategoria(Categoria c)
        {
            
            try
            {
                MenajedbEntities1 ctx = new MenajedbEntities1();

                ctx.Categoria.Add(c);
                ctx.SaveChanges();


                return true;
            }
            catch (Exception )
            {

                return false;

            }
        }


        public List<Categoria> listar()
        {
            MenajedbEntities1 ctx = new MenajedbEntities1();
            var lista = (from o in ctx.Categoria
                         select o).ToList();
            return lista;
        }

 
     




    }
}