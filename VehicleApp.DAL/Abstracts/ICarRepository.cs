using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleApp.Core.Entities.Concrete;
using VehicleApp.Core.Interfaces;

namespace VehicleApp.DAL.Abstracts
{
    public interface ICarRepository : IRepository<Car>
    {
        Task<Car?> TurnOffHeadlights(int carId);
        Task<Car?> TurnOnHeadlights(int carId);
    }
}
