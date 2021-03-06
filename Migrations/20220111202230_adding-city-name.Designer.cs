// <auto-generated />
using System;
using HotelApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HotelApp.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220111202230_adding-city-name")]
    partial class addingcityname
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HotelApp.Models.CityModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Vilnius"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Kaunas"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Klaipėda"
                        });
                });

            modelBuilder.Entity("HotelApp.Models.CleanerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CityModelId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityModelId");

                    b.ToTable("Cleaners");
                });

            modelBuilder.Entity("HotelApp.Models.HotelModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoomsCapacity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Adress = "",
                            CityId = 1,
                            Name = "Hotel Vilnius",
                            RoomsCapacity = 10
                        },
                        new
                        {
                            Id = 2,
                            Adress = "",
                            CityId = 2,
                            Name = "Hotel Kaunas",
                            RoomsCapacity = 7
                        },
                        new
                        {
                            Id = 3,
                            Adress = "",
                            CityId = 3,
                            Name = "Hotel Klaipėda",
                            RoomsCapacity = 5
                        });
                });

            modelBuilder.Entity("HotelApp.Models.RoomModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CleanerModelId")
                        .HasColumnType("int");

                    b.Property<int>("Floor")
                        .HasColumnType("int");

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.Property<bool>("IsBooked")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CleanerModelId");

                    b.HasIndex("HotelId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("HotelApp.Models.CleanerModel", b =>
                {
                    b.HasOne("HotelApp.Models.CityModel", null)
                        .WithMany("Cleaners")
                        .HasForeignKey("CityModelId");
                });

            modelBuilder.Entity("HotelApp.Models.HotelModel", b =>
                {
                    b.HasOne("HotelApp.Models.CityModel", "City")
                        .WithMany("Hotels")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("HotelApp.Models.RoomModel", b =>
                {
                    b.HasOne("HotelApp.Models.CleanerModel", null)
                        .WithMany("Rooms")
                        .HasForeignKey("CleanerModelId");

                    b.HasOne("HotelApp.Models.HotelModel", "Hotel")
                        .WithMany("Rooms")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("HotelApp.Models.CityModel", b =>
                {
                    b.Navigation("Cleaners");

                    b.Navigation("Hotels");
                });

            modelBuilder.Entity("HotelApp.Models.CleanerModel", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("HotelApp.Models.HotelModel", b =>
                {
                    b.Navigation("Rooms");
                });
#pragma warning restore 612, 618
        }
    }
}
