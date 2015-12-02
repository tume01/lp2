using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Vista;

namespace Timers
{
    class HiloRefresh
    {
        int SleepTime;
        static Random Rand = new Random();
        Thread hilo;
        bool enable = false;
        Form1 formularioPrincipal;
        public HiloRefresh(string nombre,Form1 formPrincipal)
        {
            hilo = new Thread(new ThreadStart(Run));
            hilo.Name = nombre;
            SleepTime = 1000 * 60*5;
            this.formularioPrincipal = formPrincipal;
        }

        public void Start()
        {

            if (enable != true)
            {
                enable = true;
                try
                {
                    hilo.Start();
                }
                catch (Exception e)
                {

                }

            }

        }
        public void Join()
        {
            hilo.Join();
        }
        public void Join(int timeJoin)
        {
            hilo.Join(timeJoin);
        }
        public void Run()
        {
            while (enable)
            {
                try
                {
                    Thread.Sleep(SleepTime);
                    formularioPrincipal.Refresh();
                }
                catch (Exception e)
                {

                }

            }

        }

        public void Interrup()
        {
            enable = false;


        }
    }
}
