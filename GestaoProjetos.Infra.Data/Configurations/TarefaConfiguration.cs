using GestaoProjetos.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GestaoProjetos.Infra.Data.Configurations
{
    public class TarefaConfiguration : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            builder.ToTable("Tarefas");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Titulo)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(t => t.Descricao)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(t => t.DataVencimento)
                .IsRequired()
                .HasConversion(v => v.ToString("yyyy-MM-dd HH:mm:ss"),
                               v => DateTime.Parse(v));

            builder.Property(t => t.Status)
                .IsRequired()
                .HasConversion<string>();

            builder.Property(t => t.Prioridade)
                .IsRequired()
                .HasConversion<string>();


            builder.Navigation(t => t.Comentarios)
                .UsePropertyAccessMode(PropertyAccessMode.Field);
        }
    }



}
