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
    [RoutePrefix("api/User")]
    public class UsersController : ApiController
    {
        [Route("GetAllUsers")]
        [HttpGet]
        public IHttpActionResult GetAllUsers()
        {
            try
            {
                List<UserDto> users = UserBll.GetAllUsers();
                return Ok(users);              
            }
            catch (Exception)
            {
                throw;
            }
        }


        [Route("AddUser")]
        [HttpPost]
        public IHttpActionResult AddUser(UserDto user)
        {
            try
            {
                //UserDto userDto=new UserDto();
                UserDto newUsesr = UserBll.AddUser(user);
                return Ok(newUsesr);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [Route("CheckPassword")]
        [HttpPost]
        public IHttpActionResult CheckPassword(UserDto user)
        {
            try
            {
                UserDto newUsesr = UserBll.CheckPassword(user);
                return Ok(newUsesr);
            }
            catch (Exception)
            {

                throw;
            }
        }


        // PUT: api/Users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Users/5
        public void Delete(int id)
        {
        }
    }
}
