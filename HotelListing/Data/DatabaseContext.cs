using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "India",
                    ShortName = "IN"
                },
                new Country
                {
                    Id = 2,
                    Name = "Canada",
                    ShortName = "CA"
                },
                new Country
                {
                    Id = 3,
                    Name = "United States of America",
                    ShortName = "USA"
                }
                );
            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Taj Banjara",
                    Address = "Jubliee Hills",
                    CountryId=1,
                    Rating=5.0

                },
                new Hotel
                {
                    Id = 2,
                    Name = "Embassy Suites",
                    Address = "Niagara Falls",
                    CountryId = 2,
                    Rating = 5.0
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Trump Suites",
                    Address = "Texas",
                    CountryId = 3,
                    Rating = 4.0
                }
                );
        }
    }
}
