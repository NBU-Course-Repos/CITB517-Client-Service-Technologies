using App.Persistence.Models;
using App.Persistence.Services;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using System.Net.Sockets;

namespace App.Controllers.Rest
{
    [Route("/rest/user")]
    [ApiController]
    public class UserController : AbstractRestModelController<User, String, UserService>
    {
        public UserController() : base(new UserService())
        {
        }

        [HttpPost, Route("create")]
        public IActionResult Create(string emailAddress, string displayName)
        {
            var result = base.Create(new User(emailAddress, displayName));
            return result;
        }

        [HttpGet, Route("print")]
        public string Print()
        {
            return "hello";
        }
    }
}
