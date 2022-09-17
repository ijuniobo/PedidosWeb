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
    public class ItemPedidoService : IItemPedidoService
    {
        private readonly IItemPedidoRepository _itemPedidoRepository;
        private readonly IMapper _mapper;

        public ItemPedidoService(IItemPedidoRepository itemPedidoRepository, IMapper mapper)
        {
            _itemPedidoRepository = itemPedidoRepository;
            _mapper = mapper;
        }

        public async Task<ItemPedidoOutputDto> Criar(ItemPedidoInputDto dto)
        {
            var itemPedido = _mapper.Map<ItemPedido>(dto);

            await _itemPedidoRepository.Save(itemPedido);

            return _mapper.Map<ItemPedidoOutputDto>(itemPedido);

        }

        public async Task<ItemPedidoOutputDto> Atualizar(ItemPedidoInputDto dto)
        {
            var itemPedido = _mapper.Map<ItemPedido>(dto);

            await _itemPedidoRepository.Update(itemPedido);

            return _mapper.Map<ItemPedidoOutputDto>(itemPedido);

        }

        public async Task<ItemPedidoOutputDto> Deletar(ItemPedidoInputDto dto)
        {
            var itemPedido = _mapper.Map<ItemPedido>(dto);

            await _itemPedidoRepository.Delete(itemPedido);

            return _mapper.Map<ItemPedidoOutputDto>(itemPedido);

        }

        public async Task<List<ItemPedidoOutputDto>> ObterTodos()
        {
            var itemPedido = await _itemPedidoRepository.GetAll();

            return _mapper.Map<List<ItemPedidoOutputDto>>(itemPedido);
        }

        public async Task<ItemPedidoOutputDto> ObterPorId(int id)
        {
            var itemPedido = await _itemPedidoRepository.Get(id);

            return _mapper.Map<ItemPedidoOutputDto>(itemPedido);

        }
    }
}
