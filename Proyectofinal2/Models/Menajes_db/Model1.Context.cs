﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MenajedbEntities : DbContext
    {
        public MenajedbEntities()
            : base("name=MenajedbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Banco_menaje> Banco_menaje { get; set; }
        public DbSet<Carrito> Carrito { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Debito> Debito { get; set; }
        public DbSet<Despacho> Despacho { get; set; }
        public DbSet<Direccion> Direccion { get; set; }
        public DbSet<Mensaje_consulta> Mensaje_consulta { get; set; }
        public DbSet<Metodo_pago> Metodo_pago { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Subcategoria> Subcategoria { get; set; }
        public DbSet<Table> Table { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Ventas> Ventas { get; set; }
    }
}