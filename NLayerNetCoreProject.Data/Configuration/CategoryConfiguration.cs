using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerNetCoreProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerNetCoreProject.Data.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.CategoryId);
            builder.Property(x => x.CategoryId).UseIdentityColumn(50);
            builder.Property(x => x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.CategoryName).HasMaxLength(50);
        }
    }
}
