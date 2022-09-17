using Aplication.Handler.Command;
using Aplication.Handler.Query;
using Aplication.Service;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Handler
{
    public class ProdutoHandler : IRequestHandler<CreateProdutoCommand, CreateProdutoCommandResponse>,
                                IRequestHandler<UpdateProdutoCommand, UpdateProdutoCommandResponse>,
                                IRequestHandler<DeleteProdutoCommand, DeleteProdutoCommandResponse>,
                                IRequestHandler<GetAllProdutoQuery, GetAllProdutoQueryResponse>,
                                IRequestHandler<GetProdutoQuery, GetProdutoQueryResponse>

    {
        private readonly IProdutoService _produtoService;

        public ProdutoHandler(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        public async Task<CreateProdutoCommandResponse> Handle(CreateProdutoCommand request, CancellationToken cancellationToken)
        {
            var result = await _produtoService.Criar(request.Produto);
            return new CreateProdutoCommandResponse(result);
        }

        public async Task<UpdateProdutoCommandResponse> Handle(UpdateProdutoCommand request, CancellationToken cancellationToken)
        {
            var result = await _produtoService.Atualizar(request.Produto);
            return new UpdateProdutoCommandResponse(result);
        }

        public async Task<DeleteProdutoCommandResponse> Handle(DeleteProdutoCommand request, CancellationToken cancellationToken)
        {
            var result = await _produtoService.Deletar(request.Produto);
            return new DeleteProdutoCommandResponse(result);
        }

        public async Task<GetAllProdutoQueryResponse> Handle(GetAllProdutoQuery request, CancellationToken cancellationToken)
        {
            var result = await _produtoService.ObterTodos();
            return new GetAllProdutoQueryResponse(result);
        }

        public async Task<GetProdutoQueryResponse> Handle(GetProdutoQuery request, CancellationToken cancellationToken)
        {
            var result = await _produtoService.ObterPorId(request.IdProduto);
            return new GetProdutoQueryResponse(result);
        }
    }
}
