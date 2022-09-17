using Aplication.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Handler.Query
{
    public class GetItemPedidoQuery : IRequest<GetItemPedidoQueryResponse>
    {
        public int IdItemPedido { get; set; }

        public GetItemPedidoQuery(int id)
        {
            IdItemPedido = id;
        }


    }

    public class GetItemPedidoQueryResponse
    {
        public ItemPedidoOutputDto ItemPedido { get; set; }

        public GetItemPedidoQueryResponse(ItemPedidoOutputDto itemPedido)
        {
            ItemPedido = itemPedido;
        }
    }
}
