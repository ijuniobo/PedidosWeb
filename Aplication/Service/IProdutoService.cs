using Aplication.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Service
{
    public interface IProdutoService
    {
        Task<ProdutoOutputDto> Criar(ProdutoInputDto dto);
        Task<ProdutoOutputDto> Atualizar(ProdutoInputDto dto);
        Task<ProdutoOutputDto> Deletar(ProdutoInputDto dto);
        Task<ProdutoOutputDto> ObterPorId(int id);
        Task<List<ProdutoOutputDto>> ObterTodos();

    }
}
