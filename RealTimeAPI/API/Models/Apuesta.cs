using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models {
    public class Apuesta {
        private int idApuesta;
        private int idEvento;
        private int idJugador;
        private decimal cantidad;
        private DateTime fecha;
        private string prediccion;
        private bool? resultado;

        public int IdApuesta { get => idApuesta;  }
        public int IdEvento { get => idEvento; set => idEvento = value; }
        public int IdJugador { get => idJugador; set => idJugador = value; }
        public decimal Cantidad { get => cantidad; set => cantidad = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Prediccion { get => prediccion; set => prediccion = value; }
        public bool? Resultado { get => resultado; set => resultado = value; }

        public Apuesta(int idApuesta, int idEvento, int idJugador, decimal cantidad, DateTime fecha, string prediccion, bool resultado) {
            this.idApuesta = idApuesta;
            this.idEvento = idEvento;
            this.idJugador = idJugador;
            this.cantidad = cantidad;
            this.fecha = fecha;
            this.prediccion = prediccion;
            this.resultado = resultado;
        }

        public Apuesta(DAL.Apuesta model) {
            this.idApuesta = model.idApuesta;
            this.idEvento = model.idEvento;
            this.idJugador = model.idJugador;
            this.cantidad = model.cantidad;
            this.fecha = model.fecha;
            this.prediccion = model.prediccion;
            this.resultado = model.resultado;
        }
    }
}