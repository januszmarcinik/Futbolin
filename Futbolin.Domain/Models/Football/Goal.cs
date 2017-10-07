using Futbolin.Core.Models;
using System;

namespace Futbolin.Domain.Models.Football
{
    public class Goal : IEntity
    {
        public Guid Id { get; protected set; }
        public byte Minute { get; protected set; }
        public bool IsPenelty { get; protected set; }
        public bool IsOwnGoal { get; protected set; }
        public string VideoUrl { get; protected set; }

        public Guid MatchId { get; protected set; }
        public virtual Match Match { get; protected set; }

        public Guid ScorerId { get; protected set; }
        public virtual Player Scorer { get; protected set; }

        public Guid AssistantId { get; protected set; }
        public virtual Player Assistant { get; protected set; }

        protected Goal()
        {
        }
    }
}
