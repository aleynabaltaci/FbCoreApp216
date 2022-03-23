using FbCoreApp216.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FbCoreApp216.Data.Configuration
{
    public class ProductConfiguraiton : IEntityTypeConfiguration<Product>
    {
       

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(s => s.ID);
            builder.Property(s => s.ID).UseIdentityColumn();
            builder.Property(s=>s.ProductName).IsRequired().HasMaxLength(200);
            builder.Property(s=>s.Stock).IsRequired();
            builder.Property(s=>s.Price).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(s => s.InnerBarcode).HasMaxLength(50);
            builder.Property(s => s.CreatedDate).HasColumnType("date");
            builder.Property(s => s.UpdatedTime).HasColumnType("date");
            builder.ToTable("tblProducts");
        }
    }
}

