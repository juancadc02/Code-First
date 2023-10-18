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

        public DbSet<LibrosDal> librosDals { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
                optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=gestorBiblioteca;User Id=postgres;Password=Juanccaaa1992; SearchPath=public ");
           
        }
    }
}
