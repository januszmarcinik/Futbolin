using Futbolin.Core.Models;
using Futbolin.Domain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Futbolin.Domain
{
    public static class DbContextExtensions
    {
        public static void ToTable<T>(this EntityTypeBuilder<T> builder, string name, DbSchema dbSchema) where T : Entity
        {
            builder.ToTable(name, dbSchema.ToString());
        }
    }
}
