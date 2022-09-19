using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Dtos
{
    public record PedidoInputDto(int Id, int IdCliente, DateTime DataPedido, DateTime DataEnvio, int QuantidadeTotal, decimal ValorTotal, decimal Desconto, decimal ValorLiquido);

    public record PedidoOutputDto(int Id, int IdCliente, DateTime DataPedido, DateTime DataEnvio, int QuantidadeTotal, decimal ValorTotal, decimal Desconto, decimal ValorLiquido);

}
