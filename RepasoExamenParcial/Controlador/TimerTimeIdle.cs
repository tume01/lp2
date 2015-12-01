using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Vista;

namespace Practica2.Controlador
{
    class TimerTimeIdle
    {
        Timer TimerTiempo;
        Form1 formularioPrincipal;
        int contador = 0;
        public TimerTimeIdle(Form1 formularioEnviado)
        {
            TimerTiempo = new Timer();
            TimerTiempo.Interval = 1000;
            TimerTiempo.Tick += new EventHandler(EscribirTiempo);
            formularioPrincipal = formularioEnviado;
            TimerTiempo.Enabled = true;
        }

        void EscribirTiempo(Object sender,EventArgs args)
        {
            contador++;
            
        }
    }
}
