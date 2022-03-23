using FbCoreApp216.Core.Models;
using FbCoreApp216.Core.Repository;
using FbCoreApp216.Core.Services;
using FbCoreApp216.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FbCoreApp216.Service.Services
{
    public class ProductService : Service<Product>, IProductService
    {
        public ProductService(IUnitOfWork unitOfWork, IRepository<Product> repo) : base(unitOfWork, repo)
        {
        }

        public async Task<Product> GetWithByIdAsync(int productId)
        {
            return await _unitOfWork.product.GetWithByIdAsync(productId);
        }
    }
}
