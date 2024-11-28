using GestaoProjetos.Domain.Entities;
using GestaoProjetos.Domain.Interfaces.Repositories;
using GestaoProjetos.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoProjetos.Infra.Data.Repositories
{
    public class ProjetoRepository : RepositoryBase<Projeto>, IProjetoRepository
    {
        public ProjetoRepository(GestaoContratosContext gestaoContratosContext) : base(gestaoContratosContext)
        {
                
        }
    }
}
