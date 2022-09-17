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
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;

        public ClienteService(IClienteRepository clienteRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }

        public async Task<ClienteOutputDto> Criar(ClienteInputDto dto)
        {
            var cliente = _mapper.Map<Cliente>(dto);

            await _clienteRepository.Save(cliente);

            return _mapper.Map<ClienteOutputDto>(cliente);

        }

        public async Task<ClienteOutputDto> Atualizar(ClienteInputDto dto)
        {
            var cliente = _mapper.Map<Cliente>(dto);

            await _clienteRepository.Update(cliente);

            return _mapper.Map<ClienteOutputDto>(cliente);

        }

        public async Task<ClienteOutputDto> Deletar(ClienteInputDto dto)
        {
            var cliente = _mapper.Map<Cliente>(dto);

            await _clienteRepository.Delete(cliente);

            return _mapper.Map<ClienteOutputDto>(cliente);

        }

        public async Task<List<ClienteOutputDto>> ObterTodos()
        {
            var cliente = await _clienteRepository.GetAll();

            return _mapper.Map<List<ClienteOutputDto>>(cliente);
        }

        public async Task<ClienteOutputDto> ObterPorId(int id)
        {
            var cliente = await _clienteRepository.Get(id);

            return _mapper.Map<ClienteOutputDto>(cliente);

        }
    }
}
