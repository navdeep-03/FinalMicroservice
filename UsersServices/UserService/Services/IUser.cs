using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Models;

namespace UserService.Services
{
    public interface IUser
    //CURD methods

    {

        User GetUser(int ID);
        User GetUsers();

    }
}
