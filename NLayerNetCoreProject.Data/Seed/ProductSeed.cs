using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerNetCoreProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerNetCoreProject.Data.Seed
{

    public class ProductSeed:IEntityTypeConfiguration<Product>
    {
        private readonly int[] _ids;
        private Product[] _products;
        public ProductSeed(int[] Ids)
        {
            _ids = Ids;
        }

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            Seed();
            builder.HasData(_products);
            
        }

        private void Seed()
        {
            _products = new Product[]
            {
                new Product{ProductId=1,ProductName="Telefon",Stock=50,Barcode="TRTR5151",ProductPrice=4000.00m,CategoryId=_ids[0]},
                new Product{ProductId=2,ProductName="Bilgisayar",Stock=70,Barcode="TRTR5252",ProductPrice=7000.00m,CategoryId=_ids[0]},
                new Product{ProductId=3,ProductName="Televizyon",Stock=80,Barcode="TRTR553",ProductPrice=6000.00m,CategoryId=_ids[0]},
                new Product{ProductId=4,ProductName="T-Shirt",Stock=40,Barcode="TRTR5454",ProductPrice=24.99m,CategoryId=_ids[1]},
                new Product{ProductId=5,ProductName="Pantolon",Stock=100,Barcode="TRTR5555",ProductPrice=100.00m,CategoryId=_ids[1]},

            };
        }
    }
}
