using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Bll;
using Dto;

namespace LibraryProject
{
    [RoutePrefix("api/Book")]
    public class BooksController : ApiController
    {
        
        [Route("GetAllBooks")]
        [HttpGet]
        public IHttpActionResult GetAllBooks()
        {
            try
            {
                List<BooksDto> books = BookBll.GetAllBooks();
                return Ok(books);
            }
            catch (Exception)
            {
                throw;
            } 
        }


        [Route("GetByCategory")]
        [HttpGet]
        public IHttpActionResult GetByCategory([FromUri]int id)
        {
            try
            {
                List<BooksDto> books = BookBll.GetByCategory(id);
                return Ok(books);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [Route("GetByDate")]
        [HttpGet]
        public IHttpActionResult GetByDate([FromUri] DateTime date)
        {
            try
            {
                List<BooksDto> books = BookBll.GetByDate(date);
                return Ok(books);
            }
            catch (Exception)
            {
                throw;
            }
        }


        [Route("GetByParametrs")]
        [HttpGet]
        public IHttpActionResult GetByParametrs([FromUri] int age, string kind)
        {
            try
            {
                List<BooksDto> books = BookBll.GetByParametrs(age, kind);
                return Ok(books);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }

    
}
