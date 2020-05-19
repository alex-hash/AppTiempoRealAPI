using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models.Repository {
    public static class MonederoRespository {
        public static Monedero NuevoMonedero(int idJugador, decimal saldo = 0m) {
            try
            {
                var db = Handler.DB;
                db.Monedero.Add(new Monedero(idJugador, saldo).ToModel());
                db.SaveChanges();
                return ObtenerMonedero(idJugador);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Exception of type {ex.GetType()}: {ex.Message}");
                return null;
            }
        }

        public static Monedero ObtenerMonedero(int idJugador) {
            DAL.Monedero mon = Handler.DB.Monedero.Where(m => m.idJugador == idJugador).FirstOrDefault();
            if (mon != null)
            {
                return new Monedero( mon );
            } else
            {
                //No se encontró el monedero
                return null;
            }
        }
    }
}