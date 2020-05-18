using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models {
    public static class ModelExtensions {
        //Extensiones de listas:
        public static List<Evento> ToLogical(this List<DAL.Evento> model) {
            //Extension: convierte lista de eventos entity a eventos logicos
            List<Evento> eventos = new List<Evento>();
            foreach (DAL.Evento e in model)
            {
                eventos.Add(new Evento(e));
            }
            return eventos;
        }

        //public static DAL.Evento ToModel(this Evento logical) {
        //    //Extension: convirte evento logico a modelo de entity
        //    DAL.Evento evento = new DAL.Evento();
        //    evento.idEvento = logical.Id;
        //    evento.nombre = logical.Nombre;
        //    evento.fecha = logical.Fecha;
        //    evento.cuota = (float)logical.Cuota;
        //    evento.resultado = logical.Resultado;
        //    return evento;
        //}

    }
}