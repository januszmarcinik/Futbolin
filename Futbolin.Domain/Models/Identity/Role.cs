using Futbolin.Core.Models;
using System;

namespace Futbolin.Domain.Models.Identity
{
    public class Role : IEntity
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }

        protected Role()
        {
        }
    }
}
