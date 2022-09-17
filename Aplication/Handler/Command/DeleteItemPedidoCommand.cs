using Aplication.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Handler.Command
{
    public class DeleteItemPedidoCommand : IRequest<DeleteItemPedidoCommandResponse>
    {
        public ItemPedidoInputDto ItemPedido { get; set; }

        public DeleteItemPedidoCommand(ItemPedidoInputDto itemPedido)
        {
            ItemPedido = itemPedido;
        }
    }

    public class DeleteItemPedidoCommandResponse
    {
        public ItemPedidoOutputDto ItemPedido { get; set; }

        public DeleteItemPedidoCommandResponse(ItemPedidoOutputDto itemPedido)
        {
            ItemPedido = itemPedido;
        }
    }
}
