using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1.Repositories
{
    public class UsuarioRepository
    {
        public static string connecString = ConfigDB.configDB.connectString();

        public UsuarioRepository()
        {

        }

        public static int insert(Usuario newUsuario)
        {
            MySqlConnection connection = new MySqlConnection(connecString);
            connection.Open();
            MySqlCommand command = connection.CreateCommand();

            command.CommandText = "insert into usuarios (userName,pass,tipo) values('" + newUsuario.UserName + "','"+ newUsuario.Pass + "','" + newUsuario.Tipo + "');";

            try
            {
                command.ExecuteNonQuery();
                connection.Close();
                return 1;
            }
            catch (Exception e)
            {
                connection.Close();
                return 0;
            }
        }
    }
}