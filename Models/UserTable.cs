using System;
using System.Collections.Generic;

namespace reactmovie.api.Models
{
    public partial class UserTable
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
