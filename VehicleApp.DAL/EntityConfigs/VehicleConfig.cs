using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleApp.Core.Entities.Abstract;

namespace VehicleApp.DAL.EntityConfigs
{
    public abstract class VehicleConfig<T> : IEntityTypeConfiguration<T> where T : Vehicle
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(x=>x.Brand).IsRequired().HasMaxLength(20);
            builder.Property(x=>x.Model).IsRequired().HasMaxLength(20);
            builder.Property(x=>x.Color).IsRequired().HasMaxLength(20);
        }

    }
}
