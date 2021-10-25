using Microsoft.EntityFrameworkCore;
using NLayerNetCoreProject.Core.Entity;
using NLayerNetCoreProject.Data.Configuration;
using NLayerNetCoreProject.Data.Seed;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerNetCoreProject.Data
{
    public class NLayerDbContext:DbContext
    {
        public NLayerDbContext(DbContextOptions<NLayerDbContext> dbContextOptions) : base(dbContextOptions){}

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Category> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductSeed(new[] { 1, 2 }));
            modelBuilder.ApplyConfiguration(new CategorySeed(new[] { 1, 2 }));


            var builder = modelBuilder.Entity<Customer>();
            builder.HasKey(x => x.CustomerId);
            builder.Property(x => x.CustomerId).UseIdentityColumn();
        }
    }
}
