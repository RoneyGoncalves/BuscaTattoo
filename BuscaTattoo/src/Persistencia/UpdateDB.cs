using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaTattoo.src.Persistencia
{
    class UpdateDB
    {
        public String updateCPF = "update pessoa set nome = @nome, login = @login, senha = @senha where cpf = @cpf";
    }
}
