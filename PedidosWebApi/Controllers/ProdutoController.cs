using Aplication.AzureBlob;
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
    public class ProdutoController : ControllerBase
    {
        private readonly IMediator mediator;

        private IHttpClientFactory httpClientFactory;

        private AzureBlobStorage storage;

        public ProdutoController(IMediator mediator, IHttpClientFactory httpClientFactory, AzureBlobStorage storage)
        {
            this.mediator = mediator;
            this.httpClientFactory = httpClientFactory;
            this.storage = storage;
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


            HttpClient httpClient = this.httpClientFactory.CreateClient();

            using var response = await httpClient.GetAsync(dto.Foto);

            if (response.IsSuccessStatusCode)
            {
                using var stream = await response.Content.ReadAsStreamAsync();

                var fileName = $"{Guid.NewGuid()}.jpg";

                var pathStorage = await this.storage.UploadFile(fileName, stream);

               dto.Foto = pathStorage;

            }

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
