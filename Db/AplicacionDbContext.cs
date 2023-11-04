using Db.Modelo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db
{
    public class AplicacionDbContext : DbContext
    {

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
                optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=gestorBibliotecaCodeFirst;User Id=postgres;Password=Juanccaaa1992; SearchPath=public ");
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración de la relación entre Autores y Libros (muchos a muchos)
            modelBuilder.Entity<Autores>()
                .HasMany(a => a.Libros)
                .WithMany(l => l.Autores)
                .UsingEntity(j => j.ToTable("Rel_Autores_Libros"));

            // Otras configuraciones de tus relaciones aquí, si es necesario

            modelBuilder.Entity<Prestamos>()
               .HasMany(a => a.collectionLibro)
               .WithMany(l => l.Prestamos)
               .UsingEntity(j => j.ToTable("Rel_Libros_Prestamos"));



            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Autores> Autores { get; set; }
        public DbSet<Libros> Libros { get; set; }
        public DbSet<Editoriales> Editoriales { get; set; }
        public DbSet<Generos> Generos { get; set; }
        public DbSet<Colecciones> Colecciones { get; set; }
        public DbSet<Prestamos> Prestamos { get; set; }
        public DbSet<Estamos_Prestamo> estamos_Prestamos { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Accesos> Accesos { get; set; }

       

    }
}
