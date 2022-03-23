using FbCoreApp216.Core.Models;
using FbCoreApp216.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FbCoreApp216.Core.Services
{
    public interface ICategoryService:IService<Category>
    {
        Task<Category> GetWithByIdAsync(int categoryId);
    }
}
