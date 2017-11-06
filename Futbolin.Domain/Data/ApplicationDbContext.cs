using Futbolin.Core.Models;
using Futbolin.Domain.Data.Configurations.Football;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Futbolin.Domain.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new LeagueConfiguration());
        }

        public async Task<IQueryable<T>> ReadAsync<T>() where T : Entity
        {
            return await Task.FromResult(Set<T>().AsNoTracking());
        }

        public async Task<T> ReadAsync<T>(Guid id) where T : Entity
        {
            return await Set<T>().FindAsync(id);
        }

        public async Task CreateAsync<T>(T entity) where T : Entity
        {
            await Set<T>().AddAsync(entity);
        }

        public async Task UpdateAsync<T>(T entity) where T : Entity
        {
            Set<T>().Update(entity);
            await Task.CompletedTask;
        }

        public async Task DeleteAsync<T>(T entity) where T : Entity
        {
            Set<T>().Remove(entity);
            await Task.CompletedTask;
        }

        public async Task SaveChangesAsync()
        {
            await base.SaveChangesAsync();
        }
    }
}
