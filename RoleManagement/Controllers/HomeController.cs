using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RoleManagement.Data;
using RoleManagement.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RoleManagement.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager = null;

        public HomeController(ILogger<HomeController> logger, UserManager<User> userManager, SignInManager<User> signInManager,RoleManager<IdentityRole> roleManager)
        {
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            

            return View();
        }

        [AllowAnonymous]
        public async Task<IActionResult> Privacy()
        {
            //var result = await _userManager.CreateAsync(new Data.User { Email = "a@a.com", Name = "Emre", UserName = "0the1emre" }, "Emrek007!");
            //var result2 = await _userManager.CreateAsync(new Data.User { Email = "b@b.com", Name = "Can", UserName = "emrek00" }, "Emrek007!");
            var result3 = await _userManager.CreateAsync(new Data.User { Email = "c@c.com", Name = "Kurtar", UserName = "emrek003" }, "Emrek007!");

            return View();
        }

        public async Task<IActionResult> Addhr(string returnUrl = null)
        {
            User user = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            var name = nameof(Roles.HR);

            var result = await _userManager.AddToRoleAsync(user, name);

            await _signInManager.RefreshSignInAsync(user);

            await _signInManager.SignOutAsync();

            




            return View();
        }

        public async Task<IActionResult> Adddestek()
        {
            User user = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            var name = nameof(Roles.D);

            var result = await _userManager.AddToRoleAsync(user, name);

            await _signInManager.RefreshSignInAsync(user);

            await _signInManager.SignOutAsync();


            return View();
        }

        public async Task<IActionResult> Addit()
        {
            User user = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);

            await _userManager.AddToRoleAsync(user, nameof(Roles.IT));
            await _signInManager.RefreshSignInAsync(user);
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index","Home");
        }

        public async Task<IActionResult> Addmarketing()
        {
            User user = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);

            await _userManager.AddToRoleAsync(user, nameof(Roles.Marketing));

            await _signInManager.SignOutAsync();
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
