using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Pedidos
{
    public class ItemPedido
    {
        public int Id { get; set; }

        public int Quantidade { get; set; }

        public decimal PrecoUnitario { get; set; }

        public decimal PrecoTotal { get; set; }

        public decimal Desconto { get; set; }

        public int IdProduto { get; set; }

        public int IdPedido { get; set; }

        public Produto Produto { get; set; }

        public Pedido Pedido { get; set; }
    }
}
