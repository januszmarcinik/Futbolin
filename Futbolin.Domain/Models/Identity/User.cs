using Futbolin.Core.Models;
using System;

namespace Futbolin.Domain.Models.Identity
{
    public class User : IEntity
    {
        public Guid Id { get; protected set; }
        public string Email { get; protected set; }
        public string Password { get; protected set; }

        protected User()
        {
        }
    }
}
