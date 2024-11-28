using GestaoProjetos.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GestaoProjetos.Infra.Data.Configurations
{
    public class ComentarioConfiguration : IEntityTypeConfiguration<Comentario>
    {
        public void Configure(EntityTypeBuilder<Comentario> builder)
        {
            builder.ToTable("Comentarios");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Texto)
                .IsRequired()
                .HasMaxLength(300);

            builder.Property(c => c.Usuario)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(c => c.DataComentario)
                .IsRequired()
                .HasConversion(v => v.ToString("yyyy-MM-dd HH:mm:ss"),
                               v => DateTime.Parse(v));
        }
    }



}
