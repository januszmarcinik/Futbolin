using Futbolin.Core.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Futbolin.Domain.Data
{
    public interface IRepository<T> where T : Entity
    {
        Task<T> ReadAsync(Guid id);
        Task<IEnumerable<T>> ReadAsync();
        Task<T> ReadAsync(Func<T, bool> predicate);
        Task CreateAsync(T dbEntry);
        Task UpdateAsync(T dbEntry);
        Task DeleteAsync(Guid id);
        Task DeleteAsync(T dbEntry);
    }
}
