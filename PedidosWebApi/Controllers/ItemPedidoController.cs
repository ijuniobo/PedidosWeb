using Aplication.Dtos;
using Aplication.Handler.Command;
using Aplication.Handler.Query;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PedidosWebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ItemPedidoController : ControllerBase
    {
            private readonly IMediator mediator;

            public ItemPedidoController(IMediator mediator)
            {
                this.mediator = mediator;
            }

            [HttpGet]
            public async Task<IActionResult> Get()
            {
                return Ok(await this.mediator.Send(new GetAllItemPedidoQuery()));
            }

            [HttpGet("ObterPorId")]
            public async Task<IActionResult> ObterPorId(int id)
            {
                return Ok(await this.mediator.Send(new GetItemPedidoQuery(id)));
            }

            [HttpPost()]
            public async Task<IActionResult> Criar(ItemPedidoInputDto dto)
            {
                var result = await this.mediator.Send(new CreateItemPedidoCommand(dto));
                return Created($"{result.ItemPedido.Id}", result.ItemPedido);
            }

            [HttpPut()]
            public async Task<IActionResult> Atualizar(ItemPedidoInputDto dto)
            {
                var result = await this.mediator.Send(new UpdateItemPedidoCommand(dto));
                return Ok(result.ItemPedido);
            }

            [HttpDelete()]
            public async Task<IActionResult> Apagar(ItemPedidoInputDto dto)
            {
                var result = await this.mediator.Send(new DeleteItemPedidoCommand(dto));
                return Ok(result.ItemPedido);
            }

        }

}
