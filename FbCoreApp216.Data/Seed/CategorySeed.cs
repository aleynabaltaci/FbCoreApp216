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
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        
        private readonly int[] _ids;
        public CategorySeed(int[] ids)
        {
            _ids = ids;
        }


        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category { ID = _ids[0], CategoryName = "Kalemler", CreatedDate = DateTime.Now, CreatedBy = 1, IsDeleted = false },
                            new Category { ID = _ids[1], CategoryName = "Defterler", CreatedDate = DateTime.Now, CreatedBy = 1, IsDeleted = false }
            );
        }
    }
}
