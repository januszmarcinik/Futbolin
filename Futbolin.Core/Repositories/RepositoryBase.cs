using Futbolin.Core.Data;
using Futbolin.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Futbolin.Core.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryRead<T>, IRepositoryCreate<T>, IRepositoryUpdate<T>, IRepositoryDelete<T> where T : Entity
    {
        private readonly IDbContext _context;

        public RepositoryBase(IDbContext context)
        {
            _context = context;
        }

        public async virtual Task<T> ReadAsync(Guid id)
        {
            return await _context.ReadAsync<T>(id);
        }

        public async virtual Task<T> ReadAsync(Func<T, bool> predicate)
        {
            var query = await _context.ReadAsync<T>();
            return query.FirstOrDefault(predicate);
        }

        public async virtual Task<IEnumerable<T>> ReadAsync()
        {
            return await _context.ReadAsync<T>();
        }

        public async virtual Task CreateAsync(T dbEntry)
        {
            await _context.CreateAsync(dbEntry);
            await _context.SaveChangesAsync();
        }

        public async virtual Task UpdateAsync(T dbEntry)
        {
            await _context.UpdateAsync(dbEntry);
            await _context.SaveChangesAsync();
        }

        public async virtual Task DeleteAsync(Guid id)
        {
            var entity = await ReadAsync(id);
            await _context.DeleteAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async virtual Task DeleteAsync(T dbEntry)
        {
            await _context.DeleteAsync(dbEntry);
            await _context.SaveChangesAsync();
        }
    }
}
