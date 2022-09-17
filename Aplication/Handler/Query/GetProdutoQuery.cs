using Aplication.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Handler.Query
{
    public class GetProdutoQuery : IRequest<GetProdutoQueryResponse>
    {
        public int IdProduto { get; set; }

        public GetProdutoQuery(int id)
        {
            IdProduto = id;
        }


    }

    public class GetProdutoQueryResponse
    {
        public ProdutoOutputDto Produto { get; set; }

        public GetProdutoQueryResponse(ProdutoOutputDto produto)
        {
            Produto = produto;
        }
    }
}
