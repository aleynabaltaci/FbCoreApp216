using FbCoreApp216.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FbCoreApp216.Data.Seed
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        private readonly int[] _ids;
        public ProductSeed(int[] ids)
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<Product> builder)
        {

            builder.HasData(
                new Product { ID =1, ProductName ="Dolma Kalem",Price=125.75m,Stock=100, InnerBarcode = "",IsDeleted=false, CategoryID =_ids[0],CreatedBy=1,CreatedDate=DateTime.Now},
                new Product { ID =2, ProductName ="Tükenmez Kalem",Price=55.25m,Stock=100, InnerBarcode = "", IsDeleted = false, CategoryID =_ids[0],CreatedBy=1,CreatedDate=DateTime.Now},
                new Product { ID =3, ProductName ="Kurşun Kalem",Price=5.5m,Stock=100, InnerBarcode = "", IsDeleted = false, CategoryID =_ids[0],CreatedBy=1,CreatedDate=DateTime.Now},
                new Product { ID =4, ProductName ="Kareli Defter",Price=15.5m,Stock=100,InnerBarcode="", IsDeleted = false, CategoryID = _ids[1],CreatedBy=1,CreatedDate=DateTime.Now},
                new Product { ID =5, ProductName ="Çizgili Defter",Price=12.5m,Stock=100,InnerBarcode = "", IsDeleted = false, CategoryID =_ids[1],CreatedBy=1,CreatedDate=DateTime.Now},
                new Product { ID =6, ProductName ="Çizgisiz Defter",Price=10.95m,Stock=100,InnerBarcode = "", IsDeleted = false, CategoryID =_ids[1],CreatedBy=1,CreatedDate=DateTime.Now}
                );
        }
    }
}