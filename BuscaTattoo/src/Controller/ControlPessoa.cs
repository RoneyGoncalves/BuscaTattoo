using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BuscaTattoo.src.Persistencia;

namespace BuscaTattoo.src.Controller
{
    class ControlPessoa
    {
        //Instancializa a classe ConnectDB
        ConnectDB connect = new ConnectDB();

        //Instancializa a classe SelectDB
        SelectDB select = new SelectDB();

        public bool verificaIfExistCPFinDB(String cpf)
        {
            //Instancialica SqlConnection passando a string de conexão que está em ConnectDB
            SqlConnection conn = new SqlConnection(connect.connectDB);

            //Instancializa SqlCommand passando verificaCPF como argumento
            SqlCommand command = new SqlCommand(select.verificaCPF,conn);

            //Abre a conexão
            conn.Open();

            //Passa os Parâmetros para o comando
            command.Parameters.AddWithValue("@cpf",cpf);

            //Armazena o resultado do comando
            var result = command.ExecuteReader();

            //Retorna o resultado
            return result.HasRows;
        }//Enf of verificaIfExistCPFinDB
    }//End of Class ControlPessoa
}//End of Namespace
