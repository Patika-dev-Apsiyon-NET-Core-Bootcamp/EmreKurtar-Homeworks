using Entities.Abstract;
using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string TC { get; set; }



        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Blog> Blogs { get; set; }


    }
}
