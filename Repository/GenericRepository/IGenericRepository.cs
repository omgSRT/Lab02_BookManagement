﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.GenericRepository
{
    public interface IGenericRepository<T> where T : class
    {
        List<T> GetAll();
        Task<List<T>> GetAllAsync();
        void Create(T entity);
        Task<int> CreateAsync(T entity);
        void Update(T entity);
        Task<int> UpdateAsync(T entity);
        bool Remove(T entity);
        Task<bool> RemoveAsync(T entity);
        T? GetById(int id);
        Task<T> GetByIdAsync(int? id);
        T? GetByName(string name);
        Task<T> GetByNameAsync(string name);
        Task<IEnumerable<T>> GetAllWithInclude(string include);
        Task<IEnumerable<T>> GetAllWith2Include(string include1, string include2);
    }
}
