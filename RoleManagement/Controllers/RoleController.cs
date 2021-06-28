using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RoleManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoleManagement.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager = null;

        public RoleController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AddRole()
        {

            //await _roleManager.CreateAsync(new IdentityRole { Name = nameof(Roles.HR) });
            //await _roleManager.CreateAsync(new IdentityRole { Name = nameof(Roles.IT) });
            //await _roleManager.CreateAsync(new IdentityRole { Name = nameof(Roles.Marketing) });
            await _roleManager.CreateAsync(new IdentityRole { Name = nameof(Roles.D) });

            return View();

        }


    }
}
