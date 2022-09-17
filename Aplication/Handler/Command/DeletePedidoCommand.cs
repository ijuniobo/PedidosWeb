using Aplication.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Handler.Command
{
    public class DeletePedidoCommand : IRequest<DeletePedidoCommandResponse>
    {
        public PedidoInputDto Pedido { get; set; }

        public DeletePedidoCommand(PedidoInputDto pedido)
        {
            Pedido = pedido;
        }
    }

    public class DeletePedidoCommandResponse
    {
        public PedidoOutputDto Pedido { get; set; }

        public DeletePedidoCommandResponse(PedidoOutputDto pedido)
        {
            Pedido = pedido;
        }
    }
}
