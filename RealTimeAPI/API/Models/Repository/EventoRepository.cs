using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace API.Models {
    public static class EventoRepository {
        public static List<Evento> ObtenerEventos() {
            //obtiene todos los eventos
            List<DAL.Evento> eventos = Handler.DB.Evento.ToList();
            return eventos.ToLogical();
        }

        public static Evento ObtenerEvento(int idEvento) {
            //Obtiene un evento determinado dado su id
            DAL.Evento evento = Handler.DB.Evento.Where(e => e.idEvento == idEvento).FirstOrDefault();
            if (evento != null)
            {
                return new Evento(evento);
            } else
            {
                return null;
            }

        }

        public static bool ModificarCuotaEvento(int idEvento, float nuevaCuota) {
            //Modifica la cuota de un evento
            DAL.Evento evento = Handler.DB.Evento.Where(e => e.idEvento == idEvento).FirstOrDefault();
            if (evento != null)
            {
                evento.cuota = nuevaCuota;
                Handler.DB.SaveChanges();
                return true;
            } else
            {
                return false;
            }
        }
    }
}