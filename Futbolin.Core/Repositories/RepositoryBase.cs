using Futbolin.Core.Models;
using System;
using System.Collections.Generic;

namespace Futbolin.Core.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryRead<T>, IRepositoryCreate<T>, IRepositoryUpdate<T>, IRepositoryDelete<T> where T : IEntity
    {
        public virtual T Read(Guid id)
        {
            return default(T);
        }

        public virtual IEnumerable<T> Read()
        {
            return default(IEnumerable<T>);
        }

        public virtual void Create(T dbEntry)
        {
        }

        public void Update(T dbEntry)
        {
        }

        public virtual void Delete(Guid id)
        {
        }

        public virtual void Delete(T dbEntry)
        {
        }
    }
}
