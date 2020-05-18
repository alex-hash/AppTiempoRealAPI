using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models {
    public class JugadorRepository {
        public Jugador ObtenerJugador(string login, string pass) {
            DAL.Jugador jugador = Handler.DB.Jugador.Where(j => j.login == login).FirstOrDefault();
            if (login!=null)
            {
                if (jugador.password == pass)
                {
                    //Login correcto
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
    }
}