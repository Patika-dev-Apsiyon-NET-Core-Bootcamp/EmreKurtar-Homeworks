using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoleManagement.Data
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public virtual ICollection<Department> Departments{ get; set; }

    }

    public class Department
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public IdentityRole Role{ get; set; }
        public virtual ICollection<User> Users { get; set; }

    }
}
