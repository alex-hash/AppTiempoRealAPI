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
            this.HiloGeneral = new Thread(new ThreadStart(() => SistemaCentralHilos()));
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
            
            this.HiloUpdateCuota = new Thread(new ThreadStart(() => ActualizacionAutomaticaCuota()));
            this.HiloUpdateCuota.Start();

        }

        private void ActualizacionAutomaticaCuota()
        {
            Thread.Sleep(5000);// aleatorio
            while (1 == 1)
            {
                //llamamos a funcion de modificar
                try
                {

                    Random numAleatorio = new Random();
                    float num= numAleatorio.Next(10, 100);
                    EventoRepository.ModificarCuotaEvento(1, num);
                }
                catch (Exception ex)
                {

                }
                
            }
        }
    }
}

/*
 *  try
            {
                using (var DB = new Tema9Ejercicio8Entities())
                {
                    int idComprobar = this.IdJugador;
                    
                        var jugadorModificar = DB.JUGADORDB.Where(x => x.IdJugador == idComprobar).ToList();
                    jugadorModificar[0].Nombre = nuevoNombre;
                    jugadorModificar[0].Apellido = nuevoApellido;
                     

                        DB.SaveChanges();
                        return new Respuesta<Jugador>(TipoRespuesta.Exito, null, "Modificado jugador con exito");
                   

                }

            }
            catch (Exception ex)
            {
                return new Respuesta<Jugador>(TipoRespuesta.Error, null, "Error al modificar jugador " + ex.Message);
            }
 
     */
