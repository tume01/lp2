using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService2" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService2
    {
        [OperationContract]
        string agregarProfesorTutor(Profesor profesor);

        [OperationContract]
        Profesor buscarProfesor(int codigo);

        [OperationContract]
        string agregarAlumno(Alumno alumno);

        [OperationContract]
        Profesor crearProfesor(int cod, string nom, int dn, string corr, int telf, string reg, int idio, int anho, string grad, Especialidad esp,
            string fIn, string fRe, string fFin, string categ);

        [OperationContract]
        Alumno crearAlumno(int cod, string nom, int dn, string corr, int telf, int cic, int cred, Especialidad especialidadActual,
            Especialidad especialidadAnterior, string resumenReuniones, string unidad);

        [OperationContract]
        Alumno buscarAlumno(int codigo);

        [OperationContract]
        int getTutoresCount();

        [OperationContract]
        Profesor getTutor(int i);

        [OperationContract]
        List<Alumno> getAlumnos(Profesor profesor);

        [OperationContract]
        string agregarReunion(Alumno alumno, Profesor tutor, string fecha, string tema, string sugerencia);

        [OperationContract]
        int getProfesorTutor(int i);

        [OperationContract]
        ProfesorTutor buscarTutor(int codigo);

        [OperationContract]
        List<Reunion> getReuniones(Profesor profesor);

        [OperationContract]
        int refresh();
    }


    [DataContract]
    [Serializable]
    public class Reunion
    {
        Alumno alumno;
        Profesor profesor;

        [DataMember]
        public Profesor Profesor
        {
            get { return profesor; }
            set { profesor = value; }
        }
        string fecha;
        string tema;
        string sugerencias;

        [DataMember]
        public string Sugerencias
        {
            get { return sugerencias; }
            set { sugerencias = value; }
        }

        [DataMember]
        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        [DataMember]
        public string Tema
        {
            get { return tema; }
            set { tema = value; }
        }

        [DataMember]
        public Alumno Alumno
        {
            get { return alumno; }
            set { alumno = value; }
        }

        public Reunion(Alumno a, Profesor p, string t, string tem, string sug)
        {
            alumno = a;
            profesor = p;
            fecha = t;
            tema = tem;
            sugerencias = sug;
        }
    }

    [DataContract]
    [Serializable]
    public class ProfesorTutor
    {
        private Profesor profesor;
        private List<Alumno> listaAlumno = new List<Alumno>();
        private List<Reunion> listaReunion = new List<Reunion>();
        

        [DataMember]
        public string NodoProfesor
        {
            get { return profesor.Codigo + "-" + profesor.Nombre; }
        }

        [DataMember]
        public List<Alumno> ListaAlumno
        {
            get { return listaAlumno; }
            set { listaAlumno = value; }
        }

        [DataMember]
        public int Codigo
        {
            get { return profesor.Codigo; }
            set {
                profesor.Codigo = value;
                this.Codigo = value;
            }
        }

        [DataMember]
        public Profesor Profesor
        {
            get
            {
                return profesor;
            }

            set
            {
                profesor = value;
            }
        }

        [DataMember]
        public List<Reunion> ListaReunion
        {
            get
            {
                return listaReunion;
            }

            set
            {
                listaReunion = value;
            }
        }

        public ProfesorTutor(Profesor profesor)
        {
            this.profesor = profesor;
        }
        public void agregarAlumno(Alumno alumno)
        {
            listaAlumno.Add(alumno);
        }

    }

    [DataContract]
    [Serializable]
    public class Profesor
    {
        private string regimenDedicacion;
        private string categoria;
        [DataMember]
        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        private string fechaFinCategoria;

        [DataMember]
        public string FechaFinCategoria
        {
            get { return fechaFinCategoria; }
            set { fechaFinCategoria = value; }
        }
        private string fechaIngreso;
        [DataMember]
        public string FechaIngreso
        {
            get { return fechaIngreso; }
            set { fechaIngreso = value; }
        }
        private string fechaRevalidacion;

        [DataMember]
        public string FechaRevalidacion
        {
            get { return fechaRevalidacion; }
            set { fechaRevalidacion = value; }
        }

        [DataMember]
        public string RegimenDedicacion
        {
            get { return regimenDedicacion; }
            set { regimenDedicacion = value; }
        }
        private int idioma;

        [DataMember]
        public int Idioma
        {
            get { return idioma; }
            set { idioma = value; }
        }
        private int anosExp;

        [DataMember]
        public int AnosExp
        {
            get { return anosExp; }
            set { anosExp = value; }
        }
        private string gradoAcademico;

        [DataMember]
        public string GradoAcademico
        {
            get { return gradoAcademico; }
            set { gradoAcademico = value; }
        }
        private Especialidad especialidad;

        [DataMember]
        public Especialidad Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }

        public Profesor(int cod, string nom, int dn, string corr, int telf, string reg, int idio, int anho, string grad, Especialidad esp,
            string fIn, string fRe, string fFin, string categ)
        {
            regimenDedicacion = reg;
            idioma = idio;
            anosExp = anho;
            gradoAcademico = grad;
            especialidad = esp;
            codigo = cod;
            nombre = nom;
            dni = dn;
            correo = corr;
            telefono = telf;
            fechaIngreso = fIn;
            fechaRevalidacion = fRe;
            fechaFinCategoria = fFin;
            categoria = categ;
        }
        public Profesor()
        {
            regimenDedicacion = "";
            idioma = 0;
            anosExp = 0;
            gradoAcademico = "";
            especialidad = new Especialidad();
        }
        private int codigo;
        private int dni;

        [DataMember]
        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        private string correo;

        [DataMember]
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        private int telefono;

        [DataMember]
        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        private string nombre;

        [DataMember]
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        [DataMember]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }

    [DataContract]
    [Serializable]
    public class Especialidad
    {
        private int codigo;

        [DataMember]
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private string nombre;

        [DataMember]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public Especialidad()
        {
            codigo = 0;
            nombre = "";
        }
        public Especialidad(int cod, string nom)
        {
            codigo = cod;
            nombre = nom;
        }
    }
    [DataContract]
    [Serializable]
    public class Alumno
    {
        private int ciclo;
        private int creditos;
        private List<Reunion> listaReuniones = new List<Reunion>();//lista de reuniones
        private Profesor tutor;
        private string unidad;

        [DataMember]
        public string Unidad
        {
            get { return unidad; }
            set { unidad = value; }
        }

        Especialidad especialidadAnterior;
        [DataMember]
        public Especialidad EspecialidadAnterior
        {
            get { return especialidadAnterior; }
            set { especialidadAnterior = value; }
        }
        Especialidad especialidadActual;

        [DataMember]
        public Especialidad EspecialidadActual
        {
            get { return especialidadActual; }
            set { especialidadActual = value; }
        }
        string resumenReuniones;

        [DataMember]
        public string ResumenReuniones
        {
            get { return resumenReuniones; }
            set { resumenReuniones = value; }
        }

        [DataMember]
        public Profesor Tutor
        {
            get { return tutor; }
            set { tutor = value; }
        }
        private Especialidad especialidad;

        [DataMember]
        public Especialidad Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }

        [DataMember]
        public int Ciclo
        {
            get { return ciclo; }
            set { ciclo = value; }
        }

        [DataMember]
        public int Creditos
        {
            get { return creditos; }
            set { creditos = value; }
        }

        [DataMember]
        public List<Reunion> ListaReuniones
        {
            get
            {
                return listaReuniones;
            }

            set
            {
                listaReuniones = value;
            }
        }
        
        public string formatearMostrar()
        {
            string nombreFacultdad = "";
            switch (this.Especialidad.Codigo)
            {
                case 0:
                    nombreFacultdad = "(FCI)";
                    break;
                case 1:
                    nombreFacultdad = "(EEGGCC)";
                    break;
            }
            return Codigo + "--" + Nombre + " " + nombreFacultdad;
        }
        public Alumno(int cod, string nom, int dn, string corr, int telf, int cic, int cred, Especialidad especialidadActual,
            Especialidad especialidadAnterior, string resumenReuniones, string unidad)
        {
            ciclo = cic;
            creditos = cred;
            codigo = cod;
            nombre = nom;
            dni = dn;
            correo = corr;
            telefono = telf;
            this.especialidadActual = especialidadActual;
            this.especialidadAnterior = especialidadAnterior;
            this.resumenReuniones = resumenReuniones;
            this.unidad = unidad;
        }
        public Alumno()
            : base()
        {
            ciclo = 0;
            creditos = 0;
        }
        private int codigo;
        private int dni;

        [DataMember]
        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        private string correo;

        [DataMember]
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        private int telefono;

        [DataMember]
        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        private string nombre;

        [DataMember]
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        [DataMember]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
