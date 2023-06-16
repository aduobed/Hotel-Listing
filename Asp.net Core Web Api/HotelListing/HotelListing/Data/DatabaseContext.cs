using Microsoft.EntityFrameworkCore;

namespace HotelListing.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options) {}

        public DbSet<Country> Countries { get; set; }

        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Ghana",
                    ShortName = "GH",

                },
                new Country
                {
                    Id = 2,
                    Name = "Nigeria",
                    ShortName = "NG",

                },
                new Country
                {
                    Id = 3,
                    Name = "South Africa",
                    ShortName = "SA",

                }
                );

            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Sandals Resort",
                    Address = "Negril",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Chale Hotel",
                    Address = "Guinea",
                    CountryId = 2,
                    Rating = 4.0
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Amapiano Resort & Hotel",
                    Address = "Ksi",
                    CountryId = 3,
                    Rating = 2.5
                });
        }
    }
}
