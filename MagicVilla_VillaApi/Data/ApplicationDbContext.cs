using MagicVilla_VillaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Villa> Villas { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {     }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Vila 1",
                    Details = "New World",
                    ImageUrl = "/folder1/folder2/pic",
                    Occupancy = 5,
                    Rate = 200,
                    Sqft = 550,
                    Amenity = "Test 1",
                    CreatedDate = DateTime.Now,
                },
                new Villa()
                {
                    Id = 2,
                    Name = "Vila 2",
                    Details = "New Earth",
                    ImageUrl = "/folder3/folder4/pi2",
                    Occupancy = 4,
                    Rate = 300,
                    Sqft = 520,
                    Amenity = "Test 2",
                    CreatedDate = DateTime.Now,

                },
                new Villa()
                {
                    Id = 3,
                    Name = "Villa 3",
                    Details = "New Jupiter",
                    ImageUrl = "/folder4/folder5/pic3",
                    Occupancy = 6,
                    Rate = 300,
                    Sqft = 650,
                    Amenity = "Test 3",
                    CreatedDate = DateTime.Now,

                }
                );

        }
    }
}
