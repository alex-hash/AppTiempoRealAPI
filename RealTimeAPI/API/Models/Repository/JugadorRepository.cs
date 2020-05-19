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

        public static Jugador NuevoJugador(string nombre, string apellido, string login, string password) {
            if (nombre!=null && apellido!=null && login!=null && password!=null)
            {
                Jugador nuevoLogico = new Jugador(nombre, apellido, login, password);
                try{
                    var db = Handler.DB;
                    db.Jugador.Add( nuevoLogico.ToModel() );
                    db.SaveChanges();
                    //Se crea un nuevo jugador, obteniendo su id de la DB
                    Jugador nuevo = ObtenerJugador(login, password);
                    if (nuevo!=null) {
                        nuevo.Password = null;
                        return nuevo;
                    } else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Exception of type {ex.GetType()}: {ex.Message}");
                    return null;
                }
            } else
            {
                //algún dato obligatorio como nulo
                return null;
            }
        }

        public static Jugador NuevoJugador(Jugador jugador) {
            if (jugador.Nombre != null && jugador.Apellido != null && jugador.Login != null && jugador.Password != null)
            {
                try
                {
                    var db = Handler.DB;
                    db.Jugador.Add( jugador.ToModel());
                    db.SaveChanges();
                    //Se crea un nuevo jugador, obteniendo su id de la DB
                    Jugador nuevo = ObtenerJugador(jugador.Login, jugador.Password);
                    if (nuevo != null)
                    {
                        nuevo.Password = null;
                        return nuevo;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Exception of type {ex.GetType()}: {ex.Message}");
                    return null;
                }
            }
            else
            {
                //algún dato obligatorio como nulo
                return null;
            }
        }
    }
}