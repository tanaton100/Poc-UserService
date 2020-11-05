
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using POC_UserService.Models;
using POC_UserService.Service;
using System;
using System.Threading.Tasks;

namespace POC_UserService.Controllers
{

    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: UserController
        public async Task<IActionResult> Index()
        {
            return View(await _userService.FindAsync(_ => true));
        }

        // GET: UserController/Details/5

        public async Task<IActionResult> Details(string id)
        {
            var result = await _userService.GetAsync(_ => _.Id == new ObjectId(id));
            return View(result);
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RequestUserModel requestUserModel)
        {
            try
            {
              await  _userService.AddAsync(new User
                {
                    FirstName = requestUserModel.FirstName,
                    LastName = requestUserModel.LastName,
                    UserName=requestUserModel.UserName,
                    Tel=requestUserModel.Tel
                });
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
