using GestaoProjetos.Domain.Enums;

namespace GestaoProjetos.Domain.Entities
{
    public class Tarefa : EntityBase
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataVencimento { get; set; }
        public StatusTarefa Status { get; set; } // Exemplo: "Pendente", "EmAndamento", "Concluida"
        public PrioridadeTarefa Prioridade { get; set; } // Exemplo: "Baixa", "Media", "Alta"
        public Guid ProjetoId { get; set; }
        public Projeto Projeto { get; set; }
        public ICollection<Comentario> Comentarios { get; set; }

        public Tarefa()
        {
            Comentarios = new List<Comentario>();
        }
    }

}
