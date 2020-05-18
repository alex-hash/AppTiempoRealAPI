using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models {
    public static class JugadorRepository {
        public static Jugador ObtenerJugador(string login, string pass) {
            DAL.Jugador jugador = Handler.DB.Jugador.Where(j => j.login == login).FirstOrDefault();
            if (jugador!=null)
            {
                if (jugador.password == pass)
                {
                    //Login correcto
                    jugador.password = null;
                    return new Jugador(jugador);
                } else
                {
                    //Contraseña incorrecta
                    return null;
                }
            } else
            {
                //Usuario no existe
                return null;
            }
        }

        public static Jugador ObtenerJugador(int id) {
            DAL.Jugador jugador = Handler.DB.Jugador.Where(j => j.idJugador == id).FirstOrDefault();
            if (jugador!= null)
            {
                jugador.password = null;
                return new Jugador( jugador );
            }
            else
            {
                //Usuario no existe
                return null;
            }
        }
    }
}