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
    public partial class PasarFacultad : Form
    {
        private int codigoAlumno;
        public string resumenString;
        public PasarFacultad(int codigo)
        {
            codigoAlumno = codigo;
            InitializeComponent();
        }

        private void saveResumen_Click(object sender, EventArgs e)
        {
            resumenString= resumenText.Text;
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cerrarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
