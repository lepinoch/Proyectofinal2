//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyectofinal2.Models.Menajes_db
{
    using System;
    using System.Collections.Generic;
    
    public partial class Banco_menaje
    {
        public Banco_menaje()
        {
            this.Debito = new HashSet<Debito>();
        }
    
        public string Num_cuenta { get; set; }
        public string Nom_banco { get; set; }
        public string Tipo_cuenta { get; set; }
        public string Nombre_titular { get; set; }
    
        public virtual ICollection<Debito> Debito { get; set; }
    }
}
