using Microsoft.EntityFrameworkCore;

namespace HotelListing.Data
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions options): base(options){}

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Karachi",
                    ShortName = "KH"
                },
                 new Country
                 {
                     Id = 2,
                     Name = "Lahore",
                     ShortName = "LH"
                 },
                 new Country
                 {
                     Id = 3,
                     Name = "Multan",
                     ShortName = "ML"
                 }
                );

            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "ABC",
                    Address = "123456",
                    Rating = 4,
                    CountryId = 1,
                },
                 new Hotel
                 {
                     Id = 2,
                     Name = "XYZ",
                     Address = "3214",
                     Rating= 2,
                     CountryId = 2
                 },
                 new Hotel
                 {
                     Id = 3,
                     Name = "LMN",
                     Address = "04532",
                     Rating = 3.2,
                     CountryId = 3
                 }
                );

        }
    }
}
