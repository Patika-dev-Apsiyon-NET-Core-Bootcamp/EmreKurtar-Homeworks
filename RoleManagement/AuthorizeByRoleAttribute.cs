using Microsoft.AspNetCore.Authorization;
using RoleManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoleManagement
{
    public class AuthorizeByRoleAttribute : AuthorizeAttribute
    {

        public AuthorizeByRoleAttribute(params string[] names)
        {
            Roles = string.Join(",", names);
        }




    }
}
