using FbCoreApp216.Core.Models;
using FbCoreApp216.Core.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FbCoreApp216.Data.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private AppDbContext appDbContext { get=> _db as AppDbContext; }
        public ProductRepository(AppDbContext db) : base(db)
        {

        }
        public async Task<Product> GetWithByIdAsync(int productId)
        {
            return (await appDbContext.Products.Include(x=>x.Category).FirstOrDefaultAsync(s=>s.ID==productId))!;
        }
    }
}
