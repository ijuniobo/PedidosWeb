using Aplication.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Handler.Command
{
    public class DeleteClienteCommand : IRequest<DeleteClienteCommandResponse>
    {
        public ClienteInputDto Cliente { get; set; }

        public DeleteClienteCommand(ClienteInputDto cliente)
        {
            Cliente = cliente;
        }
    }

    public class DeleteClienteCommandResponse
    {
        public ClienteOutputDto Cliente { get; set; }

        public DeleteClienteCommandResponse(ClienteOutputDto cliente)
        {
            Cliente = cliente;
        }
    }
}
