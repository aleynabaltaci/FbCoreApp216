﻿using FbCoreApp216.Core.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FbCoreApp216.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly AppDbContext _db; // Dbyi kullandık
        private readonly DbSet<T> _dbset;

        public Repository(AppDbContext db)
        {
            _db = db;
            _dbset= db.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
           
             await _dbset.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await _dbset.AddRangeAsync(entities);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbset.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbset.FindAsync(id);
        }

        public async void Remove(T entity)
        {
            _dbset.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _dbset.RemoveRange(entities);
        }

        public async Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate)
        {
            return(await _dbset.SingleOrDefaultAsync(predicate))!;
        }

        public T Update(T entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public async Task<IEnumerable<T>> Where(Expression<Func<T, bool>> predicate)
        {
            //Result kodu asenkron metod içerisinde senkron bir kodu çalıştırır.
            //return _dbset.Where(predicate).ToListAsync().Result;
            return await _dbset.Where(predicate).ToListAsync();
        }
    }
}
