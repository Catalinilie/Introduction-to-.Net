using Microsoft.EntityFrameworkCore;

namespace DataLayer.Data
{
    public class CityContext : DbContext
    {
        public CityContext(DbContextOptions<CityContext> options):base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<City> Cities { get; set; }
    }

    
}
