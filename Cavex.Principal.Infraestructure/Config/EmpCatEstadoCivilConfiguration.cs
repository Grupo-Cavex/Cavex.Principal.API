using Cavex.Principal.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cavex.Principal.Infraestructure.Config
{
    public class EmpCatEstadoCivilConfiguration : IEntityTypeConfiguration<EmpCatEstadoCivil>
    {
        public void Configure(EntityTypeBuilder<EmpCatEstadoCivil> builder)
        {
            builder.ToTable("EmpCatEstadoCivil");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.StrValor)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(x => x.StrDescripcion)
                .HasMaxLength(450);
        }
    }
}