using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleApp.Core.Entities.Abstract;

namespace VehicleApp.Core.Interfaces
{
    public interface IRepository<T> where T : Vehicle
    {
        Task<T?> AddAsync(T entity);
        Task<T?> GetByIdAsync(int id);
        Task<List<T>> GetByColorAsync(string color);   
        Task<T?> UpdateAsync(T entity);
        Task<bool> DeleteAsync(T entity);
        Task<int> SaveAsync();
    }
}
