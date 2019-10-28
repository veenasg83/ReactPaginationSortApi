using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using reactmovie.api.Models;
using reactmovie.api.Services;

namespace reactmovie.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : Controller
    {
        private MoviesContext _movieContext;
        private readonly IMovieService _service;

        public MovieController(MoviesContext movieContext, IMovieService service)
        {
            _movieContext = movieContext;
            _service = service;
        }
        // GET: api/Movie
        [HttpGet]
        public IEnumerable<MovieTable> Get()
        {

            return _movieContext.MovieTable;
        }

        // GET: api/Movie/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Movie
        [HttpPost]
        public void Post([FromBody]MovieTable movie)
        {
            _service.AddNewMovie(movie);

        }

        // PUT: api/Movie/5
        [HttpPut("editMovie")]
        public void Put([FromBody] MovieTable value)
        {
            _service.updateMovie(value);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
