using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using data_core.Models;
using System.Web.Http.Cors;

namespace data_core.Controllers
{
    public class ProjectController : ApiController
    {
        // GET api/<controller>

        [EnableCors(origins: "http://localhost:51239",headers:"*", methods:"*")]
        public IEnumerable<Models.Project> Get()
        {
            List<Models.Project> projects = new List<Models.Project>();
            projects.Add(new Models.Project(1,"OMT", 1, "Open Market Transfer", System.DateTime.Now, System.DateTime.Now.AddMonths(3)));
            projects.Add(new Models.Project(2,"ATU/TPU", 1, "I dont know what is this", System.DateTime.Now, System.DateTime.Now.AddMonths(5)));
            projects.Add(new Models.Project(3,"PPR", 1, "Principle Performance Review", System.DateTime.Now, System.DateTime.Now.AddMonths(1)));
            projects.Add(new Models.Project(4,"CTE", 1, "Career & Technical Education", System.DateTime.Now, System.DateTime.Now.AddMonths(7)));

            return projects.AsEnumerable();
            
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}