using Futbolin.Core.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Futbolin.Core.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryRead<T>, IRepositoryCreate<T>, IRepositoryUpdate<T>, IRepositoryDelete<T> where T : IEntity
    {
        public async virtual Task<T> ReadAsync(Guid id)
        {
            return default(T);
        }

        public async virtual Task<IEnumerable<T>> ReadAsync()
        {
            return default(IEnumerable<T>);
        }

        public async virtual Task CreateAsync(T dbEntry)
        {
        }

        public async virtual Task UpdateAsync(T dbEntry)
        {
        }

        public async virtual Task DeleteAsync(Guid id)
        {
        }

        public async virtual Task DeleteAsync(T dbEntry)
        {
        }
    }
}
