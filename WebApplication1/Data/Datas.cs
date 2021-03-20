using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public static class Datas
    {
        private static List<User> _users;
                
        public static List<User> Users() {
             if (_users == null)
             {
                _users = new List<User>();
                _users.Add(new User { Id = 1, FirstName = "yasin", LastName = "zabun" });
                _users.Add(new User { Id = 2, FirstName = "ali", LastName = "mazak" });
                _users.Add(new User { Id = 3, FirstName = "veli", LastName = "basdemir" });
                _users.Add(new User { Id = 4, FirstName = "kenan", LastName = "bas" });
                _users.Add(new User { Id = 5, FirstName = "hakan", LastName = "yerden" });
                _users.Add(new User { Id = 6, FirstName = "serkan", LastName = "gökten" });
            }
            return _users;
        }

    }
}
