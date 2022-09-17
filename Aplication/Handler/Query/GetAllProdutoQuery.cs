using Aplication.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Handler.Query
{
    public class GetAllProdutoQuery : IRequest<GetAllProdutoQueryResponse>
    {

    }

    public class GetAllProdutoQueryResponse
    {
        public IList<ProdutoOutputDto> Produtos { get; set; }

        public GetAllProdutoQueryResponse(IList<ProdutoOutputDto> produtos)
        {
            Produtos = produtos;
        }
    }
}
