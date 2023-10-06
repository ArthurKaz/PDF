using Microsoft.EntityFrameworkCore;
using PDFOfferCreator.Model;
using System.Reflection;

namespace PDFOfferCreator.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        public DbSet<OfferData> OfferData { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Employee Table
            modelBuilder.Entity<OfferData>().HasData(new OfferData(1, "John", "Doe", "City1", "Street1", ModuleType.JinkoSolar, BatteryStorage.FivekWh));

        }
    }
}
