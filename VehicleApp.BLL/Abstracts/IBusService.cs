using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleApp.Dtos.Busses;
using VehicleApp.Dtos.Cars;

namespace VehicleApp.BLL.Abstracts
{
    public interface IBusService
    {
        Task<List<BusDto>> GetBusByColorAsync(string color);
    }
}
