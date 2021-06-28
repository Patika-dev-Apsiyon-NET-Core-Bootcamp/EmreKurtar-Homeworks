using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _30MayısHomework.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService = null;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }



        public async Task<IActionResult> Index()
        {
            List<Category> categories = await _categoryService.GetAll();



            return View(categories);
        }


        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Category category)
        {
            _categoryService.Add(category);

            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Delete(int id)
        {
            Category category = await _categoryService.Get(id);

            if (category != null)
            {
                await _categoryService.Delete(category);
            }
            else
            {
                ViewBag.NotFoundCategory = "Böyle bir kategori bulunamadı";
            }


            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Edit(int id)
        {
            Category category = await _categoryService.Get(id);

            if (category != null)
            {
                return View(category);
            }
            else
            {
                ViewBag.NotFoundCategory = "Böyle bir kategori bulunamadı";
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Category category)
        {
            Category updatedcategory = await _categoryService.Get(category.ID);
            updatedcategory.CategoryName = category.CategoryName;

            if (category != null)
            {
                await _categoryService.Update(category);

            }
            else
            {
                ViewBag.NotFoundCategory = "Böyle bir kategori bulunamadığı için güncellenemedi !!!";

            }

            return RedirectToAction("Index");


        }





    }
}
