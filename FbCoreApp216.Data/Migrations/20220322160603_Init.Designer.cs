﻿// <auto-generated />
using System;
using FbCoreApp216.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FbCoreApp216.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220322160603_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FbCoreApp216.Core.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("tblCategories", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CategoryName = "Kalemler",
                            CreatedBy = 1,
                            CreatedDate = new DateTime(2022, 3, 22, 19, 6, 3, 16, DateTimeKind.Local).AddTicks(8669),
                            IsDeleted = false,
                            UpdatedBy = 0,
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 2,
                            CategoryName = "Defterler",
                            CreatedBy = 1,
                            CreatedDate = new DateTime(2022, 3, 22, 19, 6, 3, 16, DateTimeKind.Local).AddTicks(8671),
                            IsDeleted = false,
                            UpdatedBy = 0,
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("FbCoreApp216.Core.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("InnerBarcode")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("tblProducts", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CategoryID = 1,
                            CreatedBy = 1,
                            CreatedDate = new DateTime(2022, 3, 22, 19, 6, 3, 16, DateTimeKind.Local).AddTicks(8509),
                            InnerBarcode = "",
                            IsDeleted = false,
                            Price = 125.75m,
                            ProductName = "Dolma Kalem",
                            Stock = 100,
                            UpdatedBy = 0,
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 2,
                            CategoryID = 1,
                            CreatedBy = 1,
                            CreatedDate = new DateTime(2022, 3, 22, 19, 6, 3, 16, DateTimeKind.Local).AddTicks(8547),
                            InnerBarcode = "",
                            IsDeleted = false,
                            Price = 55.25m,
                            ProductName = "Tükenmez Kalem",
                            Stock = 100,
                            UpdatedBy = 0,
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 3,
                            CategoryID = 1,
                            CreatedBy = 1,
                            CreatedDate = new DateTime(2022, 3, 22, 19, 6, 3, 16, DateTimeKind.Local).AddTicks(8548),
                            InnerBarcode = "",
                            IsDeleted = false,
                            Price = 5.5m,
                            ProductName = "Kurşun Kalem",
                            Stock = 100,
                            UpdatedBy = 0,
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 4,
                            CategoryID = 2,
                            CreatedBy = 1,
                            CreatedDate = new DateTime(2022, 3, 22, 19, 6, 3, 16, DateTimeKind.Local).AddTicks(8550),
                            InnerBarcode = "",
                            IsDeleted = false,
                            Price = 15.5m,
                            ProductName = "Kareli Defter",
                            Stock = 100,
                            UpdatedBy = 0,
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 5,
                            CategoryID = 2,
                            CreatedBy = 1,
                            CreatedDate = new DateTime(2022, 3, 22, 19, 6, 3, 16, DateTimeKind.Local).AddTicks(8551),
                            InnerBarcode = "",
                            IsDeleted = false,
                            Price = 12.5m,
                            ProductName = "Çizgili Defter",
                            Stock = 100,
                            UpdatedBy = 0,
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 6,
                            CategoryID = 2,
                            CreatedBy = 1,
                            CreatedDate = new DateTime(2022, 3, 22, 19, 6, 3, 16, DateTimeKind.Local).AddTicks(8552),
                            InnerBarcode = "",
                            IsDeleted = false,
                            Price = 10.95m,
                            ProductName = "Çizgisiz Defter",
                            Stock = 100,
                            UpdatedBy = 0,
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("FbCoreApp216.Core.Models.Product", b =>
                {
                    b.HasOne("FbCoreApp216.Core.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("FbCoreApp216.Core.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
