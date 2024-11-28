using GestaoProjetos.Domain.Interfaces.Repositories;
using GestaoProjetos.Infra.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GestaoProjetos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjetoController : Controller
    {
        private readonly IProjetoRepository _projetoRepository;
        private readonly IUsuarioRepository _usuarioRepository;
        public ProjetoController(IProjetoRepository? projetoRepository, IUsuarioRepository? usuarioRepository)
        {
            _projetoRepository = projetoRepository;
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet(Name = "GetProjetos")]
        public IActionResult Index()
        {



            var usuario = _usuarioRepository.AddAsync(new Domain.Entities.Usuario { Nome = "Fabiano", Email = "fabiano@hotmail.com"}).Result;
            _projetoRepository.AddAsync(new Domain.Entities.Projeto
            {
                Nome = "Projeto Teste",
                Usuario = usuario
            });
            _projetoRepository.SaveAsync().ConfigureAwait(0);


            return Ok(_projetoRepository.GetAllAsync().Result.ToList());
        }
    }
}
