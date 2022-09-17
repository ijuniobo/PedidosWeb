using Aplication.Handler.Command;
using Aplication.Handler.Query;
using Aplication.Service;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Handler
{
    public class ClienteHandler : IRequestHandler<CreateClienteCommand, CreateClienteCommandResponse>,
                                IRequestHandler<UpdateClienteCommand, UpdateClienteCommandResponse>,
                                IRequestHandler<DeleteClienteCommand, DeleteClienteCommandResponse>,
                                IRequestHandler<GetAllClienteQuery, GetAllClienteQueryResponse>,
                                IRequestHandler<GetClienteQuery, GetClienteQueryResponse>

    {
        private readonly IClienteService _clienteService;

        public ClienteHandler(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public async Task<CreateClienteCommandResponse> Handle(CreateClienteCommand request, CancellationToken cancellationToken)
        {
            var result = await _clienteService.Criar(request.Cliente);
            return new CreateClienteCommandResponse(result);
        }

        public async Task<UpdateClienteCommandResponse> Handle(UpdateClienteCommand request, CancellationToken cancellationToken)
        {
            var result = await _clienteService.Atualizar(request.Cliente);
            return new UpdateClienteCommandResponse(result);
        }

        public async Task<DeleteClienteCommandResponse> Handle(DeleteClienteCommand request, CancellationToken cancellationToken)
        {
            var result = await _clienteService.Deletar(request.Cliente);
            return new DeleteClienteCommandResponse(result);
        }

        public async Task<GetAllClienteQueryResponse> Handle(GetAllClienteQuery request, CancellationToken cancellationToken)
        {
            var result = await _clienteService.ObterTodos();
            return new GetAllClienteQueryResponse(result);
        }

        public async Task<GetClienteQueryResponse> Handle(GetClienteQuery request, CancellationToken cancellationToken)
        {
            var result = await _clienteService.ObterPorId(request.IdCliente);
            return new GetClienteQueryResponse(result);
        }
    }
}
