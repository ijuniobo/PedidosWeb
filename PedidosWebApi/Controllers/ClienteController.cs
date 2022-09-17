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
    public class ClienteController : ControllerBase
    {
            private readonly IMediator mediator;

            public ClienteController(IMediator mediator)
            {
                this.mediator = mediator;
            }

            [HttpGet]
            public async Task<IActionResult> Get()
            {
                return Ok(await this.mediator.Send(new GetAllClienteQuery()));
            }

            [HttpGet("ObterPorId")]
            public async Task<IActionResult> ObterPorId(int id)
            {
                return Ok(await this.mediator.Send(new GetClienteQuery(id)));
            }

            [HttpPost()]
            public async Task<IActionResult> Criar(ClienteInputDto dto)
            {
                var result = await this.mediator.Send(new CreateClienteCommand(dto));
                return Created($"{result.Cliente.Id}", result.Cliente);
            }

            [HttpPut()]
            public async Task<IActionResult> Atualizar(ClienteInputDto dto)
            {
                var result = await this.mediator.Send(new UpdateClienteCommand(dto));
                return Ok(result.Cliente);
            }

            [HttpDelete()]
            public async Task<IActionResult> Apagar(ClienteInputDto dto)
            {
                var result = await this.mediator.Send(new DeleteClienteCommand(dto));
                return Ok(result.Cliente);
            }

        }

}
