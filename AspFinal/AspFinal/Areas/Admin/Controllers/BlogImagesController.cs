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
    public class BlogImagesController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;
        private readonly IFileManager _fileManager;
        public BlogImagesController(IBlogRepository blogRepository, IMapper mapper, IFileManager fileManager)
        {
            _blogRepository = blogRepository;
            _mapper = mapper;
            _fileManager = fileManager;
        }
        public IActionResult Index()
        {
            var blogimages = _blogRepository.GetBlogImages();
            var model = _mapper.Map<IEnumerable<BlogImages>, IEnumerable<BlogImagesViewModel>>(blogimages);
            return View(model);
        }
        public IActionResult Create()
        {
            ViewBag.BLogs = _blogRepository.GetBlogsTrue();

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BlogImagesViewModel model)
        {
            ViewBag.BLogs = _blogRepository.GetBlogsTrue();

            if (model == null) return NotFound();
            if (ModelState.IsValid)
            {
                var blogImages = _mapper.Map<BlogImagesViewModel, BlogImages>(model);
                blogImages.AddedBy = _admin.Name;
                blogImages.AddedDate = DateTime.Now;
                if (model.File != null)
                {
                    blogImages.Image = _fileManager.Upload(model.File);

                }
                else
                {
                    blogImages.Image = null;
                }
                _blogRepository.AddBlogIMages(blogImages);
                return RedirectToAction("index");
            }
            return View(model);
        }
        public IActionResult Edit(int id)
        {
            ViewBag.BLogs = _blogRepository.GetBlogsTrue();

            var blogimages = _blogRepository.GetBlogImagesById(id);
            var model = _mapper.Map<BlogImages, BlogImagesViewModel>(blogimages);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(BlogImagesViewModel model)
        {
            ViewBag.BLogs = _blogRepository.GetBlogsTrue();

            var blogimages = _mapper.Map<BlogImagesViewModel, BlogImages>(model);

            if (model == null) return NotFound();

            if (ModelState.IsValid)
            {
                var updateBlogimages = _blogRepository.GetBlogImagesById(model.Id);

                updateBlogimages.ModifiedBy = _admin.Name;
                updateBlogimages.ModifiedDate = DateTime.Now;
                if (model.File != null)
                {
                    blogimages.Image = _fileManager.Upload(model.File);

                }
                else
                {
                    blogimages.Image = updateBlogimages.Image;

                }
                _blogRepository.UpdateBlogIMages(updateBlogimages, blogimages);

                return RedirectToAction("index");
            }
            return View(model);
        }
        public IActionResult Remove(int id)
        {
            var blogimage = _blogRepository.GetBlogImagesById(id);
            _blogRepository.RemoveBlogIMages(blogimage);
            if (blogimage.Image != null)
            {
                _fileManager.Delete(blogimage.Image);

            }
            var blogimages = _blogRepository.GetBlogImages();
            var model = _mapper.Map<IEnumerable<BlogImages>, IEnumerable<BlogImagesViewModel>>(blogimages);
            return PartialView("index", model);
        }
    }
}