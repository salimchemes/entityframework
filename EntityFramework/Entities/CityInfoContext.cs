using System;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Entities
{
    public class CityInfoContext : DbContext
    {
        public CityInfoContext(DbContextOptions<CityInfoContext> options)
            : base()
        {
            Database.EnsureCreated();
        }

        public DbSet<City> City { get; set; }
        public DbSet<PointOfInterest> PointOfInterests { get; set; }

    }
}
