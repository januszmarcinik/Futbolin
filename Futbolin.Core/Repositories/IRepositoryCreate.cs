using Futbolin.Core.Models;

namespace Futbolin.Core.Repositories
{
    public interface IRepositoryCreate<T> where T : IEntity
    {
        void Create(T dbEntry);
    }
}
