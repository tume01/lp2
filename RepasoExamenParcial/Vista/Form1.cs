using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using System.Drawing.Imaging;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

using Practica2.ServiceReference4;
using Practica2.Controlador;
using Practica2.Vista;
using Practica2.ServiceReference5;

namespace Vista
{
    public partial class Form1 : Form, IMessageFilter  //#Pregunta 6  TODO ESTO ES LA IMPLEMNTACION DE LA PREGUNTA 6 
    {

        public int logged = 0;
        public int alumnoSelected = 0;
        public static int usuarioActual;
        TimerTimeIdle contadorIdle;
        Timer idle;
        int contador = 0 ;
        Timer finished;
        int contadormin = 0;
        string currentNode;
        Timers.HiloFin hiloFin;
        Timers.HiloIdle hiloIdle;
        Timers.HiloRefresh hiloRefresh;
        delegate void SetTextCallback(string text);
        delegate void SetTreeCallback(int val, string text);
        public Practica2.ServiceReference5.Service2Client serviceTutor = new Practica2.ServiceReference5.Service2Client();
        public Form1()
        {
            
            InitializeComponent();
            
        }

        /// <summary>
        /// Este método debe mostrar la ventana de Login como un cuadro de diálogo modal
        /// Y verificar el usuario con respecto a los usuarios registrados en un
        /// archivo binario.
        /// </summary>
        /// <param name="sender">Genera el evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void iniciarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           if (logged == 0)
            {
                
                Login newLogin = new Login();

                newLogin.ShowDialog(this);
                if (newLogin.logged == 1)
                {
                    Form1.usuarioActual= newLogin.usuarioActual.Tipo;
                    cargarArbol();
                    reportesToolStripMenuItem.Enabled = true;
                    this.label1.Visible = true;
                    this.label2.Visible = true;
                    this.nombreUsuario.Visible = true;
                    this.tiempoInactivo.Visible = true;
                    this.nombreUsuario.Text = newLogin.usuarioActual.UserName;
                    hiloFin = new Timers.HiloFin("fin", this);
                    hiloIdle = new Timers.HiloIdle("idle", this);
                    hiloRefresh = new Timers.HiloRefresh("refresh", this);
                    hiloFin.Start();
                    hiloIdle.Start();
                    actualizarButton.Enabled = true;
                    //hiloRefresh.Start();
                    this.logged = 1;

                    Application.AddMessageFilter(this);
                }
              // se verifica si el usario paso el login correctamente y se guarda el tipo como variable estatica del formualrio 1 
            }
            else
            {
                MessageBox.Show("Usuario ya logueado");
            }
        }
        private void cargarArbol() 
        {
            this.treeView1.BeginUpdate();
            this.treeView1.Nodes.Clear();
            this.treeView1.Nodes.Add("Especialidad","Ingeniería Informática");
           
            int j;

            for (int i = 0; i < serviceTutor.getTutoresCount(); i++)
            {
                Profesor nodeTutor = serviceTutor.getTutor(i);
                this.treeView1.Nodes[0].Nodes.Add("Profesor", nodeTutor.Codigo+"-"+nodeTutor.Nombre);
                Alumno[] ListaAlumno = serviceTutor.getAlumnos(nodeTutor);
                for (j = 0; j < ListaAlumno.Length; j++)
                {
                    Alumno nodeAlumno = ListaAlumno[j];

                    if ((nodeAlumno.Unidad == "FACI") && (usuarioActual == 2 || usuarioActual == 0))
                    {
                        this.treeView1.Nodes[0].Nodes[i].Nodes.Add("Alumno", nodeAlumno.Codigo+ "--" + nodeAlumno.Nombre + " " + nodeAlumno.Unidad);
                    }
                    else if ((nodeAlumno.Unidad == "EEGGCC") && (usuarioActual == 1 || usuarioActual == 0))
                    {
                        this.treeView1.Nodes[0].Nodes[i].Nodes.Add("Alumno", nodeAlumno.Codigo + "--" + nodeAlumno.Nombre + " " + nodeAlumno.Unidad);
                    }
                }      
            }
            this.treeView1.EndUpdate();
        }
        public void cargarNuevo()
        {

        }

        private void nodeMouseClick(object sender, TreeNodeMouseClickEventArgs e) // handler de eventos de click en el, arbol #pregunta6
        {

            currentNode = e.Node.Text;
            
            if (e.Button==MouseButtons.Left){
                if (e.Node.Name == "Alumno")                    
                    
                    if(alumnoSelected != extraerCodigo(e.Node.Text ))
                    {
                        alumnoSelected = extraerCodigo(e.Node.Text);
                        cargarTabla(e.Node);
                        
                    }
                        
            }
            else
                if (e.Button == MouseButtons.Right)
                {
                    if (e.Node.Name == "Especialidad")
                    {
                        e.Node.ContextMenu = new ContextMenu();
                        e.Node.ContextMenu.MenuItems.Add("Agregar Profesor");
                        e.Node.ContextMenu.MenuItems[0].Click += new EventHandler(agregarProfesor);                         
                    }
                    else if(e.Node.Name == "Profesor")
                    {
                        e.Node.ContextMenu = new ContextMenu();
                        e.Node.ContextMenu.MenuItems.Add("Agregar Alumno");
                        e.Node.ContextMenu.MenuItems.Add("Modificar Profesor");
                        e.Node.ContextMenu.MenuItems[0].Click += new EventHandler(agregarAlumno);
                        e.Node.ContextMenu.MenuItems[1].Click += new EventHandler(modificarProfesor);
                    }
                    else if(e.Node.Name =="Alumno")
                    {
                        e.Node.ContextMenu = new ContextMenu();
                        e.Node.ContextMenu.MenuItems.Add("Agregar Reunion");
                        e.Node.ContextMenu.MenuItems.Add("Pasar a facultad");
                        e.Node.ContextMenu.MenuItems[0].Click += new EventHandler(agregarReunion);
                        e.Node.ContextMenu.MenuItems[1].Click += new EventHandler(pasarFacultad);
                        
                        
                    }
                }
                    

        }
        public void pasarFacultad(object sender, EventArgs e)
        {
            int codigoAlumno = extraerCodigo(this.treeView1.SelectedNode.Text);
            PasarFacultad pasarForm = new PasarFacultad(codigoAlumno);
            pasarForm.ShowDialog(this);
            serviceTutor.pasarFacultad(codigoAlumno, pasarForm.resumenString);
           
            MessageBox.Show("Alumno cambiado a facultad exitosamente");
        }
        public void refreshData()
        {
            dataGridView1.Rows.Clear();
            serviceTutor.refresh();
            cargarArbol();
        }
        public void modificarProfesor(object sender, EventArgs e)// este metod esta incompleto llegue a implemntarlo pero tuve un problema al trata de elegir si era 
            //contratado u ordinario ya que esta informacion no estaba en la clase padre profesor 
        {
            Practica2.ServiceReference5.Service2Client serviceTutor = new Practica2.ServiceReference5.Service2Client();
            int codigoProfesor = extraerCodigo(this.treeView1.SelectedNode.Text);
            ProfesorTutor profesorSeleccionado = serviceTutor.buscarTutor(codigoProfesor);

            Form2 formularioProfesor = new Form2(ref profesorSeleccionado);
            formularioProfesor.ShowDialog(this);


        }
        private void agregarReunion(object sender, EventArgs e) // #pregunta6 codigo para agregar el profesor 
            // en este caso tengo un comentario sobre como se maneja la creacion de la reunion ya que la reunion se crea usando un alumno 
            //este alumno no tiene la reunion agregada cuando se le pasa y recien la tendra cuando la reunion es creada ya que se agrega a la lista
            // de reuniones , esto genera una inconsistencia en la data , la cual no estoy seguro si existe una forma para poder eliminarla sin tener que 
            // redundar mucho codigo
        {
            int codigoProfesor = extraerCodigo(this.treeView1.SelectedNode.Parent.Text);

            Profesor profeSeleccionado = serviceTutor.buscarProfesor(codigoProfesor);

            int codigoAlumno = extraerCodigo(this.treeView1.SelectedNode.Text);

            Alumno alumnoSeleccionado = serviceTutor.buscarAlumno(codigoAlumno);

            CrearReunion formReunion = new CrearReunion(alumnoSeleccionado, profeSeleccionado);
            formReunion.ShowDialog(this);
            cargarTabla(this.treeView1.SelectedNode);

            
        }
        /// <summary>
        /// Este método debe cargar la tabla con todas las reuniones del alumno
        /// seleccionado
        /// </summary>
        /// <param name="node">Alumno seleccionado</param>
        private void cargarTabla(TreeNode node) // al cargar la tabla con el formateo de que faucltdad es
        {

            int codigo = extraerCodigo(node.Text);
            Alumno alumno = serviceTutor.buscarAlumno(codigo);
            this.dataGridView1.Rows.Clear();

            foreach (Reunion r in alumno.ListaReuniones)
            {
                
                this.dataGridView1.Rows.Add(r.Profesor.Nombre, r.Fecha, r.Tema, alumno.Nombre + " " + alumno.Unidad);
            }
           
            
            //Para todas las reuniones*/
        }

        private int extraerCodigo(string p) // codigop apra extraer el codigo del texto del nodo
        {
            string[] codigo = p.Split('-');
            int codigoNum = Int32.Parse(codigo[0]);
            return codigoNum;
        }

        private void agregarProfesor(object sender, EventArgs e) // #pregunta6 codigo para agregar profesor
        {
            Practica2.ServiceReference5.Service2Client serviceTutor = new Practica2.ServiceReference5.Service2Client();
            //Profesor profesor;
            Form2 formularioProfesor = new Form2(/*ref profesor*/);
            formularioProfesor.ShowDialog(this);
            if (Form2.ProfesorAgregado != null)
            {
                ProfesorTutor newProfesor = new ProfesorTutor();
                
                serviceTutor.agregarProfesorTutor(Form2.ProfesorAgregado);
                
                
                cargarArbol();
            }
            
        }

        private void agregarAlumno(object sender, EventArgs e)// #pregunta6 codigo para agregar alumno abre la ventan 
        {
            Practica2.ServiceReference5.Service2Client serviceTutor = new Practica2.ServiceReference5.Service2Client();
            //Mostrar el formulario de alumno
            FormAlumno formularioAlumno = new FormAlumno();
            formularioAlumno.ShowDialog(this);
            if (FormAlumno.AlumnoAgregado != null)
            {
                int codigoProfesor = extraerCodigo(currentNode);

                Profesor profesorSeleccionado = serviceTutor.buscarProfesor(codigoProfesor);
                FormAlumno.AlumnoAgregado.Tutor = profesorSeleccionado;
                serviceTutor.agregarAlumno(FormAlumno.AlumnoAgregado);
                

                //Falta Agregar Tutor al alumno
                cargarArbol();
            }
            
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void atencionesToolStripMenuItem_Click(object sender, EventArgs e)//# codigo para ir a reportes
        {
           if(logged == 1)
            {
                formReporte formularioReportes = new formReporte(this);
                formularioReportes.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("No se Encuentra Logueado");
            }
            
   
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            
            dataGridView1.Rows.Clear();
            label1.Hide();
            label2.Hide();
            nombreUsuario.Hide();
            tiempoInactivo.Hide();
            logged = 0;

        }
        // PRACTICA 4
        public void cerrarTodo(object sender, EventArgs args)
        {
            //Saver.GuardarAlumno(GestorAlumnos.Alumnos);
            //Saver.GuardarTutores(GestorTutores.Tutores); // grabara todo el trabajo hecho hasta ese punto 

            
            foreach( Form frm in Application.OpenForms)
            {
                if (frm.Modal == true) frm.Close();
            }
            treeView1.Nodes.Clear();
            nombreUsuario.Text = "";
            tiempoInactivo.Text = "";

            nombreUsuario.Hide();
            tiempoInactivo.Hide();
            label1.Hide();
            label2.Hide();
            dataGridView1.Rows.Clear();
            logged = 0;
        }

         void escribirTiempoIdle(object sender, EventArgs args)
        {
             contador++;
             
             if (contador == 60)
             {
                 contador = 0;
                 contadormin ++ ;
             }
             this.tiempoInactivo.Text = contadormin.ToString() + ":" + contador.ToString();
        }
         public bool PreFilterMessage(ref Message m)
         {
             // Monitor message for keyboard and mouse messages
             bool active = m.Msg == 0x100 || m.Msg == 0x101;  // WM_KEYDOWN/UP
             active = active || m.Msg == 0xA0 || m.Msg == 0x200;  // WM_(NC)MOUSEMOVE
             active = active || m.Msg == 0x10;  // WM_CLOSE, in case dialog closes
             if (active)
             {

                hiloFin.Interrup();
                 hiloIdle.Interrup();
             }
             else
             {
                 hiloFin.Start();
                 hiloIdle.Start();
                 
                 
             }
             return false;
         }

        //
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            Application.Idle += new EventHandler(startIdle);
            
        }
        
        public void startIdle(object sender, EventArgs args)
        {
            
        }
        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) // #pregunta5 este saver lo hace aqui tambien , en general el programa guarda
            //cada vez que agrega por si pasa algo con el sistema y no llega a cerrarse de la menera adecuada  y tambien cuando se cierra de manera adecuada
        {
            //Saver.GuardarAlumno(GestorAlumnos.Alumnos);
            //Saver.GuardarTutores(GestorTutores.Tutores);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

       //Practica 5

        public void setInactivoText(string texto)
        {
            this.setInactivo(texto);
        }
        public void setInactivo(string text)
        {
            if (this.tiempoInactivo.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(setInactivo);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.tiempoInactivo.Text = text;
            }
        }
        public void cerrarTodo()
        {
            //Saver.GuardarAlumno(GestorAlumnos.Alumnos);
            //Saver.GuardarTutores(GestorTutores.Tutores); // grabara todo el trabajo hecho hasta ese punto 


            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Modal == true) frm.Close();
            }
            
         
            cerrarTodoSafe(0, "");
        }

        public void cerrarTodoSafe(int loggedVal, string text)
        {
            if (this.treeView1.InvokeRequired)
            {
                SetTreeCallback d = new SetTreeCallback(cerrarTodoSafe);
                this.Invoke(d, new object[] { loggedVal, text });
            }
            else
            {
                treeView1.Nodes.Clear();

            }
            if (this.nombreUsuario.InvokeRequired || this.tiempoInactivo.InvokeRequired || label1.InvokeRequired || label2.InvokeRequired || dataGridView1.InvokeRequired)
            {
                SetTreeCallback d = new SetTreeCallback(cerrarTodoSafe);
                this.Invoke(d, new object[] { loggedVal,text });
            }
            else
            {
                nombreUsuario.Text = "";
                tiempoInactivo.Text = "";
                nombreUsuario.Hide();
                tiempoInactivo.Hide();
                label1.Hide();
                label2.Hide();
                dataGridView1.Rows.Clear();
                logged = loggedVal;
            }
        }

        private void actualizarButton_Click(object sender, EventArgs e)
        {
            refreshData();
            
        }
    }
}
