using Cavex.Principal.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cavex.Principal.Infraestructure.Config
{
    public class EmpCatGeneroConfiguration : IEntityTypeConfiguration<EmpCatGenero>
    {
        public void Configure(EntityTypeBuilder<EmpCatGenero> builder)
        {
            builder.ToTable("EmpCatGenero");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.StrValor)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(x => x.StrDescripcion)
                .HasMaxLength(450);
        }
    }
}