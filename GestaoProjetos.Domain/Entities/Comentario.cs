namespace GestaoProjetos.Domain.Entities
{
    public class Comentario : EntityBase
    {
        public string Texto { get; set; }
        public string Usuario { get; set; }
        public DateTime DataComentario { get; set; }
        public Guid TarefaId { get; set; }
        public Tarefa Tarefa { get; set; }
    }



}
