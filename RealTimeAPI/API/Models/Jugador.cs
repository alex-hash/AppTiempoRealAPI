using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models {
    public class Jugador {
        private int id;
        private string nombre;
        private string apellido;
        private string login;
        private string password;
        public int Id { get => id; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }

        public Jugador(DAL.Jugador model) {
            this.id = model.idJugador;
            this.nombre = model.nombre;
            this.apellido = model.apellido;
            this.login = model.login;
            this.password = model.password;
        }

        public Jugador(string nombre, string apellido, string login, string password) {
            this.id = 0;
            this.nombre = nombre;
            this.apellido = apellido;
            this.login = login;
            this.password = password;
        }
    }
}