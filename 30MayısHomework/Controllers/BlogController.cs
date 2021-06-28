using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _30MayısHomework.Controllers
{
    public class BlogController : Controller
    {
        private IBlogService _blogservice = null;
        private ICategoryService _categoryservice = null;

        public BlogController(IBlogService blogservice)
        {
            _blogservice = blogservice;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Add()
        {
            ViewBag.Categories = _categoryservice.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Add(Blog blog)
        {


            _blogservice.Add(blog);
            return View();
            

        }



    }
}
