using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.IoCContainer
{
    public static class DependencyContainer
    {

        public static IServiceCollection RegisterServices(this IServiceCollection service, IConfiguration Configuration)
        {

            service.AddDbContext<MyDBContext>(options =>
                                              options.UseSqlServer(Configuration.GetConnectionString("Default"))
                                              .UseLazyLoadingProxies());

            service2.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
              .AddEntityFrameworkStores<ApplicationDbContext>();

            service2.addd

            service.AddScoped<IBlogService, BlogService>();
            service.AddScoped<IBlogDAL, BlogRepository>();

            service.AddScoped<ICategoryService, CategoryService>();
            service.AddScoped<ICategoryDAL, CategoryRepository>();

            service.AddScoped<IUserService, UserService>();
            service.AddScoped<IUserDAL, UserRepository>();

            service.AddScoped<ICommentService, CommentService>();
            service.AddScoped<ICommentDAL, CommentRepository>();


            return service;

        }
    }
}
