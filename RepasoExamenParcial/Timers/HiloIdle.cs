using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Vista;

namespace Timers
{
    class HiloIdle
    {
        int SleepTime;
	    static Random Rand = new Random();
        Thread hilo;
        int contador = 0;
        int contadormin = 0;
        Form1 formularioPrincipal;
        bool enable = false;
        public HiloIdle(string Name, Form1 formPricipal)
        {
		    hilo = new Thread(new ThreadStart(Run));
		    hilo.Name = Name;
		    SleepTime = 1000;
            this.formularioPrincipal = formPricipal;
		    
	    }
	    public void Start() {

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
	    public void Join(){
		    hilo.Join();		
	    }
	    public void Join(int timeJoin){
		    hilo.Join(timeJoin);	
	    }	
	    public void Run() {
            while (enable) { 
                try
                {
                    Thread.Sleep(SleepTime);
                    contador++;

                    if (contador == 60)
                    {
                        contador = 0;
                        contadormin++;
                    }
                    formularioPrincipal.setInactivoText(contadormin.ToString() + ":" + contador.ToString());

                }catch(Exception e)
                {

                }
		        
               
           }
		    
	    }

        public void Interrup()
        {
            
            enable = false;
            contador = 0;
            contadormin = 0;

        }
    }
}
