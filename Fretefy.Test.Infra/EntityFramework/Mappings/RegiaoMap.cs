using Fretefy.Test.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fretefy.Test.Infra.EntityFramework.Mappings
{
    public class RegiaoMap : IEntityTypeConfiguration<Regiao>
    {
        public void Configure(EntityTypeBuilder<Regiao> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Nome).IsRequired().HasMaxLength(256);

            builder.HasMany(r => r.RegiaoCidades)
                   .WithOne(rc => rc.Regiao)
                   .HasForeignKey(rc => rc.RegiaoId);

            builder.ToTable("Regioes");
        }
    }

    public class RegiaoCidadeMap : IEntityTypeConfiguration<RegiaoCidade>
    {
        public void Configure(EntityTypeBuilder<RegiaoCidade> builder)
        {
            builder.HasKey(rc => rc.Id);
            builder.Property(rc => rc.Nome).IsRequired().HasMaxLength(256);
            builder.ToTable("RegiaoCidades");
        }
    }
}
