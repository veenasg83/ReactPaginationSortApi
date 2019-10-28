using reactmovie.api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reactmovie.api.Services
{
    public interface IUserService
    {
        bool RegisterUser(UserTable user);
    }
}
