using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SaleOfMoviesTickets.Entities;

namespace SaleOfMoviesTickets
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SalasButacas>().HasKey(x => new { x.ButacaId, x.SalaId });
            modelBuilder.Entity<AuditoriosSalas>().HasKey(x => new { x.AuditorioId, x.SalaId });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Auditorio> Auditorios { get; set; }
        public DbSet<Sala> Salas { get; set; }
        public DbSet<Butaca> Butacas { get; set; }
        public DbSet<SalasButacas> SalasButacas { get; set; }
        public DbSet<AuditoriosSalas> AuditoriosSalas { get; set; }
    }
}
