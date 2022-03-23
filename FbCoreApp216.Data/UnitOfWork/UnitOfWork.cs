using FbCoreApp216.Core.Repository;
using FbCoreApp216.Core.UnitOfWork;
using FbCoreApp216.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FbCoreApp216.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _db;
        private ProductRepository _productRepository;
        private CategoryRepository _categoryRepository;
        public UnitOfWork(AppDbContext db)
        {
            _db = db;
        }

        //Bu alanı açıklamak için incele.
        public IProductRepository product => _productRepository??= new ProductRepository(_db);

        public ICategoryRepository category => _categoryRepository??= new CategoryRepository(_db);
        public void Commit()
        {
            _db.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}
