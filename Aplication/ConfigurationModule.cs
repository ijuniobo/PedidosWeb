using Aplication.Service;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Aplication
{
    public  static class ConfigurationModule
    {

        public static IServiceCollection RegisterApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ConfigurationModule).Assembly);

            services.AddMediatR(typeof(ConfigurationModule).Assembly);

            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IItemPedidoService, ItemPedidoService>();
            services.AddScoped<IPedidoService, PedidoService>();
            services.AddScoped<IProdutoService, ProdutoService>();

            return services;
        }

    }
}
