using Aplication.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Handler.Command
{
    public class CreateClienteCommand : IRequest<CreateClienteCommandResponse>
    {
        public ClienteInputDto Cliente { get; set; }

        public CreateClienteCommand(ClienteInputDto cliente)
        {
            Cliente = cliente;
        }
    }

    public class CreateClienteCommandResponse
    {
        public ClienteOutputDto Cliente { get; set; }

        public CreateClienteCommandResponse(ClienteOutputDto cliente)
        {
            Cliente = cliente;
        }
    }
}
