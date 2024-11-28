namespace GestaoProjetos.Domain
{
    public abstract class EntityBase
    {
        public Guid Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public bool IsDeleted { get; set; } = false;

        protected EntityBase()
        {
            Id = Guid.NewGuid();
            DataCriacao = DateTime.UtcNow;
            DataAtualizacao = DateTime.UtcNow;
        }
    }
}
