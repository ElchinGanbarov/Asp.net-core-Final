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
    public class BlogController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IBlogRepository _blogrepository;
        private readonly IMapper _mapper;
        private readonly IFileManager _fileManager;
        public BlogController(IBlogRepository blogrepository, IMapper mapper, IFileManager fileManager)
        {
            _blogrepository = blogrepository;
            _mapper = mapper;
            _fileManager = fileManager;
            
        }
        public IActionResult Index()
        {
            var blogs = _blogrepository.GetBlogText();
            var model = _mapper.Map<IEnumerable<Blog>, IEnumerable<BlogTablesViewModel>>(blogs);
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BlogTablesViewModel model)
        {
            if (model == null) return NotFound();
            if (ModelState.IsValid)
            {
                var blog = _mapper.Map<BlogTablesViewModel, Blog>(model);
                blog.AddedBy = _admin.Name;
                blog.AddedDate = DateTime.Now;
                _blogrepository.AddBlog(blog);
                return RedirectToAction("index");
            }
            return View(model);
        }
        public IActionResult Edit(int id)
        {
            var blog = _blogrepository.GetBlogById(id);
            var model = _mapper.Map<Blog, BlogTablesViewModel>(blog);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(BlogTablesViewModel model)
        {
            var blog = _mapper.Map<BlogTablesViewModel, Blog>(model);

            if (model == null) return NotFound();

            if (ModelState.IsValid)
            {
                var updateBlog = _blogrepository.GetBlogById(model.Id);

                updateBlog.ModifiedBy = _admin.Name;
                updateBlog.ModifiedDate = DateTime.Now;

                _blogrepository.UpdateBlog(updateBlog, blog);

                return RedirectToAction("index");
            }
            return View(model);
        }
        public IActionResult Remove(int id)
        {
            var blog = _blogrepository.GetBlogById(id);
            _blogrepository.RemoveBlog(blog);
            var blogs = _blogrepository.GetBlogText();
            var model = _mapper.Map<IEnumerable<Blog>, IEnumerable<BlogTablesViewModel>>(blogs);
            return PartialView("index", model);
        }
    }
}