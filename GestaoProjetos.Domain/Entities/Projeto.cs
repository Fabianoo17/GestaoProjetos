using GestaoProjetos.Domain.Enums;

namespace GestaoProjetos.Domain.Entities
{
    public class Projeto : EntityBase
    {
        public string Nome { get; set; }
        public Guid UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public ICollection<Tarefa> Tarefas { get; set; }

        public Projeto()
        {
            Tarefas = new List<Tarefa>();
        }
    }

}
