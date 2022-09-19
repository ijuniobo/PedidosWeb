using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Dtos
{
    public record ClienteInputDto(int Id, string Nome, string Endereco,string Cidade,string Bairro,string Complemento, string Cep,string Cpf,string Cnpj,string TipoPessoa,string Login,string Senha);

    public record ClienteOutputDto(int Id, string Nome, string Endereco, string Cidade, string Bairro, string Complemento, string Cep, string Cpf, string Cnpj, string TipoPessoa, string Login, string Senha);

}
