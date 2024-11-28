using GestaoProjetos.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GestaoProjetos.Infra.Data.Configurations
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(u => u.Perfil)
                .IsRequired()
                .HasConversion<string>();

            builder.HasMany(u => u.Projetos)
                .WithOne()
                .HasForeignKey("UsuarioId")
                .OnDelete(DeleteBehavior.Cascade);

            builder.Navigation(u => u.Projetos)
                .UsePropertyAccessMode(PropertyAccessMode.Field);
        }
    }



}
