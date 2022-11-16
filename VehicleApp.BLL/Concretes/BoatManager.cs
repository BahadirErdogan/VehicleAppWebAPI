using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleApp.BLL.Abstracts;
using VehicleApp.DAL.Abstracts;
using VehicleApp.DAL.EntityFramework.Concretes;
using VehicleApp.Dtos.Boats;
using VehicleApp.Dtos.Busses;

namespace VehicleApp.BLL.Concretes
{
    public class BoatManager : IBoatService
    {
        private readonly IBoatRepository _boatRepostiory;
        private readonly IMapper _mapper;

        public BoatManager(IBoatRepository boatRepository, IMapper mapper)
        {
            _boatRepostiory = boatRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Returns the boats of the given color as a list
        /// </summary>
        /// <param name="color">Color of boats to list</param>
        /// <returns>List<BoatDto></returns>
        public async Task<List<BoatDto>> GetBoatByColorAsync(string color)
        {
            var boats = await _boatRepostiory.GetByColorAsync(color);

            return _mapper.Map<List<BoatDto>>(boats);
        }
    }
}
