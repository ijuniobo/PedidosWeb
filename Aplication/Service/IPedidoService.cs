using Aplication.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Service
{
    public interface IPedidoService
    {
        Task<PedidoOutputDto> Criar(PedidoInputDto dto);
        Task<PedidoOutputDto> Atualizar(PedidoInputDto dto);
        Task<PedidoOutputDto> Deletar(PedidoInputDto dto);
        Task<PedidoOutputDto> ObterPorId(int id);
        Task<List<PedidoOutputDto>> ObterTodos();

    }
}
