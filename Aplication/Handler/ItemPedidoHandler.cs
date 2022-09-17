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
    public class ItemPedidoHandler : IRequestHandler<CreateItemPedidoCommand, CreateItemPedidoCommandResponse>,
                                IRequestHandler<UpdateItemPedidoCommand, UpdateItemPedidoCommandResponse>,
                                IRequestHandler<DeleteItemPedidoCommand, DeleteItemPedidoCommandResponse>,
                                IRequestHandler<GetAllItemPedidoQuery, GetAllItemPedidoQueryResponse>,
                                IRequestHandler<GetItemPedidoQuery, GetItemPedidoQueryResponse>

    {
        private readonly IItemPedidoService _itemPedidoService;

        public ItemPedidoHandler(IItemPedidoService itemPedidoService)
        {
            _itemPedidoService = itemPedidoService;
        }

        public async Task<CreateItemPedidoCommandResponse> Handle(CreateItemPedidoCommand request, CancellationToken cancellationToken)
        {
            var result = await _itemPedidoService.Criar(request.ItemPedido);
            return new CreateItemPedidoCommandResponse(result);
        }

        public async Task<UpdateItemPedidoCommandResponse> Handle(UpdateItemPedidoCommand request, CancellationToken cancellationToken)
        {
            var result = await _itemPedidoService.Atualizar(request.ItemPedido);
            return new UpdateItemPedidoCommandResponse(result);
        }

        public async Task<DeleteItemPedidoCommandResponse> Handle(DeleteItemPedidoCommand request, CancellationToken cancellationToken)
        {
            var result = await _itemPedidoService.Deletar(request.ItemPedido);
            return new DeleteItemPedidoCommandResponse(result);
        }

        public async Task<GetAllItemPedidoQueryResponse> Handle(GetAllItemPedidoQuery request, CancellationToken cancellationToken)
        {
            var result = await _itemPedidoService.ObterTodos();
            return new GetAllItemPedidoQueryResponse(result);
        }

        public async Task<GetItemPedidoQueryResponse> Handle(GetItemPedidoQuery request, CancellationToken cancellationToken)
        {
            var result = await _itemPedidoService.ObterPorId(request.IdItemPedido);
            return new GetItemPedidoQueryResponse(result);
        }
    }
}
