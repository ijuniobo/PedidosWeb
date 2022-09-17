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
    public class PedidoService : IPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IMapper _mapper;

        public PedidoService(IPedidoRepository pedidoRepository, IMapper mapper)
        {
            _pedidoRepository = pedidoRepository;
            _mapper = mapper;
        }

        public async Task<PedidoOutputDto> Criar(PedidoInputDto dto)
        {
            var pedido = _mapper.Map<Pedido>(dto);

            await _pedidoRepository.Save(pedido);

            return _mapper.Map<PedidoOutputDto>(pedido);

        }

        public async Task<PedidoOutputDto> Atualizar(PedidoInputDto dto)
        {
            var pedido = _mapper.Map<Pedido>(dto);

            await _pedidoRepository.Update(pedido);

            return _mapper.Map<PedidoOutputDto>(pedido);

        }

        public async Task<PedidoOutputDto> Deletar(PedidoInputDto dto)
        {
            var pedido = _mapper.Map<Pedido>(dto);

            await _pedidoRepository.Delete(pedido);

            return _mapper.Map<PedidoOutputDto>(pedido);

        }

        public async Task<List<PedidoOutputDto>> ObterTodos()
        {
            var pedido = await _pedidoRepository.GetAll();

            return _mapper.Map<List<PedidoOutputDto>>(pedido);
        }

        public async Task<PedidoOutputDto> ObterPorId(int id)
        {
            var pedido = await _pedidoRepository.Get(id);

            return _mapper.Map<PedidoOutputDto>(pedido);

        }
    }
}
