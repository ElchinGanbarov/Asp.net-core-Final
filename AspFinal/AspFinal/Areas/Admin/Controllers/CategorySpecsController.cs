using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repository.CategoryRepository;

namespace AspFinal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [TypeFilter(typeof(Auth))]
    public class CategorySpecsController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly ICategoryyRepository _categoryRepository;
        public CategorySpecsController(ICategoryyRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            var model = _categoryRepository.GetFullCategorySpecs();
            return View(model);
        }
        public IActionResult Create()
        {
            ViewBag.Categories = _categoryRepository.GetFullCategories();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CategorySpecs model)
        {
            ViewBag.Categories = _categoryRepository.GetFullCategories();
            if (model == null) return NotFound();
            if (ModelState.IsValid)
            {
                model.AddedBy = _admin.Name;
                model.AddedDate = DateTime.Now;
                _categoryRepository.CreateCategorySpecs(model);
                return RedirectToAction("index");
            }
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            ViewBag.Categories = _categoryRepository.GetFullCategories();
            var model = _categoryRepository.GetCategorySpecsById(id);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CategorySpecs model)
        {
            ViewBag.Categories = _categoryRepository.GetFullCategories();
            var updatecategoryspecs = _categoryRepository.GetCategorySpecsById(model.Id);
            if (model == null) return NotFound();
            if (ModelState.IsValid)
            {
                updatecategoryspecs.ModifiedBy = _admin.Name;
                updatecategoryspecs.ModifiedDate = DateTime.Now;
                _categoryRepository.UpdateCategorySpecs(updatecategoryspecs, model);
                return RedirectToAction("index");
            }
            return View(model);
        }
        public IActionResult Remove(int id)
        {
            var categoryspecs = _categoryRepository.GetCategorySpecsById(id);
            _categoryRepository.RemoveCategoryspecsId(categoryspecs);
            var model = _categoryRepository.GetFullCategorySpecs();
            return PartialView("index", model);
        }
    }
}