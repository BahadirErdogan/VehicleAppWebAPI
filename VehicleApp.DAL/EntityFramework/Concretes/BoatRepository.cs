using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleApp.Core.Entities.Concrete;
using VehicleApp.DAL.Abstracts;
using VehicleApp.DAL.EntityFramework.Context;

namespace VehicleApp.DAL.EntityFramework.Concretes
{
    public class BoatRepository : EFBaseRepository<Boat>, IBoatRepository
    {
        public BoatRepository(AppDbContext context) : base(context)
        {
        }
    }
}
