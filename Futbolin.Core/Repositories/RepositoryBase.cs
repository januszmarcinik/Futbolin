using Futbolin.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Futbolin.Core.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryRead<T>, IRepositoryCreate<T>, IRepositoryUpdate<T>, IRepositoryDelete<T> where T : Entity
    {
        protected static List<T> InMemoryCollection { get; set; }

        public async virtual Task<T> ReadAsync(Guid id)
        {
            return InMemoryCollection.SingleOrDefault(x => x.Id == id);
        }

        public async virtual Task<T> ReadAsync(Func<T, bool> predicate)
        {
            return InMemoryCollection.FirstOrDefault(predicate);
        }

        public async virtual Task<IEnumerable<T>> ReadAsync()
        {
            return InMemoryCollection;
        }

        public async virtual Task CreateAsync(T dbEntry)
        {
            InMemoryCollection.Add(dbEntry);
        }

        public async virtual Task UpdateAsync(T dbEntry)
        {
            await DeleteAsync(dbEntry.Id);
            InMemoryCollection.Add(dbEntry);
        }

        public async virtual Task DeleteAsync(Guid id)
        {
            var entity = await ReadAsync(id);
            InMemoryCollection.Remove(entity);
        }

        public async virtual Task DeleteAsync(T dbEntry)
        {
            InMemoryCollection.Remove(dbEntry);
        }
    }
}
