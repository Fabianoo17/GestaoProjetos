using GestaoProjetos.Domain.Entities;
using GestaoProjetos.Domain.Interfaces.Repositories;
using GestaoProjetos.Infra.Data.Contexts;

namespace GestaoProjetos.Infra.Data.Repositories
{
    public class TarefaRepository : RepositoryBase<Tarefa>, ITarefaRepository
    {
        public TarefaRepository(GestaoContratosContext gestaoContratosContext) : base(gestaoContratosContext)
        {

        }
    }
}
