
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using POC_UserService.Models;
using POC_UserService.Service;

namespace POC_UserService.Controllers
{
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            //return View(await _userService.FindAsync(_ => true));

            var Response = new List<User>
            {
                new User
                {
                    Id = ObjectId.GenerateNewId(),
                    FirstName = "mock",
                    LastName ="lo",
                    Tel="ss",
                    UserName= "ss"
                }
            };

            return View(Response);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateUser([FromBody] RequestUserModel requestUserModel)
        {
            var request = new User
            {
                UserName = requestUserModel.UserName,
                FirstName = requestUserModel.FirstName,
                LastName = requestUserModel.LastName,
                Tel = requestUserModel.Tel
            };

            await _userService.AddAsync(request);

            return RedirectToAction(nameof(GetAll));
        }
    }
}
