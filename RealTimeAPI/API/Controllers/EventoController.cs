using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers {
    public class EventoController : ApiController {
        // GET api/<controller>
        public List<Evento> Get() {
            return EventoRepository.ObtenerEventos();
        }

        // GET api/<controller>/5
        public Evento Get(int id) {
            return EventoRepository.ObtenerEvento(id);
        }
    }
}