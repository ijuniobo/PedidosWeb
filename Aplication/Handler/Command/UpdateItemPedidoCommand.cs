using Aplication.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Handler.Command
{
    public class UpdateItemPedidoCommand : IRequest<UpdateItemPedidoCommandResponse>
    {
        public ItemPedidoInputDto ItemPedido { get; set; }

        public UpdateItemPedidoCommand(ItemPedidoInputDto itemPedido)
        {
            ItemPedido = itemPedido;
        }
    }

    public class UpdateItemPedidoCommandResponse
    {
        public ItemPedidoOutputDto ItemPedido { get; set; }

        public UpdateItemPedidoCommandResponse(ItemPedidoOutputDto itemPedido)
        {
            ItemPedido = itemPedido;
        }
    }
}
