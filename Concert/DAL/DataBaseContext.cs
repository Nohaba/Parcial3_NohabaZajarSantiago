using Concert.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Concert.DAL
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ticket>().HasIndex(c => c.Id).IsUnique();
        }

        //Convierte clase  Ticket en una tabla de BD 
        public DbSet<Ticket> Tickets { get; set; }

    }
}
