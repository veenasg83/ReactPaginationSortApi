using reactmovie.api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reactmovie.api.Services
{
    public class LanguageService : ILanguageService
    {
        private readonly MoviesContext _db;

        public LanguageService(MoviesContext db)
        {
            _db = db;
        }
        public IEnumerable<Language> GetLanguage()
        {
            return _db.Language;
        }
    }
}
