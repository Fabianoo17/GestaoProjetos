using GestaoProjetos.Domain.Entities;
using GestaoProjetos.Domain.Interfaces.Repositories;
using GestaoProjetos.Infra.Data.Contexts;

namespace GestaoProjetos.Infra.Data.Repositories
{
    public class ComentarioRepository : RepositoryBase<Comentario>, IComentarioRepository
    {
        public ComentarioRepository(GestaoContratosContext gestaoContratosContext) : base(gestaoContratosContext)
        {

        }
    }

}
