using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.ServiceModel;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WcfService1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service2" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service2.svc o Service2.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service2 : IService2
    {
        private static List<ProfesorTutor> tutores = new List<ProfesorTutor>();
        private static List<Alumno> alumnos = new List<Alumno>();
        public static string pathTutores = "C:\\temp\\gestorTutoriaTutores.bin";
        public static string pathAlumnos = "C:\\temp\\gestorTutoriaAlumnos.bin";
        public static string connecString = ConfigDB.configDB.connectString();
        public static MySqlConnection conn = new MySqlConnection(connecString);
        
        static Service2()
        {            
            loadTutores();
            loadAlumnos();
        }

        ~Service2()
        {

        }

        public int getTutoresCount()
        {
            return tutores.Count;
        }
        public Profesor getTutor(int i)
        {           
            if (i < tutores.Count) return tutores[i].Profesor;
            return null;
        }
        public static void loadTutores()
        {
            MySqlCommand command = conn.CreateCommand();

            command.CommandText = "select * from profesor where estutor ='1'";
            conn.Open();
            MySqlDataReader reader = command.ExecuteReader();
            tutores = new List<ProfesorTutor>();
            while (reader.Read())
            {

                int esTutor = Int32.Parse(reader["esTutor"].ToString());
                int codigo = Int32.Parse(reader["codigo"].ToString());
                Profesor newProfesor = ProfesorFactory.create(reader);
                ProfesorTutor newTutor = new ProfesorTutor(newProfesor);
                if (esTutor == 1)
                {
                    
                    newTutor.ListaAlumno = AlumnoPersistance.getAlumnosByProfesor(codigo);
                    newTutor.ListaReunion = ReunionPersistance.getReunionesByProfesor(codigo);
                }

                tutores.Add(newTutor);
            }
            conn.Close();
            
        }
                      
        public static void loadAlumnos()
        {
            
            
            MySqlCommand command = conn.CreateCommand();
            conn.Open();
            command.CommandText = "select * from alumno ";

            MySqlDataReader reader = command.ExecuteReader();
            alumnos = new List<Alumno>();

            while (reader.Read())
            {


                int codigo = Int32.Parse(reader["codigo"].ToString());
                Alumno newAlumno = AlumnoFactory.create(reader);
                newAlumno.ListaReuniones = ReunionPersistance.getReunionesByAlumno(codigo);
                
                alumnos.Add(newAlumno);

            }
            conn.Close();
        }
                       
        public int getProfesorTutor(int i)
        {
            try
            {
                if (i < tutores.Count) return tutores[i].Codigo;
            }catch(Exception e)
            {
                string message = e.Message;
            }
            
            return 0;
        }
        public string agregarProfesorTutor(Profesor profesor)
        {
            if (buscarTutor(profesor.Codigo) == null)
            {
                ProfesorTutor prof = new ProfesorTutor(profesor);
                ProfesorRepository.insertProfesor(profesor);
                tutores.Add(prof);
                return "Profesor agregado con éxito";
            }
            else
            {
                return "El profesor ya existe";
            }
        }

        public Profesor buscarProfesor(int codigo)
        {
            ProfesorTutor p = buscarTutor(codigo);

            if (p == null) return null;
            return p.Profesor;
        }
        public ProfesorTutor buscarTutor(int codigo)
        {
            ProfesorTutor p = tutores.Find(delegate(ProfesorTutor p2)
            {
                return p2.Codigo == codigo;
            });
            return p;
        }
        public List<Alumno> getAlumnos(Profesor profesor)
        {
            ProfesorTutor tutor = buscarTutor(profesor.Codigo);
            return tutor.ListaAlumno;
        }                

        public string agregarReunion(Alumno alumno, Profesor profesor, string fecha, string tema, string sugerencia)
        {
            Reunion reunion = new Reunion(alumno, profesor, fecha, tema, sugerencia);
            Alumno al = buscarAlumno(alumno.Codigo);
            ProfesorTutor prof = buscarTutor(profesor.Codigo);
            ReunionRepository.insertReunion(fecha, tema,sugerencia,alumno.Codigo,profesor.Codigo);
            al.ListaReuniones.Add(reunion);
            prof.ListaReunion.Add(reunion);
            return "Reunión Agregada";
        }

        public string agregarAlumno(Alumno alumno)
        {
            if (buscarAlumno(alumno.Codigo) == null)
            {
                AlumnoRepository.insertAlumno(alumno);
                alumnos.Add(alumno);
                buscarTutor(alumno.Tutor.Codigo).agregarAlumno(alumno);
                return "Alumno ingresado con éxito";
            }
            else
            {
                return "El alumno ya existe";
            }
        }

        public Alumno buscarAlumno(int codigo)
        {
            Alumno a = alumnos.Find(delegate(Alumno a2)
            {
                return a2.Codigo == codigo;
            });
            return a;
        }

        public Profesor crearProfesor(int cod, string nom, int dn, string corr, int telf, string reg, int idio, int anho, string grad, Especialidad esp,
            string fIn, string fRe, string fFin, string categ)
        {
            return new Profesor(cod, nom, dn, corr, telf, reg, idio, anho, grad, esp,
            fIn, fRe, fFin, categ);
        }

        public Alumno crearAlumno(int cod, string nom, int dn, string corr, int telf, int cic, int cred, Especialidad especialidadActual,
            Especialidad especialidadAnterior, string resumenReuniones, string unidad)
        {
            return new Alumno(cod, nom, dn, corr, telf, cic, cred, especialidadActual,
            especialidadAnterior, resumenReuniones, unidad);
        }
        public Especialidad crearEspecialidad(int codigo,string nombre)
        {
            return new Especialidad(codigo, nombre);
        }

        public int refresh()
        {
            try
            {
                loadTutores();
                loadAlumnos();
                return 1;
            }catch(Exception e)
            {
                return 0;
            }
        }

        public List<Reunion> getReuniones(Profesor profesor)
        {
            ProfesorTutor tutor = buscarTutor(profesor.Codigo);
            return tutor.ListaReunion;
        }

        public int pasarFacultad(int codigo,string resumen)
        {
            AlumnoRepository.updateFacultad(codigo,resumen,"FACI");
            return 1;
        }
    }
}
