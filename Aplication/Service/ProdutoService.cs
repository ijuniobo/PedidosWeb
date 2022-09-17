using Aplication.Dtos;
using AutoMapper;
using Domain.Pedidos;
using Domain.Pedidos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;

        public ProdutoService(IProdutoRepository produtoRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }

        public async Task<ProdutoOutputDto> Criar(ProdutoInputDto dto)
        {
            var produto = _mapper.Map<Produto>(dto);

            await _produtoRepository.Save(produto);

            return _mapper.Map<ProdutoOutputDto>(produto);

        }

        public async Task<ProdutoOutputDto> Atualizar(ProdutoInputDto dto)
        {
            var produto = _mapper.Map<Produto>(dto);

            await _produtoRepository.Update(produto);

            return _mapper.Map<ProdutoOutputDto>(produto);

        }

        public async Task<ProdutoOutputDto> Deletar(ProdutoInputDto dto)
        {
            var produto = _mapper.Map<Produto>(dto);

            await _produtoRepository.Delete(produto);

            return _mapper.Map<ProdutoOutputDto>(produto);

        }

        public async Task<List<ProdutoOutputDto>> ObterTodos()
        {
            var produto = await _produtoRepository.GetAll();

            return _mapper.Map<List<ProdutoOutputDto>>(produto);
        }

        public async Task<ProdutoOutputDto> ObterPorId(int id)
        {
            var produto = await _produtoRepository.Get(id);

            return _mapper.Map<ProdutoOutputDto>(produto);

        }
    }
}
