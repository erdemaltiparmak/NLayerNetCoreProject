using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerNetCoreProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerNetCoreProject.Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.ProductId);
            builder.Property(x => x.ProductId).UseIdentityColumn();
            builder.Property(x => x.ProductName).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Stock).IsRequired();
            builder.Property(x => x.IsActive).HasDefaultValue(true);

            builder.Property(x => x.ProductPrice).HasColumnType("decimal(18,2");
        }
    }
}
