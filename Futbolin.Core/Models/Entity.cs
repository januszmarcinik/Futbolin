using System;

namespace Futbolin.Core.Models
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }

        protected Entity()
        {
        }

        protected abstract void Validate();
    }
}
