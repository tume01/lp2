using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService1.Factories;
namespace WcfService1.Persistances
{
    public class UserPersistance
    {
        public static string connecString = "Server=localhost;Port=3306;Database=lp2;Uid=root;password=secret;";

        public UserPersistance()
        {

        }

        public static Usuario getUserById(string user)
        {
            MySqlConnection connection = new MySqlConnection(connecString);
            MySqlCommand command = connection.CreateCommand();
            connection.Open();
            command.CommandText = "select * from usuarios where userName =" + user + ";";
            Usuario newUsuario = null;
            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    newUsuario = UsuarioFactory.create(reader);
                }

            }
            catch (Exception e)
            {
                string message = e.Message;
            }
            
           
            
            return newUsuario;
        }
    }
}