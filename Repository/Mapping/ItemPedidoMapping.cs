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
    public class ItemPedidoMapping : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.ToTable("ItemPedido");
            builder.HasKey(x => x.Id);

            builder.HasOne(c => c.Produto)
                   .WithMany(e => e.ItensPedido)
                   .HasForeignKey(e=> e.IdProduto);

            builder.HasOne(c => c.Pedido)
                   .WithMany(e => e.Itens)
                   .HasForeignKey(e => e.IdPedido);

        }
    }
}
