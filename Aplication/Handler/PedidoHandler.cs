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
    public class PedidoHandler : IRequestHandler<CreatePedidoCommand, CreatePedidoCommandResponse>,
                                IRequestHandler<UpdatePedidoCommand, UpdatePedidoCommandResponse>,
                                IRequestHandler<DeletePedidoCommand, DeletePedidoCommandResponse>,
                                IRequestHandler<GetAllPedidoQuery, GetAllPedidoQueryResponse>,
                                IRequestHandler<GetPedidoQuery, GetPedidoQueryResponse>

    {
        private readonly IPedidoService _pedidoService;

        public PedidoHandler(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        public async Task<CreatePedidoCommandResponse> Handle(CreatePedidoCommand request, CancellationToken cancellationToken)
        {
            var result = await _pedidoService.Criar(request.Pedido);
            return new CreatePedidoCommandResponse(result);
        }

        public async Task<UpdatePedidoCommandResponse> Handle(UpdatePedidoCommand request, CancellationToken cancellationToken)
        {
            var result = await _pedidoService.Atualizar(request.Pedido);
            return new UpdatePedidoCommandResponse(result);
        }

        public async Task<DeletePedidoCommandResponse> Handle(DeletePedidoCommand request, CancellationToken cancellationToken)
        {
            var result = await _pedidoService.Deletar(request.Pedido);
            return new DeletePedidoCommandResponse(result);
        }

        public async Task<GetAllPedidoQueryResponse> Handle(GetAllPedidoQuery request, CancellationToken cancellationToken)
        {
            var result = await _pedidoService.ObterTodos();
            return new GetAllPedidoQueryResponse(result);
        }

        public async Task<GetPedidoQueryResponse> Handle(GetPedidoQuery request, CancellationToken cancellationToken)
        {
            var result = await _pedidoService.ObterPorId(request.IdPedido);
            return new GetPedidoQueryResponse(result);
        }
    }
}
