using Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class MyDBContext : IdentityDbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) :base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> UserTable { get; set; }
        public DbSet<Blog> Blogs { get; set; }


    }
}
