using Aplication.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Handler.Query
{
    public class GetClienteQuery : IRequest<GetClienteQueryResponse>
    {
        public int IdCliente { get; set; }

        public GetClienteQuery(int id)
        {
            IdCliente = id;
        }


    }

    public class GetClienteQueryResponse
    {
        public ClienteOutputDto Cliente { get; set; }

        public GetClienteQueryResponse(ClienteOutputDto cliente)
        {
            Cliente = cliente;
        }
    }
}
