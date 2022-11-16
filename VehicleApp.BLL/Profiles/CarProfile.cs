using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleApp.Core.Entities.Concrete;
using VehicleApp.Dtos.Cars;

namespace VehicleApp.BLL.Profiles
{
    public class CarProfile : Profile
    {
        public CarProfile()
        {
            CreateMap<Car, CarDto>().ReverseMap();
        }
    }
}
