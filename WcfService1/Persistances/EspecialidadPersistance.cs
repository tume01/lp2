using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class EspecialidadPersistance
    {
        public static string connecString = "Server=localhost;Port=3306;Database=lp2;Uid=root;password=secret;";

        public EspecialidadPersistance()
        {

        }

        public static Especialidad getEspecialidadByCodigo(int codigo)
        {

            MySqlConnection connection = new MySqlConnection(connecString);
            connection.Open();
            MySqlCommand command = connection.CreateCommand();

            command.CommandText = "select * from  especialidad where codigo =" + codigo + ";";

            MySqlDataReader reader = command.ExecuteReader();
            Especialidad newEspecialidad = null;
            while (reader.Read())
            {
                newEspecialidad = EspecialidadFactory.create(reader);

            }
            connection.Close();
            return newEspecialidad;
        }
    }
}