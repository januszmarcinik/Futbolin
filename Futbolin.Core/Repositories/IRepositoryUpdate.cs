using Futbolin.Core.Models;
using System.Threading.Tasks;

namespace Futbolin.Core.Repositories
{
    public interface IRepositoryUpdate<T> where T : IEntity
    {
        Task UpdateAsync(T dbEntry);
    }
}
