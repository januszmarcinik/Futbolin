using Futbolin.Core.Models;
using Futbolin.Domain.Enums;
using System;
using System.Collections.Generic;

namespace Futbolin.Domain.Models.Football
{
    public class MatchDay : IEntity
    {
        public Guid Id { get; protected set; }
        public byte Number { get; protected set; }
        public SeasonRound Round { get; protected set; }

        public Guid SeasonId { get; protected set; }
        public virtual Season Season { get; protected set; }

        public Guid LeagueId { get; protected set; }
        public virtual League League { get; protected set; }

        public virtual ICollection<Match> Matches { get; protected set; }

        protected MatchDay()
        {
        }
    }
}
