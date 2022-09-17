using Domain.Pedidos;
using Domain.Pedidos.Interfaces;
using Repository.Context;
using Repository.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class ItemPedidoRepository : Repository<ItemPedido>, IItemPedidoRepository
    {
        public ItemPedidoRepository(PedidosContext context) : base(context)
        {

        }

    }
}
