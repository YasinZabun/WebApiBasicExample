using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    public class UsersControllers : ControllerBase
    {
        private List<User> _user = Datas.Users();
        
        public User yeni(int id)
        {
            User usr = _user.FirstOrDefault(x => x.Id == id);
            return usr;
        }
        [HttpGet]
        public List<User> Get()
        {
            return _user;
        }
        [HttpGet("{id}")]
        public User Get(int id)
        {
            User usr = _user.FirstOrDefault(x => x.Id == id);
            return usr;
        }
        [HttpPost]
        public User Post([FromBody]User user)
        {
            _user.Add(user);
            return user;
        }
        [HttpPut]
        public User Put([FromBody]User user)
        {
            User edituser = _user.FirstOrDefault(x => x.Id == user.Id);
            edituser.FirstName = "ben güncellendim";
            return edituser;
        }
        [HttpDelete("{id}")]
        public User Delete(int id)
        {
            User user = yeni(id);
            _user.Remove(user);
            return user;
        }
        

    }
}
