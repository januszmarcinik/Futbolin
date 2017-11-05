using Futbolin.Core.Models;
using System;
using System.Collections.Generic;

namespace Futbolin.Domain.Models.Football
{
    public class League : Entity
    {
        public string Name { get; protected set; }
        public string Country { get; protected set; }

        public virtual ICollection<Team> Teams { get; protected set; }
        public virtual ICollection<MatchDay> MatchDays { get; protected set; }

        public League(Guid id, string name, string country)
        {
            Id = id;
            Name = name;
            Country = country;

            Validate();
        }

        protected override void Validate()
        {
            if (Id.ToString().IsNullOrWhiteSpace())
            {
                throw new ServiceException("Specified Id for league is empty.");
            }
            if (Name.IsNullOrWhiteSpace())
            {
                throw new ServiceException("Specified name for league is empty.");
            }
            else if (Country.IsNullOrWhiteSpace())
            {
                throw new ServiceException("Specified country for league is empty.");
            }
        }
    }
}
