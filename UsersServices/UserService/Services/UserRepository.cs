using System;
using System.Collections.Generic;
using System.Linq;
using UserService.Data;
using UserService.Models;
using UserService.Services;

namespace UserService.Services
{
    public class UserRepository : IUser
    {

        private UserDBContext UserDBContext;

        public UserRepository(UserDBContext _UserDBContext)
        {
            UserDBContext = _UserDBContext;

        }


        public User GetUser(int id)
        {
            var Userfound = UserDBContext.UsersInfo.SingleOrDefault(i => i.Id == id);
            return Userfound;
        }


        public User GetUsers()
        {
            var Userfound = UserDBContext.UsersInfo.FirstOrDefault();
            return Userfound;
        }






    }
}

