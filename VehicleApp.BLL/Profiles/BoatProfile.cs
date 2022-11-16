using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleApp.Core.Entities.Concrete;
using VehicleApp.Dtos.Boats;

namespace VehicleApp.BLL.Profiles
{
    public class BoatProfile : Profile
    {
        public BoatProfile()
        {
            CreateMap<Boat, BoatDto>();
        }
    }
}
