﻿using BullsAndCows.Models.BindingModels;
using BullsAndCows.Services.Contracts;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BullsAndCows.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUsersService usersService;

        public UserController(IUsersService usersService)
        {
            this.usersService = usersService;
        }

        public async Task<IActionResult> Register()
        {
            await this.usersService.LogoutUserAsync();

            return View(new UserBindingModel());
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var userCreationStatus = await this.usersService.CreateUserAsync(model);

            if (!userCreationStatus)
            { 
                //TODO: make status msg to a constant 
                model.StatusMessage = "Error: User already exists. Please, try again with different username.";
                return View(model);
            }

            return RedirectToAction(nameof(Login));
        }
        public async Task<IActionResult> Login()
        {
            await this.usersService.LogoutUserAsync();

            return View(new UserLoginBindingModel());
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                //TODO: make error msg constant
                model.StatusMessage = "Error: Invalid username or password!";
                return View(model);
            }

            var loginStatus = await this.usersService.LoginUserAsync(model);

            if (!loginStatus)
            {
                model.StatusMessage = "Error: Invalid username or password!";
                return View(model);
            }

            return Redirect("/");
        }
    
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await this.usersService.LogoutUserAsync();

            return Redirect("/");
        }

        [Authorize]
        public async Task<IActionResult> Profile()
        {
            var activeUser = this.User;

            var userProfileViewModel = await this.usersService.GetLoggedUserModelAsync(activeUser);

            return View(userProfileViewModel);
        }

        [Authorize]
        [HttpPost]        
        public async Task<IActionResult> Delete()
        {
            var name = this.User.Identity.Name;

            await this.usersService.DeleteUserAsync(name);
            await this.usersService.LogoutUserAsync();

            return Redirect("/");
        }

    }
}