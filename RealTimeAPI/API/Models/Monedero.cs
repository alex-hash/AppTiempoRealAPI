using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models {
    public class Monedero {
        private int idMonedero;
        private int idJugador;
        private decimal saldo;

        public int IdMonedero { get => idMonedero; }
        public int IdJugador { get => idJugador; set => idJugador = value; }
        public decimal Saldo { get => saldo; set => saldo = value; }

        public Monedero(int idMonedero, int idJugador, decimal saldo) {
            this.idMonedero = idMonedero;
            this.idJugador = idJugador;
            this.saldo = saldo;
        }

        public Monedero(DAL.Monedero model) {
            this.idMonedero = model.idMonedero;
            this.idJugador = model.idJugador;
            this.saldo = model.saldo;
        }
    }
}