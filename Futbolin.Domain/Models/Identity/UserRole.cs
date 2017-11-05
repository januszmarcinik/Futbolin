using Futbolin.Core.Models;
using System;

namespace Futbolin.Domain.Models.Identity
{
    public class UserRole : Entity
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
