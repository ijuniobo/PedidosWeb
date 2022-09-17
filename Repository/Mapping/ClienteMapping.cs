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
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(500);
            builder.Property(x => x.Endereco).IsRequired().HasMaxLength(500);
            builder.Property(x => x.Bairro).IsRequired().HasMaxLength(300);
            builder.Property(x => x.Cidade).IsRequired().HasMaxLength(500);
            builder.Property(x => x.Cep).IsRequired().HasMaxLength(9);
            builder.Property(x => x.Cpf).HasMaxLength(20);
            builder.Property(x => x.Cnpj).HasMaxLength(20);
            builder.Property(x => x.Complemento).HasMaxLength(500);
            builder.Property(x => x.Login).IsRequired().HasMaxLength(500);
            builder.Property(x => x.Senha).IsRequired().HasMaxLength(8);
            builder.Property(x => x.TipoPessoa).HasMaxLength(50);

            builder.HasMany(x => x.Pedidos).WithOne().OnDelete(DeleteBehavior.Cascade);
        }
    }
}
