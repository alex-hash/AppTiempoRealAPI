using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models {
    public class Evento {
        private int id;
        private string nombre;
        private DateTime fecha;
        private float cuota;
        private string resultado;

        public int Id { get => id; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public float Cuota { get => cuota; set => cuota = value; }
        public string Resultado { get => resultado; set => resultado = value; }

        public Evento(string nombre, DateTime fecha, float cuota, string resultado) {
            this.nombre = nombre;
            this.fecha = fecha;
            this.cuota = cuota;
            this.resultado = resultado;
        }
        public Evento(DAL.Evento model) {
            this.nombre = model.nombre;
            this.fecha = model.fecha;
            this.cuota = (float)model.cuota;
            this.resultado = model.resultado;
        }

    }
}