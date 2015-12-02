using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class AlumnoRepository
    {
        public static string connecString = "Server=localhost;Port=3306;Database=lp2;Uid=root;password=secret;";

        public AlumnoRepository()
        {

        }

        public static int insertAlumno(Alumno alumno)
        {
            MySqlConnection connection = new MySqlConnection(connecString);
            connection.Open();
            MySqlCommand command = connection.CreateCommand();

            command.CommandText = "insert into alumno (codigo,nombre,dni,correo,telefono,ciclo,creditos,especialidadActual,especialidadAnterior,resumenReuniones,unidad,tutor) values('"+alumno.Codigo+"','" + alumno.Nombre + "','" + alumno.Dni + "','" + alumno.Correo + "','" + alumno.Telefono + "','" + alumno.Ciclo + "','"+alumno.Creditos+"','" + alumno.EspecialidadActual.Codigo + "','" + alumno.EspecialidadAnterior.Codigo + "','" + alumno.ResumenReuniones + "','" + alumno.Unidad + "','" + alumno.Tutor.Codigo + "');";

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