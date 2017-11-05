using Futbolin.Core.Models;
using System;
using System.Collections.Generic;

namespace Futbolin.Domain.Models.Football
{
    public class Team : Entity
    {
        public string Name { get; protected set; }
        public string Coach { get; protected set; }

        public Guid LeagueId { get; protected set; }
        public virtual League League { get; protected set; }

        public virtual ICollection<Player> Players { get; protected set; }

        protected Team()
        {
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
