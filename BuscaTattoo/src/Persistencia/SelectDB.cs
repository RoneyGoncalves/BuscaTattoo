using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaTattoo.src.Persistencia
{
    class SelectDB
    {
        public String verificalogin = "select login,senha from pessoa where login = @login and senha = @senha";
        public String verificaCPF = "select cpf from pessoa where cpf = @cpf";
    }
}
