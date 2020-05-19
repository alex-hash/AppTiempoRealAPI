using API.Models;
using API.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace API.Controllers
{
    public class MonederoController : ApiController
    {
        // GET: Monedero
        public Monedero Post(int id) {
            //id = idJugador
            return MonederoRespository.NuevoMonedero(id);
        }

        public Monedero Get(int id) {
            //id = idJugador
            return MonederoRespository.ObtenerMonedero(id);
        }
    }
}