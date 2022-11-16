using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleApp.Dtos.Boats;
using VehicleApp.Dtos.Busses;

namespace VehicleApp.BLL.Abstracts
{
    public interface IBoatService
    {
        Task<List<BoatDto>> GetBoatByColorAsync(string color);
    }
}
