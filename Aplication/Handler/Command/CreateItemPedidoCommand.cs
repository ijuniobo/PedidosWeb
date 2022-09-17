using Aplication.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Handler.Command
{
    public class CreateItemPedidoCommand : IRequest<CreateItemPedidoCommandResponse>
    {
        public ItemPedidoInputDto ItemPedido { get; set; }

        public CreateItemPedidoCommand(ItemPedidoInputDto itemPedido)
        {
            ItemPedido = itemPedido;
        }
    }

    public class CreateItemPedidoCommandResponse
    {
        public ItemPedidoOutputDto ItemPedido { get; set; }

        public CreateItemPedidoCommandResponse(ItemPedidoOutputDto itemPedido)
        {
            ItemPedido = itemPedido;
        }
    }
}
