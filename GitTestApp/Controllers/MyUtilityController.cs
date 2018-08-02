using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GitTestApp.Controllers
{
    public class MyUtilityController : ApiController
    {
        // GET: api/MyUtility
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/MyUtility/5
        public string Get(int id)
        {
            if (id == 1)
                return "one";
            else
                return "no one";
        }
        public int Add(int a,int b)
        {
            return a + b;
        }
        // POST: api/MyUtility
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/MyUtility/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/MyUtility/5
        public void Delete(int id)
        {
        }
    }
}
