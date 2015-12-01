using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using Controlador;
using Vista;

namespace Practica2.Controlador
{
    
    class TimerIdle
    {
        Timer Temporizador;
        Form1 formualrioPrincipal;
        public TimerIdle(Form1 formularioPrincipalenviado)
        {
            Temporizador = new Timer();
            Temporizador.Interval = 1000 * 60;
            Temporizador.Tick += new EventHandler(CerrarTodo);
            this.formualrioPrincipal = formularioPrincipalenviado;

        }

        void CerrarTodo(Object sender, EventArgs args)
        {
            Saver.GuardarAlumno(GestorAlumnos.Alumnos);
            Saver.GuardarTutores(GestorTutores.Tutores); // grabara todo el trabajo hecho hasta ese punto 
            
            foreach (Form frm in formualrioPrincipal.MdiChildren)
            {
                frm.Close();
            }
            


        }
    }

}
