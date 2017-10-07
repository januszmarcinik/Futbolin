using Futbolin.Domain.Enums;
using System;
using System.Collections.Generic;

namespace Futbolin.Domain.Models.Football
{
    public class Player
    {
        public Guid Id { get; protected set; }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public string DisplayedName { get; protected set; }
        public byte JerseyNumber { get; protected set; }
        public PlayerGeneralPosition GeneralPosition { get; protected set; }
        public PlayerDetailedPosition DetailedPosition { get; protected set; }
        public DateTime DateOfBirth { get; protected set; }

        public Guid TeamId { get; protected set; }
        public virtual Team Team { get; protected set; }

        public virtual ICollection<Goal> Goals { get; protected set; }
        public virtual ICollection<Goal> Assists { get; protected set; }

        protected Player()
        {
        }
    }
}
