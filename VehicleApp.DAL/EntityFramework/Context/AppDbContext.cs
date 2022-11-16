using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleApp.Core.Entities.Concrete;
using VehicleApp.Core.Enums;
using VehicleApp.DAL.EntityConfigs;

namespace VehicleApp.DAL.EntityFramework.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> db) : base(db)
        {

        }

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Bus> Busses { get; set; }
        public virtual DbSet<Boat> Boats { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CarConfig());
            builder.ApplyConfiguration(new BusConfig());
            builder.ApplyConfiguration(new BoatConfig());


            List<Car> cars = new List<Car>();
            cars.Add(new Car() { Id = 1,CreationDate = DateTime.Now,Status = Status.Active,Brand = "Tesla",Model = "S",Color = "Red", Wheels = 4,Headlights = false });
            cars.Add(new Car() { Id = 2,CreationDate = DateTime.Now,Status = Status.Active,Brand = "Tesla",Model = "S",Color = "Black", Wheels = 4,Headlights = false });
            cars.Add(new Car() { Id = 3,CreationDate = DateTime.Now,Status = Status.Active,Brand = "Tesla",Model = "S",Color = "Blue", Wheels = 4,Headlights = false });
            cars.Add(new Car() { Id = 4,CreationDate = DateTime.Now,Status = Status.Active,Brand = "Togg",Model = "C-SUV",Color = "Red", Wheels = 4,Headlights = false });
            cars.Add(new Car() { Id = 5,CreationDate = DateTime.Now,Status = Status.Active,Brand = "Togg",Model = "C-SUV", Color = "White", Wheels = 4,Headlights = false });
            cars.Add(new Car() { Id = 6,CreationDate = DateTime.Now,Status = Status.Active,Brand = "Togg",Model = "C-SUV", Color = "Blue", Wheels = 4,Headlights = false });

            List<Bus> buses = new List<Bus>();
            buses.Add(new Bus() { Id = 1, CreationDate = DateTime.Now, Status = Status.Active, Brand = "Karsan", Model = "e-ATAK", Color = "Red"});
            buses.Add(new Bus() { Id = 2, CreationDate = DateTime.Now, Status = Status.Active, Brand = "Karsan", Model = "e-ATAK", Color = "Blue"});
            buses.Add(new Bus() { Id = 3, CreationDate = DateTime.Now, Status = Status.Active, Brand = "Karsan", Model = "e-ATAK", Color = "White"});
            buses.Add(new Bus() { Id = 4, CreationDate = DateTime.Now, Status = Status.Active, Brand = "Karsan", Model = "e-ATA 10", Color = "Black"});
            buses.Add(new Bus() { Id = 5, CreationDate = DateTime.Now, Status = Status.Active, Brand = "Karsan", Model = "e-ATA 10", Color = "White"});
            buses.Add(new Bus() { Id = 6, CreationDate = DateTime.Now, Status = Status.Active, Brand = "Karsan", Model = "e-ATA 10", Color = "Blue"});


            List<Boat> boats = new List<Boat>();
            boats.Add(new Boat() { Id = 1, CreationDate = DateTime.Now, Status = Status.Active, Brand = "Duffy Boats", Model = "SUN CRUISER 22", Color = "White" });
            boats.Add(new Boat() { Id = 2, CreationDate = DateTime.Now, Status = Status.Active, Brand = "Duffy Boats", Model = "SUN CRUISER 22", Color = "Blue" });
            boats.Add(new Boat() { Id = 3, CreationDate = DateTime.Now, Status = Status.Active, Brand = "Duffy Boats", Model = "SUN CRUISER 22", Color = "Black" });
            boats.Add(new Boat() { Id = 4, CreationDate = DateTime.Now, Status = Status.Active, Brand = "Duffy Boats", Model = "BAY ISLAND 22", Color = "Red" });
            boats.Add(new Boat() { Id = 5, CreationDate = DateTime.Now, Status = Status.Active, Brand = "Duffy Boats", Model = "BAY ISLAND 22", Color = "White" });
            boats.Add(new Boat() { Id = 6, CreationDate = DateTime.Now, Status = Status.Active, Brand = "Duffy Boats", Model = "BAY ISLAND 22", Color = "Blue" });


            foreach (var car in cars)
            {
                builder.Entity<Car>().HasData(car);
            }

            foreach (var bus in buses)
            {
                builder.Entity<Bus>().HasData(bus);
            }

            foreach (var boat in boats)
            {
                builder.Entity<Boat>().HasData(boat);
            }

            base.OnModelCreating(builder);
        }


    }

}
