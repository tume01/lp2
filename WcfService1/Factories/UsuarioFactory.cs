using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1.Factories
{
    public class UsuarioFactory
    {
        public UsuarioFactory()
        {

        }

        public static Usuario create(MySqlDataReader reader)
        {
            string user = reader["userName"].ToString();
            string pass = reader["pass"].ToString();
            int    tipo = Int32.Parse(reader["tipo"].ToString());

            Usuario newUsuario = new Usuario();
            newUsuario.Pass     = pass;
            newUsuario.Tipo     = tipo;
            newUsuario.UserName = user;

            return newUsuario;  
        }
    }
}