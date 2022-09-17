using Aplication.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Handler.Command
{
    public class UpdatePedidoCommand : IRequest<UpdatePedidoCommandResponse>
    {
        public PedidoInputDto Pedido { get; set; }

        public UpdatePedidoCommand(PedidoInputDto pedido)
        {
            Pedido = pedido;
        }
    }

    public class UpdatePedidoCommandResponse
    {
        public PedidoOutputDto Pedido { get; set; }

        public UpdatePedidoCommandResponse(PedidoOutputDto pedido)
        {
            Pedido = pedido;
        }
    }
}
