using GestaoProjetos.Domain.Enums;

namespace GestaoProjetos.Domain.Entities
{
    public class Usuario : EntityBase
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public PerfilUsuario Perfil { get; set; } // Exemplo: "Comum", "Gerente"
        public ICollection<Projeto> Projetos { get; set; }

        public Usuario()
        {
            Projetos = new List<Projeto>();
        }
    }

}
