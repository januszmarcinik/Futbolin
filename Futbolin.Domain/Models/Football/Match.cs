using System;
using System.Collections.Generic;

namespace Futbolin.Domain.Models.Football
{
    public class Match
    {
        public Guid Id { get; protected set; }

        public Guid HomeTeamId { get; protected set; }
        public virtual Team HomeTeam { get; protected set; }

        public Guid AwayTeamId { get; protected set; }
        public virtual Team AwayTeam { get; protected set; }

        public byte HomeTeamGoals { get; protected set; }
        public byte AwayTeamGoals { get; protected set; }

        public DateTime Date { get; protected set; }

        public Guid MatchDayId { get; protected set; }
        public virtual MatchDay MatchDay { get; protected set; }

        public virtual ICollection<Goal> Goals { get; protected set; }

        protected Match()
        {
        }
    }
}
