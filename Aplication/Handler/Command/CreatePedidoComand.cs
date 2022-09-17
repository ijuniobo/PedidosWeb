using Aplication.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Handler.Command
{
    public class CreatePedidoCommand : IRequest<CreatePedidoCommandResponse>
    {
        public PedidoInputDto Pedido { get; set; }

        public CreatePedidoCommand(PedidoInputDto pedido)
        {
            Pedido = pedido;
        }
    }

    public class CreatePedidoCommandResponse
    {
        public PedidoOutputDto Pedido { get; set; }

        public CreatePedidoCommandResponse(PedidoOutputDto pedido)
        {
            Pedido = pedido;
        }
    }

}
