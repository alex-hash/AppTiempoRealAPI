using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers {
    public class JugadorController : ApiController {

        // GET api/Jugador/id
        public Jugador Get(int id) {
            return JugadorRepository.ObtenerJugador(id);
        }

        // GET api/Jugador/login&pass
        public Jugador GetLogin(string login, string pass) {
            return JugadorRepository.ObtenerJugador(login, pass);
        }

        // POST api/values
        public void Post([FromBody]Jugador jugador) {
            //TODO: Creacion del jugador
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value) {
            //TODO:
        }
    }
}
