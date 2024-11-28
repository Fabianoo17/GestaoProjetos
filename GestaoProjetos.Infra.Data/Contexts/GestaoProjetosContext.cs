using GestaoProjetos.Domain.Entities;
using GestaoProjetos.Infra.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace GestaoProjetos.Infra.Data.Contexts
{
    public class GestaoContratosContext : DbContext
    {
        public GestaoContratosContext(DbContextOptions<GestaoContratosContext> options)
            : base(options)
        { }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=database.db"); // String de conexão para SQLite
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProjetoConfiguration());
            modelBuilder.ApplyConfiguration(new TarefaConfiguration());
            modelBuilder.ApplyConfiguration(new ComentarioConfiguration());

        }
    }
}
