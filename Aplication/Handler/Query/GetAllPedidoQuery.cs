using Aplication.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Handler.Query
{
    public class GetAllPedidoQuery : IRequest<GetAllPedidoQueryResponse>
    {

    }

    public class GetAllPedidoQueryResponse
    {
        public IList<PedidoOutputDto> Pedidos { get; set; }

        public GetAllPedidoQueryResponse(IList<PedidoOutputDto> pedidos)
        {
            Pedidos = pedidos;
        }
    }
}
