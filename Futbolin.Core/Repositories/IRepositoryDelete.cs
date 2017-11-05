using Futbolin.Core.Models;
using System;
using System.Threading.Tasks;

namespace Futbolin.Core.Repositories
{
    public interface IRepositoryDelete<T> where T : Entity
    {
        Task DeleteAsync(Guid id);
        Task DeleteAsync(T dbEntry);
    }
}
