using Futbolin.Core.Models;
using System;
using System.Collections.Generic;

namespace Futbolin.Domain.Models.Football
{
    public class League : IEntity
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public string Country { get; protected set; }

        public virtual ICollection<Team> Teams { get; protected set; }
        public virtual ICollection<MatchDay> MatchDays { get; protected set; }

        protected League()
        {
        }
    }
}
