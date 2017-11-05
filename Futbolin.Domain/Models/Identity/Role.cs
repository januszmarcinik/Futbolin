using Futbolin.Core.Models;
using System;

namespace Futbolin.Domain.Models.Identity
{
    public class Role : Entity
    {
        public string Name { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
