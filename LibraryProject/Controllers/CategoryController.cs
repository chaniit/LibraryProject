using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Bll;
using Dto;

namespace LibraryProject.Controllers
{
    [RoutePrefix("api/Category")]
    public class CategoryController : ApiController
    {
        [Route("GetAllCategory")]
        [HttpGet]
        public IHttpActionResult GetAllCategory()
        {
            try
            {
                List<CategoryDto> category = CategoryBll.GetAllCategory();
                return Ok(category);
            }
            catch (Exception)
            {
                throw;
            }
        }


        // POST: api/Category
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Category/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Category/5
        public void Delete(int id)
        {
        }
    }
}
