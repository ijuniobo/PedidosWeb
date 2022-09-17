using Aplication.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Handler.Command
{
    public class UpdateClienteCommand : IRequest<UpdateClienteCommandResponse>
    {
        public ClienteInputDto Cliente { get; set; }

        public UpdateClienteCommand(ClienteInputDto cliente)
        {
            Cliente = cliente;
        }
    }

    public class UpdateClienteCommandResponse
    {
        public ClienteOutputDto Cliente { get; set; }

        public UpdateClienteCommandResponse(ClienteOutputDto cliente)
        {
            Cliente = cliente;
        }
    }
}
