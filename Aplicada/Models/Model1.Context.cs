﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aplicada.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities1 : DbContext
    {
        public Entities1()
            : base("name=Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Marca> Marcas { get; set; }
        public virtual DbSet<Modelo> Modelos { get; set; }
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<ServiciosProducto> ServiciosProductos { get; set; }
        public virtual DbSet<Estado> Estados { get; set; }
        public virtual DbSet<Ordene> Ordenes { get; set; }
        public virtual DbSet<OrdenesEstado> OrdenesEstados { get; set; }
        public virtual DbSet<OrdenesServicio> OrdenesServicios { get; set; }
        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<ServiciosModelo> ServiciosModelos { get; set; }
        public virtual DbSet<Servicio> Servicios { get; set; }
        public virtual DbSet<Vehiculo> Vehiculos { get; set; }
    }
}
