using Cavex.Principal.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cavex.Principal.Infraestructure.Config
{
    public class EmpCatNacionalidadConfiguration : IEntityTypeConfiguration<EmpCatNacionalidad>
    {
        public void Configure(EntityTypeBuilder<EmpCatNacionalidad> builder)
        {
            builder.ToTable("EmpCatNacionalidad");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.StrValor)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(x => x.StrDescripcion)
                .HasMaxLength(450);
        }
    }
}