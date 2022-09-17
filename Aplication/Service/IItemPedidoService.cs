using Aplication.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Service
{
    public interface IItemPedidoService
    {
        Task<ItemPedidoOutputDto> Criar(ItemPedidoInputDto dto);
        Task<ItemPedidoOutputDto> Atualizar(ItemPedidoInputDto dto);
        Task<ItemPedidoOutputDto> Deletar(ItemPedidoInputDto dto);
        Task<ItemPedidoOutputDto> ObterPorId(int id);
        Task<List<ItemPedidoOutputDto>> ObterTodos();

    }
}
