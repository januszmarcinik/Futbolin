using Futbolin.Core.Models;

namespace Futbolin.Core.Repositories
{
    public interface IRepositoryUpdate<T> where T : IEntity
    {
        void Update(T dbEntry);
    }
}
