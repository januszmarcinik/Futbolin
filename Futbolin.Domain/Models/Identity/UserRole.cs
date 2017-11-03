using Futbolin.Core.Models;
using System;

namespace Futbolin.Domain.Models.Identity
{
    public class UserRole : IEntity
    {
        public Guid UserId { get; protected set; }
        public Guid RoleId { get; protected set; }
    }
}
