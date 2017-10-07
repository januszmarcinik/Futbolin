using Futbolin.Core.Models;
using System;

namespace Futbolin.Core.Repositories
{
    public interface IRepositoryDelete<T> where T : IEntity
    {
        void Delete(Guid id);
        void Delete(T dbEntry);
    }
}
