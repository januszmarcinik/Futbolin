using Futbolin.Core.Models;
using System.Threading.Tasks;

namespace Futbolin.Core.Repositories
{
    public interface IRepositoryCreate<T> where T : Entity
    {
        Task CreateAsync(T dbEntry);
    }
}
