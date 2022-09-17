using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Pedidos
{
    public class Pedido
    {
        public int Id { get; set; }

        public int IdCliente { get; set; }

        public DateTime DataPedido { get; set; }

        public DateTime DataEnvio { get; set; }

        public int QuantidadeTotal { get; set; }

        public decimal ValorTotal { get; set; }

        public decimal Desconto { get; set; }

        public decimal ValorLiquido { get; set; }

        public Cliente Cliente { get; set; }

        public List<ItemPedido> Itens { get; set; }


    }
}
