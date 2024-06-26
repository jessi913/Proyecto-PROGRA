﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Proyecto_PROGRA.Models;

namespace Proyecto_PROGRA.Database
{
    public class ProyectoContext : DbContext

    {
        public ProyectoContext() : base("name=Proyecto")
        
        {
            
        }
      


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
        public DbSet<Categoría> Categoria { get; set; }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<CondicionPag> CondicionPag { get; set; }

        public DbSet<Factura> Factura { get; set; }

        public DbSet<FacturaDetalle> FacturaDetalle { get; set; }
        public DbSet<GrupoDescuento> GrupoDescuento { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<PedidoDetalle> PedidoDetalle { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<UnidadMedida> UnidadMedida { get; set; }

    }
}