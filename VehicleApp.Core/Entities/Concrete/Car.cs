using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleApp.Core.Entities.Abstract;

namespace VehicleApp.Core.Entities.Concrete
{
    public class Car : Vehicle
    {
        public int Wheels { get; set; }
        public bool Headlights { get; set; }
    }
}
