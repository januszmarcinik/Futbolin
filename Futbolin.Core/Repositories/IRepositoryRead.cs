using Futbolin.Core.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Futbolin.Core.Repositories
{
    public interface IRepositoryRead<T> where T : IEntity
    {
        Task<T> ReadAsync(Guid id);
        Task<IEnumerable<T>> ReadAsync();
    }
}
