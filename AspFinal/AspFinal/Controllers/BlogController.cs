using System;
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
        //BlogGrid View
        public IActionResult BlogGrid()
        {
            var model = new HomeViewModel
            {
                Categories = _homeRepository.GetCategories(),
                Settings = _homeRepository.GetSettings(),
                Blogs = _homeRepository.GetBlogs(6),
                BlogImages=_blogRepository.ImagesTrue()
              
                
            };
            return View(model);
        }

        //BlogSingle View
        public IActionResult BlogSingle()
        {
            var model = new BlogViewModel {

                Categories = _categoryRepository.GetCategories(),
                Tags = _categoryRepository.GetTags(),
                Posts = _categoryRepository.GetPosts(),
                BlogTexts = _blogRepository.GetBlogStatus(),
                Settings=_homeRepository.GetSettings(),
                Comments=_homeRepository.CommentsList()
            };
            return View(model);
        }

        //Comments Added Database//
        [HttpPost]
        public IActionResult Comment(CommentViewModel model)
        {
            if (ModelState.IsValid)
            {
                var comment = _mapper.Map<CommentViewModel, Comments>(model);
                comment.DateTime = DateTime.Now;
                _categoryRepository.CreateContact(comment);
                return Ok(model);
            }
            return View("~/Views/Blog/BlogSingle.cshtml", new BlogViewModel
            {
                Contact = model
            }); 
        }

    }
}