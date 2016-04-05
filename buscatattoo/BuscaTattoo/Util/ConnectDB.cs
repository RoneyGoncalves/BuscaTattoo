using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BuscaTattoo.Model
{
    public class LoginDAO
    {
        //Conecta ao banco
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Roninho\documents\visual studio 2012\Projects\BuscaTattoo\BuscaTattoo\DatabaseBuscaTattoo.mdf;Integrated Security=True");

    }
}
