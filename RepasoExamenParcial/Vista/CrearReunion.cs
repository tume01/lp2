
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Practica2.ServiceReference5;

namespace Practica2.Vista
{
    public partial class CrearReunion : Form//#pregunta6
    {
        public Alumno alumno;
        public Profesor profesor;
        public static Reunion Reunion = null;
        public CrearReunion(Alumno a, Profesor p)
        {
            this.alumno = a;
            this.profesor = p;
            InitializeComponent();
        }

        private void buttonGuardarReunion_Click(object sender, EventArgs e)
        {
            string tema        = textBoxTema.Text;
            string sugerancias = richTextBoxSugerencias.Text;
            DateTime fecha = dateTimePickerFechaReunion.Value;
            Service2Client serviceTutor = new Service2Client();
            
            string result = serviceTutor.agregarReunion(alumno, profesor, fecha.ToString("yyyy-MM-dd"), tema, sugerancias);
            MessageBox.Show(result);
            // Reunion newReunion = new Reunion(alumno, profesor, fecha, tema, sugerancias);


            this.Close();
        }

        private void buttonCerrarReunion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
