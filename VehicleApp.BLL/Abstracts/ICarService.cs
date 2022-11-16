using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleApp.Dtos.Cars;

namespace VehicleApp.BLL.Abstracts
{
    public interface ICarService
    {
        Task<List<CarDto>> GetCarByColorAsync(string color);
        Task<CarDto> TurnOnOffHeadLights(int carId);
        Task<bool> DeleteCarByCarId(int carId);
    }
}
