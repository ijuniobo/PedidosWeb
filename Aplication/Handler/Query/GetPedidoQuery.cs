using Aplication.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Handler.Query
{
    public class GetPedidoQuery : IRequest<GetPedidoQueryResponse>
    {
        public int IdPedido { get; set; }

        public GetPedidoQuery(int id)
        {
            IdPedido = id;
        }


    }

    public class GetPedidoQueryResponse
    {
        public PedidoOutputDto Pedido { get; set; }

        public GetPedidoQueryResponse(PedidoOutputDto pedido)
        {
            Pedido = pedido;
        }
    }
}
