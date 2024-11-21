using Bll;
using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LibraryProject.Controllers
{
    [RoutePrefix("api/Graph")]

    public class GraphController : ApiController
    {
        [Route("")]
        [HttpGet]
        public IHttpActionResult GetAllUsers()
        {
            try
            {
                //Bll.GFG.Main();
                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }


        [Route("findRouteByBookId")]
        [HttpGet]
        public IHttpActionResult findRouteByBookId([FromUri] int id)
        {
            try
            {
                
                int location = GraphBll.findRouteByBookId(id);
                List<int> routes=new List<int>();
                routes = Bll.GFG.Main(0,location);
                return Ok(routes);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}