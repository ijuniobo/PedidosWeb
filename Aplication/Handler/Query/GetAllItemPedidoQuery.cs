using Aplication.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Handler.Query
{
    public class GetAllItemPedidoQuery : IRequest<GetAllItemPedidoQueryResponse>
    {

    }

    public class GetAllItemPedidoQueryResponse
    {
        public IList<ItemPedidoOutputDto> ItensPedido { get; set; }

        public GetAllItemPedidoQueryResponse(IList<ItemPedidoOutputDto> itensPedido)
        {
            ItensPedido = itensPedido;
        }
    }
}
