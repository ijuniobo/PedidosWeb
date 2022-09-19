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
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Descricao).IsRequired().HasMaxLength(1500);
            builder.Property(x => x.TipoProduto).IsRequired().HasMaxLength(500);
            builder.Property(x => x.CodigoBarras).IsRequired().HasMaxLength(13);

            builder.HasMany(x => x.ItensPedido).WithOne();
        }
    }
}
