using Aplication.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Handler.Command
{
    public class UpdateProdutoCommand : IRequest<UpdateProdutoCommandResponse>
    {
        public ProdutoInputDto Produto { get; set; }

        public UpdateProdutoCommand(ProdutoInputDto produto)
        {
            Produto = produto;
        }
    }

    public class UpdateProdutoCommandResponse
    {
        public ProdutoOutputDto Produto { get; set; }

        public UpdateProdutoCommandResponse(ProdutoOutputDto produto)
        {
            Produto = produto;
        }
    }
}
