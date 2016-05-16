using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebAPISecurityTokenBasedAuth.API.Controllers
{
    public class NinjaController : ApiController
    {
        //[EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpGet]
        [Authorize]
        public List<string> GetNinjas()
        {
            List<string> ninjas = new List<string>();

            ninjas.Add("Mikalanjelo");
            ninjas.Add("Leonardo");
            ninjas.Add("Donatello");

            return ninjas;

        }
    }
}
