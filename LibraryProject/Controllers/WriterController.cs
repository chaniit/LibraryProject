using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dto;
using Bll;

namespace LibraryProject.Controllers
{
    [RoutePrefix("api/Writer")]
    public class WriterController : ApiController
    {
        [Route("GetAllWriters")]
        [HttpGet]
        public IHttpActionResult GetAllWriters()
        {
            try
            {
                List<WriterDto> writers = WriteBll.GetAllWriters();
                return Ok(writers);
            }
            catch (Exception)
            {
                throw;
            }
           
        }

        [Route("GetByWriterId")]
        [HttpGet]
        public IHttpActionResult GetByWriterId([FromUri] int id)
        {
            try
            {
                List<WriterDto> writers = WriteBll.GetByWriterId(id);
                return Ok(writers);
            }
            catch (Exception)
            {
                throw;
            }
        }


        // POST: api/Writer
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Writer/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Writer/5
        public void Delete(int id)
        {
        }
    }
}
