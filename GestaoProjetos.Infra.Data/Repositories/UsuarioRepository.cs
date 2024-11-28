using GestaoProjetos.Domain.Entities;
using GestaoProjetos.Domain.Interfaces.Repositories;
using GestaoProjetos.Infra.Data.Contexts;

namespace GestaoProjetos.Infra.Data.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(GestaoContratosContext gestaoContratosContext) : base(gestaoContratosContext)
        {

        }
    }
}
