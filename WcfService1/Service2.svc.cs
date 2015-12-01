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
        public static string connecString = "Server=localhost;Port=3306;Database=lp2;Uid=root;password=secret;";
        public static MySqlConnection conn = new MySqlConnection(connecString);
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
                Profesor newProfesor = ProfesorFactory(reader);
                ProfesorTutor newTutor = new ProfesorTutor(newProfesor);
                if (esTutor == 1)
                {
                    newTutor.ListaAlumno = getAlumnosByProfesor(codigo);
                    newTutor.ListaReunion = getReunionesByProfesor(codigo);
                }

                tutores.Add(newTutor);
            }
            conn.Close();
            
        }
        public static Alumno getAlumnoByCodigo(int codigo)
        {
            MySqlConnection connection = new MySqlConnection(connecString);
            connection.Open();
            MySqlCommand command = connection.CreateCommand();

            command.CommandText = "select * from alumno where codigo =" + codigo+";";

            MySqlDataReader reader = command.ExecuteReader();
            Alumno newAlumno = null;
            while (reader.Read())
            {
                newAlumno = AlumnoFactory(reader);
                
            }

            connection.Close();
            return newAlumno;
        }

        public static Profesor getProfesorByCodigo(int codigo)
        {
            MySqlConnection connection = new MySqlConnection(connecString);
            connection.Open();
            MySqlCommand command = connection.CreateCommand();

            command.CommandText = "select * from profesor where codigo =" + codigo + ";";

            MySqlDataReader reader = command.ExecuteReader();
            Profesor newProfesor = null;
            while (reader.Read())
            {
                newProfesor = ProfesorFactory(reader);
            }

            connection.Close();
            return newProfesor;
        }
        public static List<Alumno> getAlumnosByProfesor(int codigo)
        {
            List<Alumno> lista = new List<Alumno>();
            MySqlConnection connection = new MySqlConnection(connecString);
            MySqlCommand command = connection.CreateCommand();
            connection.Open();
            command.CommandText = "select a.* from alumno as a where a.tutor ="+codigo+";";

            MySqlDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                Alumno newAlumno = AlumnoFactory(reader);
                lista.Add(newAlumno);
            }
            connection.Close();

            return lista;
        }

        public static List<Reunion> getReunionesByProfesor(int codigo)
        {
            List<Reunion> lista = new List<Reunion>();
            MySqlConnection connection = new MySqlConnection(connecString);
            MySqlCommand command = connection.CreateCommand();
            connection.Open();
            command.CommandText = "select * from reunion where profesor =" + codigo + ";";

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int codigoAlumno = Int32.Parse(reader["alumno"].ToString());
                int codigoProfesor = Int32.Parse(reader["profesor"].ToString());
                Reunion newReunion = ReunionFactory(reader,codigoAlumno,codigoProfesor);
                lista.Add(newReunion);
            }
            connection.Close();
            return lista;
        }
        public static List<Reunion> getReunionesByAlumno(int codigo)
        {
            List<Reunion> lista = new List<Reunion>();
            MySqlConnection connection = new MySqlConnection(connecString);
            MySqlCommand command = connection.CreateCommand();
            connection.Open();
            command.CommandText = "select * from reunion  where alumno =" + codigo + ";";

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int codigoAlumno = Int32.Parse(reader["alumno"].ToString());
                int codigoProfesor = Int32.Parse(reader["profesor"].ToString());
                Reunion newReunion = ReunionFactory(reader,codigoAlumno,codigoProfesor);
                lista.Add(newReunion);
            }
            connection.Close();

            return lista;
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
                newEspecialidad = EspecialidadFactory(reader);
                
            }
            connection.Close();
            return newEspecialidad;
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
                Alumno newAlumno = AlumnoFactory(reader);
                newAlumno.ListaReuniones = getReunionesByAlumno(codigo);
                
                alumnos.Add(newAlumno);

            }
            conn.Close();
        }
        public static Alumno AlumnoFactory(MySqlDataReader reader)
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
            Especialidad especialidadActual = getEspecialidadByCodigo(codigoEspecialidad);
            int codigoEspecialidadAnterior = Int32.Parse(reader["especialidadAnterior"].ToString());
            Especialidad especialidadAnterior = getEspecialidadByCodigo(codigoEspecialidadAnterior);

            Alumno newAlumno = new Alumno(codigo, nombre, dni, correo, telefono, ciclo, creditos, especialidadActual, especialidadAnterior, resumenReuniones, unidad);
            int codigoTutor = Int32.Parse(reader["tutor"].ToString());
            newAlumno.Tutor = getProfesorByCodigo(codigoTutor);
            
            return newAlumno;
        }

        public static Profesor ProfesorFactory(MySqlDataReader reader)
        {
            string nombre = reader["nombre"].ToString();
            int dni = Int32.Parse(reader["dni"].ToString());
            int codigo = Int32.Parse(reader["codigo"].ToString());
            string correo = (reader["correo"].ToString());
            int telefono = Int32.Parse(reader["telefono"].ToString());
            string regimen = "";
            int anio = Int32.Parse(reader["año"].ToString());
            string grado = reader["grado"].ToString();
            int codigoEspecialidad = Int32.Parse(reader["especialidad"].ToString());
            Especialidad especialidad = getEspecialidadByCodigo(codigoEspecialidad);
            string fIn = reader["fechaIni"].ToString();
            string fRe = reader["fechaRev"].ToString();
            string fFin = reader["fechaFin"].ToString();
            int idioma = Int32.Parse(reader["idioma"].ToString());
            string categoria = reader["categoria"].ToString();

            return new Profesor(codigo, nombre, dni, correo, telefono, regimen, idioma, anio, grado, especialidad, fIn, fRe, fFin, categoria);
        }
        public static Especialidad EspecialidadFactory(MySqlDataReader reader)
        {
            int codigo = Int32.Parse(reader["codigo"].ToString());
            string nombre = reader["nombre"].ToString();
            return new Especialidad(codigo, nombre);
        }

        public static Reunion ReunionFactory(MySqlDataReader reader,int codigoAlumno,int codigoProfesor)
        {

            Alumno alumno = getAlumnoByCodigo(codigoAlumno);
            Profesor profesor = getProfesorByCodigo(codigoProfesor);
            string fecha = reader["fecha"].ToString();
            string tem = reader["tema"].ToString();
            string sug = reader["sugerencias"].ToString();
            return new Reunion(alumno, profesor, fecha, tem, sug);
        }
        public Profesor getProfesorTutor(int i)
        {
            if (i < tutores.Count) return tutores[i].Profesor;
            return null;
        }
        public string agregarProfesorTutor(Profesor profesor)
        {
            if (buscarTutor(profesor.Codigo) == null)
            {
                ProfesorTutor prof = new ProfesorTutor(profesor);
                insertProfesor(profesor);
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
        public static int insertReunion(string fecha,string tema,string sugerencia,int codigoAlumno,int codigoProfesor)
        {
            MySqlConnection connection = new MySqlConnection(connecString);
            connection.Open();
            MySqlCommand command = connection.CreateCommand();

            command.CommandText = "insert into reunion (fecha,tema,sugerencias,alumno,profesor) values('"+fecha+"','"+tema+"','"+sugerencia+"','"+codigoAlumno+"','"+codigoProfesor+"');";

            try
            {
                command.ExecuteNonQuery();
                connection.Close();
                return 1;
            }catch(Exception e)
            {
                connection.Close();
                return 0;
            }
        }
        public static int insertAlumno(Alumno alumno)
        {
            MySqlConnection connection = new MySqlConnection(connecString);
            connection.Open();
            MySqlCommand command = connection.CreateCommand();

            command.CommandText = "insert into alumno (nombre,dni,correo,telefono,ciclo,creditos,especialidadActual,especialidadAnterior,resumenReuniones,unidad,tutor) values('" + alumno.Nombre + "','" +alumno.Dni+ "','" + alumno.Correo + "','" + alumno.Telefono + "','" + alumno.Ciclo + "','"+alumno.EspecialidadActual.Codigo+ "','"+alumno.EspecialidadAnterior.Codigo+ "','"+alumno.ResumenReuniones+ "','"+alumno.Unidad + "','"+alumno.Tutor.Codigo+ "');";

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
        public static int insertProfesor(Profesor profesor)
        {
            MySqlConnection connection = new MySqlConnection(connecString);
            connection.Open();
            MySqlCommand command = connection.CreateCommand();

            command.CommandText = "insert into profesor (nombre,dni,correo,telefono,idioma,año,grado,especialidad,fechaIni,fechaRev,fechaFin,categoria,estutor) values('" + profesor.Nombre + "','" + profesor.Dni + "','" + profesor.Correo + "','" + profesor.Telefono + "','" + profesor.Idioma + "','" + profesor.AnosExp + "','" + profesor.GradoAcademico + "','" + profesor.Especialidad.Codigo + "','" + profesor.FechaIngreso + "','" + profesor.FechaRevalidacion + "','"+profesor.FechaFinCategoria+"','"+profesor.Categoria+ "','1');";

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

        public string agregarReunion(Alumno alumno, Profesor profesor, string fecha, string tema, string sugerencia)
        {
            //Reunion reunion = new Reunion(alumno, profesor, fecha, tema, sugerencia);
            //Alumno al = buscarAlumno(alumno.Codigo);
            //ProfesorTutor prof = buscarTutor(profesor.Codigo);
            insertReunion(fecha, tema,sugerencia,alumno.Codigo,profesor.Codigo);
            //al.ListaReuniones.Add(reunion);
            //prof.ListaReunion.Add(reunion);
            return "Reunión Agregada";
        }

        public string agregarAlumno(Alumno alumno)
        {
            if (buscarAlumno(alumno.Codigo) == null)
            {
                insertAlumno(alumno);
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
        static Service2()
        {
            
            loadTutores();
            
            
            loadAlumnos();
            
        }


        ~Service2()
        {
            

           
            
        
        }
    }
}
