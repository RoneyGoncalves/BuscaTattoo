using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaTattoo.src.Persistencia
{
    class UpdateDB
    {
        public String updateLoginCPF = "update pessoa set nome = @nome, login = @login, senha = @senha, endereco = @endereco, email = @email, dob = @dob, telefone = @telefone, dta_cadastro = @dta_cadastro where cpf = @cpf";
        public String updateClienteCPF = "update pessoa set nome = @nome, endereco = @endereco, email = @email, dob = @dob, telefone = @telefone, dta_cadastro = @dta_cadastro where cpf = @cpf";
    }
}
