using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using Allaia.Libs;
using AspFinal.Areas.Admin.Models.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repository.CategoryRepository;

namespace AspFinal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [TypeFilter(typeof(Auth))]
    public class CategoriesController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly ICategoryyRepository _categoryRepository;
        private readonly IMapper _mapper;
        private readonly IFileManager _fileManager;
        public CategoriesController(ICategoryyRepository categoryRepository,IMapper mapper,IFileManager fileManager)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
            _fileManager = fileManager;
        }
        public IActionResult Index()
        {
            var categories = _categoryRepository.GetFullCategories();
            var model = _mapper.Map<IEnumerable<Category>, IEnumerable<CategoryViewModel>>(categories);
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
           
            return View();
        }
        //Servis Creat//
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CategoryViewModel model)
        {
            if (model == null) return NotFound();
            if (ModelState.IsValid)
            {
                var category = _mapper.Map<CategoryViewModel, Category>(model);
                category.AddedBy = _admin.Name;
                category.AddedDate = DateTime.Now;
                if(model.Images != null)
                {
                    category.Image = _fileManager.Upload(model.Images);

                }
                else
                {
                    category.Image = null;
                }
                _categoryRepository.AddCategory(category);
                return RedirectToAction("index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var category=_categoryRepository.GetCategoryById(id);
            if (category == null) return NotFound();
            var model = _mapper.Map<Category, CategoryViewModel>(category);
            return View(model);
        }
        //Servis Edit//
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CategoryViewModel model)
        {
            var category = _mapper.Map<CategoryViewModel, Category>(model);

            if (model == null) return NotFound();

            if (ModelState.IsValid)
            {
                var updateCategory = _categoryRepository.GetCategoryById(model.Id);

                updateCategory.ModifiedBy = _admin.Name;
                updateCategory.ModifiedDate = DateTime.Now;
                if (model.Images == null)
                {
                    category.Image = updateCategory.Image;
                }
                else
                {
                    category.Image = _fileManager.Upload(model.Images);
                }
                   

                
                _categoryRepository.UpdateCategory(updateCategory, category);

                return RedirectToAction("index");
            }
            return View(model);
        }
        //Remove Servis//
        public IActionResult Remove(int id)
        {
            var category = _categoryRepository.GetCategoryById(id);
           _categoryRepository.RemoveCategoryId(category);
            if(category.Image != null)
            {
                _fileManager.Delete(category.Image);
            }
          
            var categories = _categoryRepository.GetFullCategories();
            var model = _mapper.Map<IEnumerable<Category>, IEnumerable<CategoryViewModel>>(categories);
            return PartialView("index", model);
        }

    }
}