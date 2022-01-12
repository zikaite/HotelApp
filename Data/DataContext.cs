using HotelApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Data
{
    public class DataContext : DbContext
    {
        public DbSet<HotelModel> Hotels { get; set; }
        public DbSet<RoomModel> Rooms { get; set; }
        public DbSet<CleanerModel> Cleaners { get; set; }
        public DbSet<CityModel> Cities { get; set; }

        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HotelModel>().HasData(
                new HotelModel
                {
                    Id = 1,
                    Name = "Hotel Vilnius",
                    CityId = 1,
                    Adress = "",
                    RoomsCapacity = 10
                },
                new HotelModel
                {
                    Id = 2,
                    Name = "Hotel Kaunas",
                    CityId = 2,
                    Adress = "",
                    RoomsCapacity = 7
                },
                new HotelModel
                {
                    Id = 3,
                    Name = "Hotel Klaipėda",
                    CityId = 3,
                    Adress = "",
                    RoomsCapacity = 5
                });

            modelBuilder.Entity<CityModel>().HasData(
                new CityModel
                {
                    Id = 1,
                    Name = "Vilnius"
                    
                },
                new CityModel
                {
                    Id = 2,
                    Name = "Kaunas"
                    
                },
                new CityModel
                {
                    Id = 3,
                    Name = "Klaipėda"
                    
                });


            //modelBuilder.Entity<CleanerModel>().HasData(
            //    new CleanerModel
            //    {
            //        Id = 1,
            //        Name = "Jonas",
            //        Surname = "Jonaitis",
            //        City = ""//ar geriau atskira turet City sarasa ir priskirti cityId cleaneriams ir hoteliui, ar priskirti miestus pagal pavadinimus
            //    });

        }
    }
}
