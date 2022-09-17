using Aplication.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Handler.Command
{
    public class DeleteProdutoCommand : IRequest<DeleteProdutoCommandResponse>
    {
        public ProdutoInputDto Produto { get; set; }

        public DeleteProdutoCommand(ProdutoInputDto produto)
        {
            Produto = produto;
        }
    }

    public class DeleteProdutoCommandResponse
    {
        public ProdutoOutputDto Produto { get; set; }

        public DeleteProdutoCommandResponse(ProdutoOutputDto produto)
        {
            Produto = produto;
        }
    }
}
