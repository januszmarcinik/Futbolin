using Futbolin.Core.Models;
using System;
using System.Collections.Generic;

namespace Futbolin.Domain.Models.Football
{
    public class Season : IEntity
    {
        public Guid Id { get; protected set; }
        public string Years { get; protected set; }

        public virtual ICollection<MatchDay> MatchDays { get; protected set; }

        protected Season()
        {
        }
    }
}
