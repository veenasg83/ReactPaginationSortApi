using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using reactmovie.api.Models;

namespace reactmovie.api.Services
{
    public class MovieService : IMovieService
    {
        private readonly MoviesContext _db;
        public MovieService(MoviesContext db)
        {
            _db = db;
        }
        public bool AddNewMovie(MovieTable movie)
        {
            try
            {
                _db.Add(movie);
                _db.SaveChanges();
                return true;
            }
            catch (DbException e)
            {
                return false;
            }
        }

        public bool updateMovie(MovieTable movie)
        {
            try
            {
                var dbmovie = _db.MovieTable.Where(m => m.MovieId == movie.MovieId).FirstOrDefault();
                dbmovie.MovieName = movie.MovieName;
                dbmovie.Genre = movie.Genre;
                dbmovie.Stock = movie.Stock;
                dbmovie.Language = movie.Language;
                _db.SaveChanges();
                return true;
            }
            catch (DbException e)
            {
                return false;
            }
        }
    }
}
