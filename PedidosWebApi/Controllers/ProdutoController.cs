using Aplication.Dtos;
using Aplication.Handler.Command;
using Aplication.Handler.Query;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PedidosWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
            private readonly IMediator mediator;

            public ProdutoController(IMediator mediator)
            {
                this.mediator = mediator;
            }

            [HttpGet]
            public async Task<IActionResult> Get()
            {
                return Ok(await this.mediator.Send(new GetAllProdutoQuery()));
            }

            [HttpGet("ObterPorId")]
            public async Task<IActionResult> ObterPorId(int id)
            {
                return Ok(await this.mediator.Send(new GetProdutoQuery(id)));
            }

            [HttpPost()]
            public async Task<IActionResult> Criar(ProdutoInputDto dto)
            {
                var result = await this.mediator.Send(new CreateProdutoCommand(dto));
                return Created($"{result.Produto.Id}", result.Produto);
            }

            [HttpPut()]
            public async Task<IActionResult> Atualizar(ProdutoInputDto dto)
            {
                var result = await this.mediator.Send(new UpdateProdutoCommand(dto));
                return Ok(result.Produto);
            }

            [HttpDelete()]
            public async Task<IActionResult> Apagar(ProdutoInputDto dto)
            {
                var result = await this.mediator.Send(new DeleteProdutoCommand(dto));
                return Ok(result.Produto);
            }

        }

}
