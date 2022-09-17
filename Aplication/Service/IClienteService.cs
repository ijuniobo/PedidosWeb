using Aplication.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Service
{
    public interface IClienteService
    {
        Task<ClienteOutputDto> Criar(ClienteInputDto dto);
        Task<ClienteOutputDto> Atualizar(ClienteInputDto dto);
        Task<ClienteOutputDto> Deletar(ClienteInputDto dto);
        Task<ClienteOutputDto> ObterPorId(int id);
        Task<List<ClienteOutputDto>> ObterTodos();

    }
}
