using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyectofinal2.ViewModels
{
    public class CatSub
    {
        public IEnumerable<Proyectofinal2.Models.Menajes_db.Categoria> Categoria { get; set; }
        public IEnumerable<Proyectofinal2.Models.Menajes_db.Subcategoria> Subcategoria { get; set; }
    }
}