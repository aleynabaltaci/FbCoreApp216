using FbCoreApp216.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FbCoreApp216.Core.Repository
{
    public interface IProductRepository:IRepository<Product>
    {
        Task<Product> GetWithByIdAsync(int productId);

    }
}
