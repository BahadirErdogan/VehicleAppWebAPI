using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleApp.Core.Entities.Abstract;
using VehicleApp.Core.Enums;
using VehicleApp.Core.Interfaces;
using VehicleApp.DAL.EntityFramework.Context;

namespace VehicleApp.DAL.EntityFramework.Concretes
{
    public abstract class EFBaseRepository<T> : IRepository<T> where T : Vehicle
    {
        private readonly AppDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public EFBaseRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<T?> AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            return await SaveAsync() > 0 ? entity : null;
        }

        public async Task<bool> DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
            return await SaveAsync() > 0 ? true : false;
        }

        public async Task<List<T>> GetByColorAsync(string color)
        {
            return await _dbSet.Where(x => x.Color == color).ToListAsync();
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id).AsTask();
        }

        public async Task<T?> UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            return await SaveAsync() > 0 ? entity : null;
        }

        public Task<int> SaveAsync()
        {
            return _context.SaveChangesAsync();
        }
       
    }
}
