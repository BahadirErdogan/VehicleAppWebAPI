using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleApp.Core.Entities.Concrete;
using VehicleApp.Dtos.Busses;

namespace VehicleApp.BLL.Profiles
{
    public class BusProfile : Profile
    {
        public BusProfile()
        {
            CreateMap<Bus, BusDto>();
        }
    }
}
