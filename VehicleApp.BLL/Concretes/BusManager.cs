using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleApp.BLL.Abstracts;
using VehicleApp.DAL.Abstracts;
using VehicleApp.DAL.EntityFramework.Concretes;
using VehicleApp.Dtos.Busses;
using VehicleApp.Dtos.Cars;

namespace VehicleApp.BLL.Concretes
{
    public class BusManager : IBusService
    {
        private readonly IBusRepository _busRepostiory;
        private readonly IMapper _mapper;

        public BusManager(IBusRepository busRepository, IMapper mapper)
        {
            _busRepostiory = busRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Returns the busses of the given color as a list
        /// </summary>
        /// <param name="color">Color of busses to list</param>
        /// <returns>List<BusDto></returns>
        public async Task<List<BusDto>> GetBusByColorAsync(string color)
        {
            var busses = await _busRepostiory.GetByColorAsync(color);

            return _mapper.Map<List<BusDto>>(busses);
        }
    }
}
