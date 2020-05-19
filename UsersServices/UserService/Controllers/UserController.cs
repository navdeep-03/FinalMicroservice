using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserService.Services;

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUser UserRepository;
        public UserController(IUser _UserRepository)
        {
            UserRepository = _UserRepository;
        }
        [HttpGet()]
        public IActionResult GetUsers()
        {
            var User = UserRepository.GetUsers();
            if (User == null)
            {
                return NotFound("No Record Found...");
            }
            return Ok(User);
        }
        [HttpGet("{Id}")]
        public IActionResult Get(int Id)
        {
            var User = UserRepository.GetUser(Id);
            if (User == null)
            {
                return NotFound("No Record Found...");
            }
            return Ok(User);
        }
    }
}