using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Dtos
{
    public class ProdutoInputDto
    {
        public int Id { get; set; }

        public string descricao { get; set; }

        public string CodigoBarras { get; set; }

        public string TipoProduto { get; set; }

        public decimal PrecoCusto { get; set; }

        public decimal PrecoVenda { get; set; }

        public int Estoque { get; set; }

        public string Foto { get; set; }
    }

    public record ProdutoOutputDto(int Id, string Descricao, string CodigoBarras, string TipoProduto, decimal PrecoCusto, decimal PrecoVenda, int Estoque,string Foto);

}
