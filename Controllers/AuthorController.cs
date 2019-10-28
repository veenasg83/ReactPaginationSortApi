using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using reactmovie.api.Models;

namespace reactmovie.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly MoviesContext _db;
        public AuthorController(MoviesContext db)
        {
            _db = db;
        }

        [HttpGet("getauthor/{id:int}")]
        public IActionResult GetAuthor(int id)
        {
            var authorList = _db.Author.Where(author => author.MovieId == id).Select(x => new { x.AuthorId, author = x.Author1, place = x.Place });
            if (authorList.Count() > 0)
            {
                return Ok(new { authorList, Message = "authorlist is retrieved" });

            }
            return BadRequest("authors not retrieved");
        }
        // GET: api/Author
        [HttpGet]
        public IEnumerable<string> GetA()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Author/5
        [HttpGet("{id}", Name = "GetAuth")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Author
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        //// PUT: api/Author/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
