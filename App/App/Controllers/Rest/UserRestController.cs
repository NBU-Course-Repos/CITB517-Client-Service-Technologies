using App.Persistence.Models;
using App.Persistence.Services;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers.Rest
{
    [Route("/rest/api/user")]
    [ApiController]
    public class UserRestController : Controller
    {
        private readonly UserService service;
        public UserRestController() { 
            service = new UserService(); 
        }

        [HttpPost]
        public User? Create(CreateUserRequest request) =>
            service.Create(new User() { Email = request.EmailAddress, DisplayName = request.displayName});

        [HttpGet, Route("{emailAddress}")]
        public User? GetbyId(String emailAddress) =>
            service.GetById(emailAddress);


        [HttpDelete, Route("{emailAddress}")]
        public void Delete(String emailAddress) => 
            service.Delete(emailAddress);

        [HttpGet, Route("comments")]
        public ICollection<Comment> GetComments(String emailAddress) =>
            service.GetComments(emailAddress);

        [HttpGet, Route("all")]
        public ICollection<User> GetAllUsers() =>
            service.GetAll();
    }

    public class CreateUserRequest
    {
        public string EmailAddress { get; set; }
        public string displayName { get; set; }
    }
}
