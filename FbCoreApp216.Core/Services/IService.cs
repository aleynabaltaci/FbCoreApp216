using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FbCoreApp216.Core.Service
{
    public interface IService<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> Where(Expression<Func<T,bool>> predicate);//(s=>s.==5)
        Task<T> SingleOrDefaultAsync(Expression<Func<T,bool>> predicate);

        Task<T> AddAsync(T entity);
        Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities);//Tek seferde bir çok veri göndermeyi sağlar.

        T Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    





    }
}
