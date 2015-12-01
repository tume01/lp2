using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Practica2.ServiceReference4;
namespace Vista
{
    public partial class CrearUsuario : Form
    {
        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newNombre = this.newNombre.Text;
            string newContrasena = this.newContrasena.Text;
            int newtipo = this.tipoUsuario.SelectedIndex;

            Usuario newUsuario = new Usuario();
            newUsuario.UserName = newNombre;
            newUsuario.Pass = newContrasena;
            newUsuario.Tipo = newtipo;

            Service1Client try1 = new Practica2.ServiceReference4.Service1Client();

            int resultado = try1.crearUsuario(newUsuario);

            if (resultado != -1)
            {
                MessageBox.Show("Se creo el usuario correctamente");
            }
            else
            {
                MessageBox.Show("No se creo el usuario correctamente");
                this.Close();
            }

        }
    }
}
