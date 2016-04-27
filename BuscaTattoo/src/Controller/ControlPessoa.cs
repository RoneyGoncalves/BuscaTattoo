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

        //Instancializa a classe UpdateDB
        UpdateDB update = new UpdateDB();

        //Instancializa a classe InsertDB
        InsertDB insert = new InsertDB();

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

        public int atualizaCadastroCPF(String nome, String cpf, String endereco, String email, String dob, String telefone, String dta_cadastro) 
        {
            //Instancializa SqlConnection
            SqlConnection conn = new SqlConnection(connect.connectDB);

            //Instancializa SqlCommand
            SqlCommand command = new SqlCommand(update.updateClienteCPF,conn);

            //Abre a conexão
            conn.Open();

            command.Parameters.AddWithValue("@nome",nome);
            command.Parameters.AddWithValue("@cpf",cpf);
            command.Parameters.AddWithValue("@endereco",endereco);
            command.Parameters.AddWithValue("@email",email);
            command.Parameters.AddWithValue("@dob",dob);
            command.Parameters.AddWithValue("@telefone",telefone);
            command.Parameters.AddWithValue("@dta_cadastro",dta_cadastro);

            //Armazena o resultado do script
            int result = command.ExecuteNonQuery();

            //Retorna o resultado do script
            return result;

        }//Fim do atualizacadastrocpf

        public int insereNovoCliente(String nome, String cpf, String endereco, String email, String dob, String telefone, String dta_cadastro) 
        {
            //Instancializa SqlConnection
            SqlConnection conn = new SqlConnection(connect.connectDB);

            //Instancializa SqlCommand
            SqlCommand command = new SqlCommand(insert.inserenovocliente, conn);

            //Abre a conexão
            conn.Open();

            command.Parameters.AddWithValue("@nome", nome);
            command.Parameters.AddWithValue("@cpf", cpf);
            command.Parameters.AddWithValue("@endereco", endereco);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@dob", dob);
            command.Parameters.AddWithValue("@telefone", telefone);
            command.Parameters.AddWithValue("@dta_cadastro", dta_cadastro);

            int result = command.ExecuteNonQuery();

            return result;
        }//Fim do insereNovoCliente

    }//End of Class ControlPessoa
}//End of Namespace
