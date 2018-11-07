using Microsoft.EntityFrameworkCore;

namespace Lab5Proj
{
    public class ApplicationContext: DbContext
    {
        public DbSet<City> Cities { get;  set; }
        public DbSet<POI> POIs { get;  set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().Property(c => c.Name).IsRequired();
            modelBuilder.Entity<City>().Property(c => c.Description).IsRequired().HasMaxLength(150);


            modelBuilder.Entity<POI>().Property(p => p.Name).IsRequired();
            modelBuilder.Entity<POI>().Property(p => p.Description).IsRequired().HasMaxLength(150);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=YourDatabaseName;Trusted_Connection=True;");
            }
        }
    }
}
