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
    public class PedidoController : ControllerBase
    {
            private readonly IMediator mediator;

            public PedidoController(IMediator mediator)
            {
                this.mediator = mediator;
            }

            [HttpGet]
            public async Task<IActionResult> Get()
            {
                return Ok(await this.mediator.Send(new GetAllPedidoQuery()));
            }

            [HttpGet("ObterPorId")]
            public async Task<IActionResult> ObterPorId(int id)
            {
                return Ok(await this.mediator.Send(new GetPedidoQuery(id)));
            }

            [HttpPost()]
            public async Task<IActionResult> Criar(PedidoInputDto dto)
            {
                var result = await this.mediator.Send(new CreatePedidoCommand(dto));
                return Created($"{result.Pedido.Id}", result.Pedido);
            }

            [HttpPut()]
            public async Task<IActionResult> Atualizar(PedidoInputDto dto)
            {
                var result = await this.mediator.Send(new UpdatePedidoCommand(dto));
                return Ok(result.Pedido);
            }

            [HttpDelete()]
            public async Task<IActionResult> Apagar(PedidoInputDto dto)
            {
                var result = await this.mediator.Send(new DeletePedidoCommand(dto));
                return Ok(result.Pedido);
            }

        }

}
