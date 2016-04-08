using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuscaTattoo.src.Persistencia;
using System.Data.SqlClient;

namespace BuscaTattoo.src.Controller
{
    class ControlLogin
    {
        //Instancializa a classe ConnectDB para se conectar ao banco
        ConnectDB connect = new ConnectDB();
        
        //Instancializa a classe SelectDB para realizar consultas no banco
        SelectDB select = new SelectDB();

        //Instancializa a classe InsertDB para realizar inserts
        InsertDB insert = new InsertDB();

        //Instancializa a classe UpdateDB para realizar updates
        UpdateDB update = new UpdateDB();

        public bool Verificalogin(String login, String senha)
        {
            //Cria um objeto conn passando connect como argumento
            SqlConnection conn = new SqlConnection(connect.connectDB);

            //Cria um objeto command passando verificalogin e conn como argumento
            SqlCommand command = new SqlCommand(select.verificalogin, conn);

            //Abre a conexão
            conn.Open();

            //Passa os comandos sql
            command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@senha", senha);

            //Armazena o resultado do comando
            var result = command.ExecuteReader();

            //Retorna o resultado do comando
            return result.HasRows;
        }//End of Verificalogin()

        public bool Verificasejatemcadastro(String cpf)
        {
            //Cria um objeto conn passando connect como argumento
            SqlConnection conn = new SqlConnection(connect.connectDB);

            //Cria um objeto command passando verificalogin e conn como argumento
            SqlCommand command = new SqlCommand(select.verificaCPF, conn);

            //Abre a conexão
            conn.Open();

            //Passa o parametro para o select
            command.Parameters.AddWithValue("@cpf",cpf);

            //Armazena o resultado do select
            var result = command.ExecuteReader();

            //Retorna o resultado
            return result.HasRows;
        }//End of Verificasejatemcadastro

        public int Inserenovologin(String nome, String cpf, String login, String senha, String endereco, String email, String dob, String telefone, String dta_cadastro)
        {
            //Cria um objeto conn passando connect como argumento
            SqlConnection conn = new SqlConnection(connect.connectDB);

            //Cria um objeto command passando verificalogin e conn como argumento
            SqlCommand command = new SqlCommand(insert.insertnewsystemuser, conn);

            //Abre a conexão
            conn.Open();

            //Passa os parametros para o insert
            command.Parameters.AddWithValue("@nome",nome);
            command.Parameters.AddWithValue("@cpf", cpf);
            command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@senha", senha);
            command.Parameters.AddWithValue("@endereco", endereco);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@dob", dob);
            command.Parameters.AddWithValue("@telefone", telefone);
            command.Parameters.AddWithValue("@dta_cadastro", dta_cadastro);

            //Armazena o resultado do script
            int result = command.ExecuteNonQuery();

            //Retorna o resultado
            return result;
        }//End of Inserenovologin();

        public int Atualizacadastrologin(String nome, String cpf, String login, String senha) 
        {
            //Cria um objeto conn passando connect como argumento
            SqlConnection conn = new SqlConnection(connect.connectDB);

            //Cria um objeto command passando verificalogin e conn como argumento
            SqlCommand command = new SqlCommand(update.updateCPF, conn);

            //Abre a conexão
            conn.Open();

            //Passa os parametros para o update
            command.Parameters.AddWithValue("@nome",nome);
            command.Parameters.AddWithValue("@cpf",cpf);
            command.Parameters.AddWithValue("@login",login);
            command.Parameters.AddWithValue("@senha",senha);

            //Armazena o resultado do script
            int result = command.ExecuteNonQuery();

            //Retorna o resultado
            return result;
        }//End of Atualizacadastrologin()
    }//End of ControlLogin
}//End of namespace
