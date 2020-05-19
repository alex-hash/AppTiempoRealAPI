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

        public Monedero Post([FromBody]dynamic model) {
            //id = idJugador
            try
            {
                string id = model["idJugador"];
                string saldoS = model["saldo"];
                int idJugador = Int32.Parse(id);
                decimal saldo = decimal.Parse(saldoS);
                return MonederoRespository.NuevoMonedero(idJugador, saldo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Monedero Get(int id) {
            //id = idJugador
            return MonederoRespository.ObtenerMonedero(id);
        }
    }
}