using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestApi.Controllers.Custom;

namespace RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ApiBaseController
    {
        // Sample Test
        private const string SECRET_HEADER = "My-Secret";

        public ValuesController()
        {
            if (!HttpContext.Request.Headers.ContainsKey(SECRET_HEADER) || !HttpContext.Request.Headers[SECRET_HEADER].Equals("my-secret"))
            {
                //return new StatusCodeResult(401);
            }
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
