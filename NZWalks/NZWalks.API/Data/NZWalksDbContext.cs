using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    public class NZWalksDbContext : DbContext
    {
        public NZWalksDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) 
        {
            
        }

        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var difficulties = new List<Difficulty>()
            {
                new Difficulty()
                {
                    Id = Guid.Parse("dce0b3ae-f57d-4cce-9425-fde015e2c7b5"),
                    Name = "Easy",
                },
                new Difficulty()
                {
                    Id = Guid.Parse("9163de00-a8e3-4b2f-af26-dd536b1d59cb"),
                    Name = "Medium",
                },
                new Difficulty()
                {
                    Id = Guid.Parse("f8ed408d-2969-4aba-a93f-fb4cf17b19db"),
                    Name = "Hard",
                }
            };

            modelBuilder.Entity<Difficulty>().HasData(difficulties);

            var regions = new List<Region>()
            {
                new Region()
                {
                    Id = Guid.Parse("f8ed408d-2969-4aba-a93f-fb4cf17b19db"),
                    Name = "Auckland",
                    Code = "AKL",
                    RegionImageUrl = "https://images.app.goo.gl/a68tjnGNah5b9bdVA",
                },
                new Region()
                {
                    Id = Guid.Parse("6647e810-48d2-497d-b241-dba58edcf80c"),
                    Name = "Northland",
                    Code = "AKL",
                    RegionImageUrl = "https://images.app.goo.gl/WhFEsqvb9fcf543J8",
                },
                new Region()
                {
                    Id = Guid.Parse("36809860-36b9-426b-b6ee-16f7bab876c9"),
                    Name = "Bay Of Plenty",
                    Code = "BOP",
                    RegionImageUrl = "https://images.app.goo.gl/qGgEnHCn1fnjriic6",
                },
                new Region()
                {
                    Id = Guid.Parse("276a7602-ceb8-4700-997a-0f9a7b14ae24"),
                    Name = "Wellington",
                    Code = "WGN",
                    RegionImageUrl = "https://images.app.goo.gl/HAk8CB4PWHJRCzkT8",
                },
                new Region()
                {
                    Id = Guid.Parse("6ca36f10-d705-4ace-b903-8cdb01532f70"),
                    Name = "Nelson",
                    Code = "NSN",
                    RegionImageUrl = "https://images.app.goo.gl/JvLtU9r7EjnRgZ5CA",
                },
                new Region()
                {
                    Id = Guid.Parse("ff4e4220-d272-423d-8527-5c583211ba4a"),
                    Name = "Southland",
                    Code = "STL",
                    RegionImageUrl = "https://images.app.goo.gl/ZR3tV6Spoi8YZK9Y6",
                },
            };

            modelBuilder.Entity<Region>().HasData(regions);
        }
    }
}
