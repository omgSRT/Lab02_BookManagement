using BusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.GenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected ApplicationDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public GenericRepository()
        {
            _context = new ApplicationDbContext();
            _dbSet = _context.Set<T>();
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public async Task<List<T>> GetAllAsync()
        {
            var list = await _dbSet.ToListAsync();
            return list;
        }

        public void Create(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public async Task<int> CreateAsync(T entity)
        {
            _dbSet.Add(entity);
            return await _context.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            var tracker = _context.Attach(entity);
            tracker.State = EntityState.Modified;
            _context.SaveChanges();
        }

        public async Task<int> UpdateAsync(T entity)
        {
            var tracker = _context.Attach(entity);
            tracker.State = EntityState.Modified;
            return await _context.SaveChangesAsync();
        }

        public bool Remove(T entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
            return true;
        }

        public async Task<bool> RemoveAsync(T entity)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public T? GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public async Task<T> GetByIdAsync(int? id)
        {
            return await _dbSet.FindAsync(id);
        }

        public T? GetByName(string name)
        {
            return _dbSet.Find(name);
        }

        public async Task<T> GetByNameAsync(string name)
        {
            return await _dbSet.FindAsync(name);
        }

        public async Task<IEnumerable<T>> GetAllWithInclude(string include)
        {
            var list= await _dbSet.Include(include).ToListAsync();
            return list;
        }

        public async Task<IEnumerable<T>> GetAllWith2Include(string include1, string include2)
        {
            var list = await _dbSet.Include(include1).Include(include2).ToListAsync();
            return list;
        }
    }
}
