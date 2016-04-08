using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuscaTattoo.src.Persistencia;

namespace BuscaTattoo.src.Persistencia
{
    class LoginDAO
    {
        String verificalogin;

        //Cria um objeto para usar a string de conexão com o banco
        ConnectDB connect = new ConnectDB();

        public LoginDAO()
        {
            verificalogin = "select login,senha from pessoa where login = @login and senha = @senha";
        }//End of LoginDAO()

        public bool Verificalogin(String login, String senha)
        {
            //Cria um objeto conn passando connect como argumento
            SqlConnection conn = new SqlConnection(connect.connectDB);

            //Cria um objeto command passando verificalogin e conn como argumento
            SqlCommand command = new SqlCommand(verificalogin, conn);

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
    }//End of class LoginDAO
}//End of namespace
