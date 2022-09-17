using Aplication.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Handler.Command
{
    public class CreateProdutoCommand : IRequest<CreateProdutoCommandResponse>
    {
        public ProdutoInputDto Produto { get; set; }

        public CreateProdutoCommand(ProdutoInputDto produto)
        {
            Produto = produto;
        }
    }

    public class CreateProdutoCommandResponse
    {
        public ProdutoOutputDto Produto { get; set; }

        public CreateProdutoCommandResponse(ProdutoOutputDto produto)
        {
            Produto = produto;
        }
    }
}
