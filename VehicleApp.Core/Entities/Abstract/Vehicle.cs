using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp.Core.Entities.Abstract
{
    public abstract class Vehicle : BaseEntity
    {
        public string? Brand { get; set; }
        public string? Model { get; set; }     
        public string? Color { get; set; }     
    }
}
