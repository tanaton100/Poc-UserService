
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
                await _userService.AddAsync(new User
                {
                    FirstName = requestUserModel.FirstName,
                    LastName = requestUserModel.LastName,
                    UserName = requestUserModel.UserName,
                    Tel = requestUserModel.Tel
                });
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            var result = await _userService.GetAsync(_ => _.Id == new ObjectId(id));

            if (result != null)
            {
                return View(result);

            }

            return RedirectToAction(nameof(Index));
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, User input)
        {
            try
            {
                input.Id = new ObjectId(id);

                await _userService.UpdateAsync(input);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            var result = await _userService.GetAsync(_ => _.Id == new ObjectId(id));


            return View(result);
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(string id, User input)
        {
            try
            {
                await _userService.DeleteAsync(_ => _.Id == new ObjectId(id));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
