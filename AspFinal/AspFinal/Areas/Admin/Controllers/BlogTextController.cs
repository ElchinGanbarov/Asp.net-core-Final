using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using Allaia.Libs;
using AspFinal.Areas.Admin.Models.Agents;
using AspFinal.Areas.Admin.Models.BlogTables;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repository.BlogRepository;
using Repository.Repository.CategoryRepository;
using Repository.Repository.HomeRepository;

namespace AspFinal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [TypeFilter(typeof(Auth))]
    public class BlogTextController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IBlogRepository _blogrepository;
        private readonly IMapper _mapper;
        private readonly IFileManager _fileManager;
        public BlogTextController(IBlogRepository blogrepository )
        {
            _blogrepository = blogrepository;
        }
        public IActionResult Index()
        {
            var blogs = _blogrepository.GetBlogTextLIst();
            return View(blogs);
        }
        public IActionResult Create()
        {
            ViewBag.Blog = _blogrepository.GetBlogText();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BlogText model)
        {
            ViewBag.Blog = _blogrepository.GetBlogText();

            if (model == null) return NotFound();
            if (ModelState.IsValid)
            {

                model.AddedBy = _admin.Name;
                model.AddedDate = DateTime.Now;
              
                _blogrepository.AddBlogtext(model);
                return RedirectToAction("index");
            }
            return View(model);
        }
        public IActionResult Edit(int id)
        {
            ViewBag.Blog = _blogrepository.GetBlogText();

            var model = _blogrepository.GetBlogTextById(id);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(BlogText model)
        {

            if (model == null) return NotFound();

            if (ModelState.IsValid)
            {
                var updateBlogTExt = _blogrepository.GetBlogTextById(model.Id);

                updateBlogTExt.ModifiedBy = _admin.Name;
                updateBlogTExt.ModifiedDate = DateTime.Now;
              
              



                _blogrepository.UpdateBlogtext(updateBlogTExt, model);

                return RedirectToAction("index");
            }
            return View(model);
        }
        public IActionResult Remove(int id)
        {
            var model = _blogrepository.GetBlogTextById(id);
            _blogrepository.RemoveBlogText(model);
            var blogs = _blogrepository.GetBlogTextLIst();
            return PartialView("index", blogs);
        }
    }
}