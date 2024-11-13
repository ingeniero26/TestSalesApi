using Microsoft.EntityFrameworkCore;
using OrderTest.Shared.Entities;

namespace OrderTest.Backend.Data
{
    // conexion a base de datos
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Country> countries { get; set; }
        public DbSet<Brand> brands { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(x => x.Name).IsUnique();
        }
    }
}