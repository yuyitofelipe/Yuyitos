﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YUYITOS.Datos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ABONO_FIADO> ABONO_FIADO { get; set; }
        public DbSet<BOLETA> BOLETA { get; set; }
        public DbSet<CIUDAD> CIUDAD { get; set; }
        public DbSet<CLIENTE> CLIENTE { get; set; }
        public DbSet<CLIENTE_FIADO> CLIENTE_FIADO { get; set; }
        public DbSet<DETALLE_BOLETA> DETALLE_BOLETA { get; set; }
        public DbSet<DETALLE_ORDEN> DETALLE_ORDEN { get; set; }
        public DbSet<DETALLE_RECEPCION> DETALLE_RECEPCION { get; set; }
        public DbSet<DETALLE_STOCK> DETALLE_STOCK { get; set; }
        public DbSet<FAMILIA> FAMILIA { get; set; }
        public DbSet<ORDEN> ORDEN { get; set; }
        public DbSet<PRODUCTO> PRODUCTO { get; set; }
        public DbSet<PROVEEDOR> PROVEEDOR { get; set; }
        public DbSet<RECEPCION> RECEPCION { get; set; }
        public DbSet<STOCK> STOCK { get; set; }
        public DbSet<TIPO_ALIMENTO> TIPO_ALIMENTO { get; set; }
        public DbSet<TIPO_PRODUCTO> TIPO_PRODUCTO { get; set; }
        public DbSet<TIPO_USUARIO> TIPO_USUARIO { get; set; }
        public DbSet<USUARIO> USUARIO { get; set; }
    }
}
