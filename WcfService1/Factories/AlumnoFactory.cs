using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WcfService1
{
    public class AlumnoFactory
    {
        public static  Alumno create(MySqlDataReader reader)
        {
            int codigo = Int32.Parse(reader["codigo"].ToString());
            string nombre = reader["nombre"].ToString();
            int dni = Int32.Parse(reader["dni"].ToString());
            string correo = reader["correo"].ToString();
            int telefono = Int32.Parse(reader["telefono"].ToString());
            int ciclo = Int32.Parse(reader["ciclo"].ToString());
            int creditos = Int32.Parse(reader["creditos"].ToString());
            string resumenReuniones = reader["resumenReuniones"].ToString();
            string unidad = reader["unidad"].ToString();
            int codigoEspecialidad = Int32.Parse(reader["especialidadActual"].ToString());
            Especialidad especialidadActual = EspecialidadPersistance.getEspecialidadByCodigo(codigoEspecialidad);
            int codigoEspecialidadAnterior = Int32.Parse(reader["especialidadAnterior"].ToString());
            Especialidad especialidadAnterior = EspecialidadPersistance.getEspecialidadByCodigo(codigoEspecialidadAnterior);

            Alumno newAlumno = new Alumno(codigo, nombre, dni, correo, telefono, ciclo, creditos, especialidadActual, especialidadAnterior, resumenReuniones, unidad);
            int codigoTutor = Int32.Parse(reader["tutor"].ToString());
            newAlumno.Tutor = ProfesorPersistance.getProfesorByCodigo(codigoTutor);

            return newAlumno;
        }

        public AlumnoFactory()
        {

        }
    }
}