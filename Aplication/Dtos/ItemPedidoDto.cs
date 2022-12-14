using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Dtos
{
    public record ItemPedidoInputDto(int Id, int Quantidade, decimal PrecoUnitario, decimal PrecoTotal, decimal Desconto, int IdProduto, int IdPedido);

    public record ItemPedidoOutputDto(int Id, int Quantidade, decimal PrecoUnitario, decimal PrecoTotal, decimal Desconto, int IdProduto, int IdPedido);

}
