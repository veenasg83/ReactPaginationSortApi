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
    public class SalesController : ControllerBase
    {
        private MoviesContext _movieContext;


        public SalesController(MoviesContext movieContext)
        {
            _movieContext = movieContext;

        }
        // GET: api/Sales
        [HttpGet]
        public JsonResult GetSales()
        {
            //return _movieContext.Sale;
            var sale = _movieContext.Sale.Select(p => new
            {
                Id = p.SaleId,
                SaleDate = p.SaleDate,
                MovieName = p.Movie.MovieName,
                Author = p.Author.Author1
            }).ToList();
            return new JsonResult(sale);
        }

        //// GET: api/Sales/5
        //[HttpGet("{id}", Name = "Get")]
        //public string GetSaleWithId(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Sales
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT: api/Sales/5
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
