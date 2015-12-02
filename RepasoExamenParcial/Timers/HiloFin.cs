using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Vista;

namespace Timers
{
    class HiloFin
    {
        int SleepTime;
	    static Random Rand = new Random();
        Thread hilo;
        bool enable = false;
        Form1 formularioPrincipal;
        public HiloFin(string Name, Form1 formPricipal)
        {
		    hilo = new Thread(new ThreadStart(Run));
		    hilo.Name = Name;
		    SleepTime = 1000*60;
            this.formularioPrincipal = formPricipal;
		    
	    }
	    public void Start() {
            
            if(enable != true)
            {
                enable = true;
                try
                {
                    hilo.Start();
                }catch(Exception e)
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
            while (enable)
            {
                try
                {
                    Thread.Sleep(SleepTime);
                    formularioPrincipal.cerrarTodo();
                }catch(Exception e)
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
