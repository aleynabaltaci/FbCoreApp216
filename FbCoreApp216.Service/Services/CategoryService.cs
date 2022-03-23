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
    public class CategoryService : Service<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork, IRepository<Category> repo) : base(unitOfWork, repo)
        {
        }

        public async Task<Category> GetWithByIdAsync(int categoryId)
        {
            return await _unitOfWork.category.GetWithProductIdAsync(categoryId);
        } 
    }
}
