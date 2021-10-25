﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NLayerNetCoreProject.Data;

namespace NLayerNetCoreProject.Data.Migrations
{
    [DbContext(typeof(NLayerDbContext))]
    [Migration("20211025191806_fwefew")]
    partial class fwefew
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NLayerNetCoreProject.Core.Entity.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 50)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Elektronik",
                            IsActive = true,
                            IsDeleted = false
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Giyim",
                            IsActive = true,
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("NLayerNetCoreProject.Core.Entity.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentificationNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("NLayerNetCoreProject.Core.Entity.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Barcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Barcode = "TRTR5151",
                            CategoryId = 1,
                            IsActive = true,
                            IsDeleted = false,
                            ProductName = "Telefon",
                            ProductPrice = 4000.00m,
                            Stock = 50
                        },
                        new
                        {
                            ProductId = 2,
                            Barcode = "TRTR5252",
                            CategoryId = 1,
                            IsActive = true,
                            IsDeleted = false,
                            ProductName = "Bilgisayar",
                            ProductPrice = 7000.00m,
                            Stock = 70
                        },
                        new
                        {
                            ProductId = 3,
                            Barcode = "TRTR553",
                            CategoryId = 1,
                            IsActive = true,
                            IsDeleted = false,
                            ProductName = "Televizyon",
                            ProductPrice = 6000.00m,
                            Stock = 80
                        },
                        new
                        {
                            ProductId = 4,
                            Barcode = "TRTR5454",
                            CategoryId = 2,
                            IsActive = true,
                            IsDeleted = false,
                            ProductName = "T-Shirt",
                            ProductPrice = 24.99m,
                            Stock = 40
                        },
                        new
                        {
                            ProductId = 5,
                            Barcode = "TRTR5555",
                            CategoryId = 2,
                            IsActive = true,
                            IsDeleted = false,
                            ProductName = "Pantolon",
                            ProductPrice = 100.00m,
                            Stock = 100
                        });
                });

            modelBuilder.Entity("NLayerNetCoreProject.Core.Entity.Product", b =>
                {
                    b.HasOne("NLayerNetCoreProject.Core.Entity.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("NLayerNetCoreProject.Core.Entity.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
