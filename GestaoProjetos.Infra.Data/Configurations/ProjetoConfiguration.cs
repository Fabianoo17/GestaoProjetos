using GestaoProjetos.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GestaoProjetos.Infra.Data.Configurations
{
    public class ProjetoConfiguration : IEntityTypeConfiguration<Projeto>
    {
        public void Configure(EntityTypeBuilder<Projeto> builder)
        {
            builder.ToTable("Projetos");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.DataCriacao)
                .IsRequired()
                .HasConversion(v => v.ToString("yyyy-MM-dd HH:mm:ss"), // Converte para string no formato ISO
                               v => DateTime.Parse(v));

            builder.Property(p => p.DataAtualizacao)
                .IsRequired()
                .HasConversion(v => v.ToString("yyyy-MM-dd HH:mm:ss"),
                               v => DateTime.Parse(v));

            builder.HasMany(p => p.Tarefas)
                .WithOne()
                .HasForeignKey("ProjetoId")
                .OnDelete(DeleteBehavior.Cascade);

            builder.Navigation(p => p.Tarefas)
                .UsePropertyAccessMode(PropertyAccessMode.Field);
        }
    }



}
