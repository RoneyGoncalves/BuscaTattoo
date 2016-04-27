using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaTattoo.src.Persistencia
{
    class InsertDB
    {
        public String insertnewsystemuser = "insert into pessoa (nome,cpf,login,senha,endereco,email,dob,telefone,dta_cadastro) values (@nome,@cpf,@login,@senha,@endereco,@email,@dob,@telefone,@dta_cadastro)";
        public String inserenovocliente = "insert into pessoa(nome,cpf,login,senha,endereco,email,dob,telefone,dta_cadastro)values(@nome,@cpf,null,null,@endereco,@email,@dob,@telefone,@dta_cadastro)";
    }
}
