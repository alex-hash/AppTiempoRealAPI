using API.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace API.LogicaHilos
{
    public class HiloActualizar
    {
        public Thread HiloGeneral;
        public Thread HiloUpdateCuota;
       
        public HiloActualizar()
        {
           
   
        }
        public void IniciarHiloGeneral()
        {
            this.HiloGeneral = new Thread(new ThreadStart(() => SistemaCentralHilos())); //creamos un hilos primario
            this.HiloGeneral.Start();
        }
        public void SistemaCentralHilos()
        {
            this.IniciarHiloUpdateCuota();
           //iniciar Hilo de actualizacion
            //this.IniciarContador();
           // this.EsperarContador();
           // this.BApostar.Hide();
           
        }
        public void IniciarHiloUpdateCuota()
        {
            
            this.HiloUpdateCuota = new Thread(new ThreadStart(() => ActualizacionAutomaticaCuota())); //de ese hilo primario creamos el hilo para realizar la actualizacion
            this.HiloUpdateCuota.Start();

        }

        private void ActualizacionAutomaticaCuota()
        {
            
            while (1 == 1)
            {
                Thread.Sleep(5000);

                //llamamos a funcion de modificar
                try
                {
                  
                    int numeroTotalEventos=EventoRepository.CountEvento(); //buscamos el total de id
                    Random numAleatorio = new Random();
                    int numeroTotalEventosModificar = numAleatorio.Next(1, numeroTotalEventos);//generamos aleatoriamente el numero de eventos totales que modificaremos
                    for(int i = 0; i <= numeroTotalEventosModificar; i++)
                    {
                        Random numRevento = new Random();
                        int numeroEvento = numRevento.Next(1, numeroTotalEventos);//seleccionamos de forma aleatoria que evento se modificara
                        Random numCuotaAleatoria = new Random();
                        float num = (float)numCuotaAleatoria.Next(11, 50) / 10;//se genera de forma aleatoria la cuota que se cambiara
                        EventoRepository.ModificarCuotaEvento(numeroEvento, num);//modificamos cuota
                       

                    }
                    

                }
                catch (Exception ex)
                {

                }
                
            }
        }
    }
}

