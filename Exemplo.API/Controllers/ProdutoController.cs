using Exemplo.API.Services.Interface;
using Exemplo.API.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exemplo.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult Get()
        {
            var produtos = _produtoService.Listar();

            return Ok(produtos);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult Post([FromBody] AdicionarProdutoVM produtoVM)
        {
            _produtoService.AdicionarProduto(produtoVM);

            return Ok();
        }
    }
}