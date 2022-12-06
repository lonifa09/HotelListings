using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListings.Data
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    ID = 1,
                    Name = "Jamaica",
                    ShortName = "JM"
                },
                new Country
                {
                    ID = 2,
                    Name = "Bahamas",
                    ShortName = "BS"
                },
                new Country
                {
                    ID = 3,
                    Name = "Cayman Island",
                    ShortName = "CI"
                }
                );


            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    ID = 1,
                    Name = "Sandals Resourte and Spar",
                    Address = "Nigreal",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    ID = 2,
                    Name = "Comfort Suites",
                    Address = "Nigreal",
                    CountryId = 2,
                    Rating = 3
                },
                new Hotel
                {
                    ID = 3,
                    Name = "Grand West",
                    Address = "Nigaras",
                    CountryId = 3,
                    Rating = 4.3
                }
                );
        }

    }
}
