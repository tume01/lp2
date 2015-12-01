
using Practica2.ServiceReference4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vista
{
    public partial class Login : Form
    {

        public List<Usuario> listaUsuarios;//#pregunta6
        public int logged = 0;
        public Usuario usuarioActual;
        public Login()
        {
            
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Cancelar
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Validar usuario
            string usuario = textBox1.Text;
            string contrasena = textBox2.Text;
            Practica2.ServiceReference4.Service1Client try1 =new  Practica2.ServiceReference4.Service1Client();
            Practica2.ServiceReference4.Usuario returnString;
            returnString = try1.buscarUsuario(usuario);

            if (returnString == null)
            {
                this.errorLabel.Text = "Usuario Invalido";
                this.errorLabel.Visible = true;
            }
            else
            {
                if (returnString.Pass == contrasena)
                {
                    this.logged = 1;
                    this.usuarioActual = returnString;
                    this.Close();
                    
                }
                else
                {
                    this.errorLabel.Text = "Contraseña Invalida";
                    this.errorLabel.Visible = true;
                }
            }

            /*foreach(Usuario u in listaUsuarios)
            {
                if (u.pass == contrasena && u.user == usuario)
                {
                    this.logged = 1;
                    this.usuarioActual = u;
                    this.Close();
                    break;
                    
                }
            }*/

            if (this.logged == 0)
            {
                this.errorLabel.Text = "Data Incorrecta";
                this.errorLabel.Visible = true;
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CrearUsuario newCrearUsuario = new CrearUsuario();

            newCrearUsuario.ShowDialog(this);
        }
    }
}
