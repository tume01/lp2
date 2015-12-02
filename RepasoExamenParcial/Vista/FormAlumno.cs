using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Practica2.ServiceReference5;

namespace Vista
{
    public partial class FormAlumno : Form
    {
        public static Alumno AlumnoAgregado = null; //#pregunta6
        public FormAlumno()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Evento que permite agregar un alumno
        /// </summary>
        /// <param name="sender">Generador de evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void button1_Click(object sender, EventArgs e)
        {
            //Agregar alumno
            int codigo = Int32.Parse(textBoxCodigo.Text);
            string nombre = textBoxNombre.Text;
            int dni = Int32.Parse(textBoxDNI.Text);
            int creditos = 1;
            string email = "prueba@prueba.com";
            int telefono = 1;
            int ciclo = 1;
            int facultad = comboBoxFacultad.SelectedIndex;
            Especialidad newEspecialidad = new Especialidad();
            newEspecialidad.Codigo = 1;
            newEspecialidad.Nombre = "Ingenieria Informatica";
            string unidad;
            switch (facultad)
            {
                case 0:
                    {
                        unidad = "FACI";
                        break;
                    }
                default :
                    {
                        unidad = "EEGGCC";
                        break;
                    }          
            }
            Service2Client servicio = new Service2Client();
            Alumno newAlumno = servicio.crearAlumno(codigo, nombre, dni, email, telefono, ciclo, creditos, newEspecialidad, newEspecialidad, "", unidad);
            
            
            AlumnoAgregado = newAlumno;
            MessageBox.Show("Alumno agregado");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAlumno_Load(object sender, EventArgs e)
        {
            int usuario = Form1.usuarioActual;
            switch(usuario)
            {
                case 0:
                    comboBoxFacultad.Items.Add("FCI");
                    comboBoxFacultad.Items.Add("EEGGCC");
                    break;
                case 1:
                    comboBoxFacultad.Items.Add("EEGGCC");
                    break;
                case 2:
                    comboBoxFacultad.Items.Add("FCI");
                    break;
            }
        }
    }
}
