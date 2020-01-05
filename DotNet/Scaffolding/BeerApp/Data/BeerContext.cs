using Microsoft.EntityFrameworkCore;
namespace BeerApp.Data
{
    public class BeerContext : DbContext
    {
        public DbSet<BeerApp.Models.Beer> Beers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=beers.db");
        }
    }
}