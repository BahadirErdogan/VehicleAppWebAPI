using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleApp.Core.Entities.Concrete;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace VehicleApp.DAL.EntityConfigs
{
    public class CarConfig : VehicleConfig<Car>
    {
        public override void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.Property(x => x.Wheels).IsRequired();
            builder.Property(x => x.Headlights).IsRequired();
            base.Configure(builder);
        }


    }
}
