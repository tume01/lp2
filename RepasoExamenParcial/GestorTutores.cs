using Modelo;
using System.Collections.Generic;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Controlador
{
    [Serializable]
    class GestorTutores
    {
        private static List<ProfesorTutor> tutores = new List<ProfesorTutor>();

        public static List<ProfesorTutor> Tutores
        {
            get { return GestorTutores.tutores; }
            set { GestorTutores.tutores = value; }
        }
        
        public void agregarProfesorTutor(Profesor profesor)
        {
            ProfesorTutor prof=new ProfesorTutor(profesor);
            Tutores.Add(prof);
        }

        /// <summary>
        /// Este método busca un profesor en la lista
        /// dado su código.
        /// </summary>
        /// <param name="p"> Código del tutor
        public static ProfesorTutor buscarTutor(int Codigo)
        {
            //Falta completar
            return tutores.Find((x) => x.Codigo == Codigo);
            
        }

        public static void agregarReunion(int codigoProfesor, Reunion newReunion)
        {
            ProfesorTutor profesor = buscarTutor(codigoProfesor);

            profesor.addReunion(newReunion);
        }
    }   
}
