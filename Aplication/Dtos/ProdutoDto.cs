using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Dtos
{
    public record ProdutoInputDto(int Id, string Descricao, string CodigoBarras, string TipoProduto, decimal PrecoCusto, decimal PrecoVenda, int Estoque);

    public record ProdutoOutputDto(int Id, string Descricao, string CodigoBarras, string TipoProduto, decimal PrecoCusto, decimal PrecoVenda, int Estoque);

}
