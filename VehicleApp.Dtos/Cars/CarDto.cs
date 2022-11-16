using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp.Dtos.Cars
{
    public class CarDto
    {
        public int Id { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public string? Color { get; set; }
        public int Wheels { get; set; }
        public bool Headlights { get; set; }
    }
}
