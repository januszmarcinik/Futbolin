using Futbolin.Core.Models;
using System.Threading.Tasks;

namespace Futbolin.Core.Repositories
{
    public interface IRepositoryCreate<T> where T : IEntity
    {
        Task CreateAsync(T dbEntry);
    }
}
