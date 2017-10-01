using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Mp_Social.Models;
using Newtonsoft.Json;

namespace Mp_Social.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        MP_SocialEntities dbContext = new MP_SocialEntities();
        // GET api/values
        public List<Employee> Get()
        {
            return dbContext.Employees.ToList();
        }

        // GET api/values/5
        public Employee Get(Guid ID)
        {
            return dbContext.Employees.SingleOrDefault(x => x.ID == ID);
        }

        // POST api/values
        public IHttpActionResult Post([FromBody]string json)
        {
            var obj = JsonConvert.DeserializeObject<Employee>(json);
            dbContext.Employees.Add(obj);
            dbContext.SaveChanges();
            return Ok();
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE api/values/5
        public IHttpActionResult Delete(Guid id)
        {
            var em = dbContext.Employees.SingleOrDefault(x => x.ID == id);
            dbContext.Employees.Remove(em);
            return Ok();
        }
    }
}
