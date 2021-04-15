using AsyncWeb.Models;
using AsyncWeb.Models.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncWeb.Data
{
    public class HotelDbContext : IdentityDbContext<ApplicationUser>
    {
        public HotelDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Amenities> Amenities { get; set; }

        public DbSet<Hotel> Hotels { get; set; }
         
         public DbSet<Room> Rooms { get; set; }

          protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Hotel>().HasData(
              new Hotel
              {
                  Id = 1,
                  Name = " The uhhh room",
                  StreetAddress = " 123 Mystery Street",
                  City = "Mysterious Room",
                  State = "ScoobySnack",
                  Country = " Country of Mystery",
                  Phone = "123 345 7442"
              },
              
              new Hotel
              {
                  Id = 2,
                  Name = " Niceu Niceu Very Niceu",
                  StreetAddress = " 321 sesame street",
                  City = "JOJOOO",
                  State = "Adventure of Bizarre",
                  Country = " Girly teen girl",
                  Phone = "109 876 5432"
              },
              
              new Hotel
              {
                  Id = 3,
                  Name = "Chimkin of Nightmares",
                  StreetAddress = "456 elm street",
                  City = "NightmareFun",
                  State = "fshh",
                  Country = "La La Land",
                  Phone = "111 222 3334"
              });
            
            modelBuilder.Entity<Room>().HasData(
              new Room
              {
                  Id = 1,
                  Name = "Myst",
                  Layout = 1
              },

              new Room
              {
                  Id = 2,
                  Name = "JOJO",
                  Layout = 2
              },

              new Room
              {
                  Id = 3,
                  Name = "Night",
                  Layout = 0
              });

            modelBuilder.Entity<Amenities>().HasData(
                new Amenities
                {
                    Id = 1,
                    Name = "MuchFun"
                },

                new Amenities
                {
                    Id = 2,
                    Name = "MuchDIO"
                },

                new Amenities
                {
                    Id = 3,
                    Name = "MuchMareofNight"
                });
        }







    }
}
