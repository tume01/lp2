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
    public partial class Form2 : Form
    {
        public static Profesor ProfesorAgregado = null; // #pregunta6
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(ref ProfesorTutor seleccionado)
        {
            InitializeComponent();
            this.Text = "Modificar Profesor";
            this.button1.Text = "Guardar";

            textBoxCodigo.Text = seleccionado.Profesor.Codigo.ToString();
            textBoxNombre.Text = seleccionado.Profesor.Nombre;
            textBoxDNI.Text = seleccionado.Profesor.Dni.ToString();
            textBoxCorreo.Text = seleccionado.Profesor.Correo;
            textBoxTelefono.Text = seleccionado.Profesor.Telefono.ToString();
            comboBoxIdioma.SelectedIndex = seleccionado.Profesor.Idioma;
            comboBoxDedicacion.SelectedText = seleccionado.Profesor.RegimenDedicacion;
           // dateTimePickerInicio.Value = new DateTime(seleccionado.Profesor.Inicio);

        }
        /// <summary>
        /// Evento que permite agregar tutor
        /// </summary>
        /// <param name="sender">Generador de evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void button1_Click(object sender, EventArgs e)
        {
            int codigo                = Int32.Parse(textBoxCodigo.Text);
            string nombre             = textBoxNombre.Text;
            int dni                   = Int32.Parse(textBoxDNI.Text);
            string correo             = textBoxCorreo.Text;
            int telefono              = Int32.Parse(textBoxTelefono.Text);
            string regimen            = comboBoxDedicacion.SelectedText;
            int idioma                = comboBoxIdioma.SelectedIndex;
            DateTime fechaInicio      = dateTimePickerInicio.Value;
            DateTime fechaFin         = dateTimePickerFin.Value;
            int anio                  = fechaInicio.Year;
            string gradoAcademico     = comboBoxGrado.SelectedText ;
            Especialidad especialidad = new Especialidad();
            especialidad.Codigo = comboBoxEspecialidad.SelectedIndex+1;
            especialidad.Nombre = "informatica";
            string FechaFin           = fechaInicio.ToString("yyyy-MM-dd");
            string FechaIinicio       = fechaFin.ToString("yyyy-MM-dd");
            
            Service2Client servicio = new Service2Client();
            Profesor newProfesor = servicio.crearProfesor(codigo,nombre,dni,correo,telefono,"regimen",idioma,anio,"grado",
                                    especialidad,FechaIinicio,FechaIinicio,FechaFin,"categoria");                        

            ProfesorAgregado = newProfesor;
            
            MessageBox.Show("Profesor agregado");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();//Cancelar
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDedicacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
