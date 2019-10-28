using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using reactmovie.api.Models;

namespace reactmovie.api.Services
{
    public class UserService : IUserService
    {
        private readonly MoviesContext _db;
        public UserService(MoviesContext db)
        {
            _db = db;
        }

        public bool RegisterUser(UserTable user)
        {

            try
            {
                _db.UserTable.Add(user);
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
