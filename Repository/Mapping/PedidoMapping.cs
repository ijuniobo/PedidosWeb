using Domain.Pedidos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Mapping
{
    public class PedidoMapping : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("Pedido");
            builder.HasKey(x => x.Id);

            builder.HasOne(c => c.Cliente)
                   .WithMany(e => e.Pedidos)
                   .HasForeignKey(e => e.IdCliente);

            builder.HasMany(c => c.Itens).WithOne();

        }
    }
}
