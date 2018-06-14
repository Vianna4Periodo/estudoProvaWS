using EstudoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EstudoAPI.Controllers
{
    [RoutePrefix("estudo/api")]
    public class CostumersController : ApiController
    {
        static private IList<Costumer> costumers = new List<Costumer>();

        [Route("costumers")]
        [HttpGet]
        public IEnumerable<Costumer> Find()
        {
            return costumers;
        }

        [Route("costumers/{id}")]
        [HttpGet]
        public Costumer FindById(int id)
        {
            return costumers[0];
        }

        [Route("costumers")]
        [HttpPost]
        public void Post([FromBody]Costumer costumer)
        {
            costumers.Add(costumer);
        }

        [Route("costumers/{id}")]
        [HttpPut]
        public void Put(int id, [FromBody]Costumer costumer)
        {
            var editedCostumer = costumers[0];
            editedCostumer.Nome = costumer.Nome;
            editedCostumer.Email = costumer.Email;
        }

        [Route("costumers/{id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            costumers.RemoveAt(0);
        }
    }
}
