using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleApp.Core.Entities.Concrete;
using VehicleApp.DAL.Abstracts;
using VehicleApp.DAL.EntityFramework.Context;

namespace VehicleApp.DAL.EntityFramework.Concretes
{
    public class CarRepository : EFBaseRepository<Car>, ICarRepository
    {
        private readonly AppDbContext _context;
        public CarRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Car?> TurnOffHeadlights(int carId)
        {
            var car = await _context.Cars.FindAsync(carId);
            if(car != null)
            {
                car.Headlights = false;
                car.UpdateDate = DateTime.Now;
                _context.Cars.Update(car);
            }
            
            return await SaveAsync() > 0 ? car : null;
        }

        public async Task<Car?> TurnOnHeadlights(int carId)
        {
            var car = await _context.Cars.FindAsync(carId);
            if (car != null)
            {
                car.Headlights = true;
                car.UpdateDate = DateTime.Now;
                _context.Cars.Update(car);
            }
            
            return await SaveAsync() > 0 ? car : null;
        }
    }
}
