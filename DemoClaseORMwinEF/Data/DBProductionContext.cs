using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DemoClaseORMwinEF.Models;

namespace DemoClaseORMwinEF.Data
{
    public class DBProductionContext:DbContext
    {
        public DBProductionContext() : base("keyDBProduction") {}

        // por cada modelo una propiedad DBSET
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeDetail> EmployeesDetails { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder); 

            //Configuración mapeo con FLUENT API

            //PK
            modelBuilder.Entity<Empleado>().HasKey(e => e.SID);

            //Campo obligatorio
            modelBuilder.Entity<Empleado>().Property(e => e.Nombre).IsRequired();

            //Tipo de dato
            modelBuilder.Entity<Empleado>().Property(e => e.Nombre).HasColumnType("varchar");

            //Longitud de la cadena
            modelBuilder.Entity<Empleado>().Property(e => e.Nombre).HasMaxLength(50);

            //Nombre tabla
            modelBuilder.Entity<Empleado>().ToTable("Empleado");




        }

    }
}
