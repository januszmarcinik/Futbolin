using Futbolin.Domain.Models.Football;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Futbolin.Domain.Data.Configurations.Football
{
    internal class LeagueConfiguration : IEntityTypeConfiguration<League>
    {
        public void Configure(EntityTypeBuilder<League> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(30);
            builder.Property(x => x.Country).HasMaxLength(30);
            builder.ToTable("Leagues", DbSchema.Football);
        }
    }
}
