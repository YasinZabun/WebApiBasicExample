using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public static class Datas
    {
        public static List<User> Users=new List<User>() {
        (new User { Id = 1, FirstName = "yasin", LastName = "zabun" }),
        (new User { Id = 2, FirstName = "ali", LastName = "mazak" }),
        (new User { Id = 3, FirstName = "veli", LastName = "basdemir" }),
        (new User { Id = 4, FirstName = "kenan", LastName = "bas" }),
        (new User { Id = 5, FirstName = "hakan", LastName = "yerden" }),
        (new User { Id = 6, FirstName = "serkan", LastName = "gökten" })
        
        };
    }
}
