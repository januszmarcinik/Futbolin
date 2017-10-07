using Futbolin.Core.Models;
using System;
using System.Collections.Generic;

namespace Futbolin.Core.Repositories
{
    public interface IRepositoryRead<T> where T : IEntity
    {
        T Read(Guid id);
        IEnumerable<T> Read();
    }
}
