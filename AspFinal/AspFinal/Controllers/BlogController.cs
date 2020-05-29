using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspFinal.Models;
using AspFinal.Models.Blogs;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repository.BlogRepository;
using Repository.Repository.CategoryRepository;
using Repository.Repository.HomeRepository;

namespace AspFinal.Controllers
{
    public class BlogController : Controller
    {
        private readonly ICategoryyRepository _categoryRepository;
        private readonly IHomeRepository _homeRepository;
        private readonly IMapper _mapper;
        private readonly IBlogRepository _blogRepository;

        public BlogController(IHomeRepository homeRepository,
                              ICategoryyRepository categoryRepository,
                              IMapper mapper,
                              IBlogRepository blogRepository)
        {
            _categoryRepository = categoryRepository;
            _homeRepository = homeRepository;
            _mapper = mapper;
            _blogRepository = blogRepository;
        }
        public IActionResult BlogGrid()
        {
            var model = new HomeViewModel
            {
                Categories = _homeRepository.GetCategories(),
                Settings = _homeRepository.GetSettings(),
                Blogs = _homeRepository.GetBlogs(),
              
                
            };
            return View(model);
        }
        public IActionResult BlogSingle()
        {
            var model = new BlogViewModel {

                Categories = _categoryRepository.GetCategories(),
                Tags = _categoryRepository.GetTags(),
                Posts = _categoryRepository.GetPosts(),
                BlogTexts = _blogRepository.GetBlogStatus(),
                Settings=_homeRepository.GetSettings()
                
                
            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact(CommentViewModel contact)
        {
            if (ModelState.IsValid)
            {
                var model = _mapper.Map<CommentViewModel, Comments>(contact);
                _categoryRepository.CreateContact(model);
                return RedirectToAction("blogsingle","blog");
            }


            return View("~/Views/Blog/BlogSingle.cshtml", new BlogViewModel
            {
                Contact = contact
            });

        }

    }
}