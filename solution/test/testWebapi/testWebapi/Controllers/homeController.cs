using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace testWebapi.Controllers
{
    public class homeController : ApiController
    {
        // GET: api/home
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/home/5
        public string Get(int id)
        {
            return id.ToString();
        }

        // POST: api/home
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/home/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/home/5
        public void Delete(int id)
        {
        }
    }
}
