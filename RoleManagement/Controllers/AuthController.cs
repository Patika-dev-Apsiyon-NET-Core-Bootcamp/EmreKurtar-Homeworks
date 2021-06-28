using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RoleManagement.Data;
using RoleManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoleManagement.Controllers
{
    public class AuthController : Controller
    {
        private readonly SignInManager<User> _signInManager = null;
        public AuthController(SignInManager<User> signInManager)
        {
            _signInManager = signInManager;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginViewModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, false, false);

            if (result.Succeeded)
            {
                return RedirectToAction("Success");
            }

            return RedirectToAction("Login");
            
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

        public IActionResult Success()
        {
            return View();
        }

    }
}
