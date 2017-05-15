using MongoCrudAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MongoCrudAPI.Controllers
{
    public class NationController : ApiController
    {
        List<Nation> nations = new List<Nation>();

        [HttpGet]
        // GET api/<controller>
        public IEnumerable<Nation> Get()
        {
            return nations;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post(string name)
        {
            Nation nation = new Nation();
            nation.NationName = name;
            nation.NationPop = 0;
            nations.Add(nation);
        }

        // PUT api/<controller>/5
        public void ChangeName(int id, [FromBody]string name)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }

    }
}