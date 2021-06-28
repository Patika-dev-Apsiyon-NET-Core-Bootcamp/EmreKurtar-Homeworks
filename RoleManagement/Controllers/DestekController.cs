using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RoleManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoleManagement.Controllers
{
    [Authorize(Roles = nameof(Roles.D))]
    public class DestekController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
