using System.Collections.Generic;
using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Establiment> Establiments { get; set; }
        public DbSet<Treballador> Treballadors { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Ubicacio> Ubicacions { get; set; }
        public DbSet<BlockFeina> BlocksFeina { get; set; }
        public DbSet<BlockHores> BlocksHores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuració de la relació Event -> Establiment sense cascada
            modelBuilder.Entity<Event>()
                .HasOne(e => e.Establiment)
                .WithMany()
                .HasForeignKey(e => e.EstablimentId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
