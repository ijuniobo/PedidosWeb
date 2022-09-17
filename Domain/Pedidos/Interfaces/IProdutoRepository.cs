using CrossCutting.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Pedidos.Interfaces
{
    public interface IProdutoRepository : IRepository<Produto>
    {
    }
}
