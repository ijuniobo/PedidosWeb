using Aplication.Dtos;
using Domain.Pedidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Profile
{
    public class PedidoProfile : AutoMapper.Profile
    {
        public PedidoProfile()
        {
            CreateMap<Cliente, ClienteOutputDto>();

            CreateMap<ClienteInputDto, Cliente>();

            CreateMap<ItemPedido, ItemPedidoOutputDto>();

            CreateMap<ItemPedidoInputDto, ItemPedido>();

            CreateMap<PedidoInputDto, Pedido>();

            CreateMap<Pedido, PedidoOutputDto>();

            CreateMap<ProdutoInputDto, Produto>();

            CreateMap<Produto, ProdutoOutputDto>();


        }

    }
}
