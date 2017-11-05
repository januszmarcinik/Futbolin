using Futbolin.Core.Models;
using System;

namespace Futbolin.Domain.Models.Identity
{
    public class User : Entity
    {
        public string Email { get; set; }
        public string Password { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
