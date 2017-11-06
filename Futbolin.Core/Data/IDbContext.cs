using Futbolin.Core.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Futbolin.Core.Data
{
    public interface IDbContext
    {
        Task<IQueryable<T>> ReadAsync<T>() where T : Entity;
        Task<T> ReadAsync<T>(Guid id) where T : Entity;
        Task CreateAsync<T>(T entity) where T : Entity;
        Task UpdateAsync<T>(T entity) where T : Entity;
        Task DeleteAsync<T>(T entity) where T : Entity;
        Task SaveChangesAsync();
    }
}
