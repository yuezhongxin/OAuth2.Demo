using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace OAuth2.Demo.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        [Authorize]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }

    public class CodesController : ApiController
    {
        [HttpGet]
        [Route("api/authorization_code")]
        public HttpResponseMessage Get(string code)
        {
            return new HttpResponseMessage()
            {
                Content = new StringContent(code, Encoding.UTF8, "text/plain")
            };
        }

        [HttpGet]
        [Route("api/access_token")]
        public HttpResponseMessage GetToken()
        {
            var url = Request.RequestUri;
            return new HttpResponseMessage()
            {
                Content = new StringContent("", Encoding.UTF8, "text/plain")
            };
        }
    }
}
