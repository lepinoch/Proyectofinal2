using Proyectofinal2.Models.Menajes_db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyectofinal2.Models.DAL
{
    public class ContactoDAL
    {



        public bool IngresarContacto (Contacto con)
    {


        try
        {
            MenajedbEntities1 ctx = new MenajedbEntities1();
            ctx.Contacto.Add(con);
            ctx.SaveChanges();

            return true;
        }
        catch (Exception)
        {

            return false;
        }
    }
    }
}