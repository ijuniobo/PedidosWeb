using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Pedidos
{
    public class Produto
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public string CodigoBarras { get; set; }

        public string TipoProduto { get; set; }

        public decimal PrecoCusto { get; set; }

        public decimal PrecoVenda { get; set; }

        public int Estoque { get; set; }

        public List<ItemPedido> ItensPedido { get; set; }

    }
}
