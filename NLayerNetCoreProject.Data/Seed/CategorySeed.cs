using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerNetCoreProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerNetCoreProject.Data.Seed
{

    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        private readonly int[] _ids;
        private Category[] _categories;

        public CategorySeed(int[] Ids)
        {
            _ids = Ids;
        }

        public void Configure(EntityTypeBuilder<Category> builder)
        {
            Seed();
            builder.HasData(_categories);

        }

        private void Seed()
        {
            _categories = new Category[]
            {
                new Category{CategoryName="Elektronik",CategoryId=_ids[0]},
                new Category{CategoryName="Giyim",CategoryId=_ids[1]},

            };
        }
    }
}
