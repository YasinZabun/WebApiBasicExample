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
        
        public User yeni(int id)
        {
            User usr = Datas.Users.FirstOrDefault(x => x.Id == id);
            return usr;
        }
        [HttpGet]
        public List<User> Get()
        {
            return Datas.Users;
        }
        [HttpGet("{id}")]
        public User Get(int id)
        {
            User usr = Datas.Users.FirstOrDefault(x => x.Id == id);
            return usr;
        }
        [HttpPost]
        public User Post([FromBody]User user)
        {
            Datas.Users.Add(user);
            return user;
        }
        [HttpPut]
        public User Put([FromBody]User user)
        {
            User edituser = Datas.Users.FirstOrDefault(x => x.Id == user.Id);
            edituser.FirstName = "ben güncellendim";
            return edituser;
        }
        [HttpDelete("{id}")]
        public User Delete(int id)
        {
            User user = yeni(id);
            Datas.Users.Remove(user);
            return user;
        }
        

    }


    //adsfasdfasdf
}
