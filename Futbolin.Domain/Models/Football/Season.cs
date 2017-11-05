using Futbolin.Core.Models;
using System;
using System.Collections.Generic;

namespace Futbolin.Domain.Models.Football
{
    public class Season : Entity
    {
        public string Years { get; protected set; }

        public virtual ICollection<MatchDay> MatchDays { get; protected set; }

        protected Season()
        {
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
