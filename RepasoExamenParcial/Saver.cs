using Controlador;
using Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Practica2.Controlador
{
    public class Saver
    {
        public static void  GuardarAlumno(List<Alumno> newAlumno)
        {
            FileStream Output = new FileStream(".\\users\\alumnos.bin", FileMode.Create, FileAccess.Write);

            BinaryFormatter Formateador = new BinaryFormatter();

            Formateador.Serialize(Output,newAlumno);

            Output.Close();
        }

        public static void GuardarTutores(List<ProfesorTutor> lista)
        {
            FileStream Output = new FileStream(".\\users\\tutores.bin", FileMode.Create, FileAccess.Write);

            BinaryFormatter Formateador = new BinaryFormatter();

            Formateador.Serialize(Output, lista);

            Output.Close();
        }

        public static void cargarAlumnos()
        {
            FileStream Input = new FileStream(".\\users\\alumnos.bin", FileMode.OpenOrCreate, FileAccess.Read);
            BinaryFormatter Formateador = new BinaryFormatter();
            List<Alumno> listaAlumnos = new List<Alumno> { };
            while (true)
            {
                Alumno p;
                try
                {
                    listaAlumnos = (List<Alumno>)Formateador.Deserialize(Input);
                    GestorAlumnos.Alumnos = listaAlumnos;
                }
                catch (SerializationException ex)
                {

                    break;
                }

            }

            
            Input.Close();
        }

        public static void cargarTutores()
        {
            FileStream Input = new FileStream(".\\users\\tutores.bin", FileMode.OpenOrCreate, FileAccess.Read);
            BinaryFormatter Formateador = new BinaryFormatter();
            List<ProfesorTutor> listaProfesores = new List<ProfesorTutor> { };
            List<ProfesorTutor> p;
            while (true)
            {
                
                try
                {
                    p = (List<ProfesorTutor>)Formateador.Deserialize(Input);
                    GestorTutores.Tutores = p;

                }
                catch (SerializationException ex)
                {

                    break;
                }

            }
            Input.Close();

        }

    }
}
