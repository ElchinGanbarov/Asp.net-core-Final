using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspFinal.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Repository.HomeRepository;

namespace AspFinal.Controllers
{
    public class BlogController : Controller
    {
        private readonly IHomeRepository _homeRepository;
        public BlogController(IHomeRepository homeRepository)
        {
            _homeRepository = homeRepository;
        }
        public IActionResult BlogGrid()
        {
            var model = new HomeViewModel
            {
                Categories = _homeRepository.GetCategories(),
                Settings = _homeRepository.GetSettings(),
                Blogs = _homeRepository.GetBlogs()
            };
            return View(model);
        }
        public IActionResult BlogSingle()
        {
            var model = new HomeViewModel
            {
                Categories = _homeRepository.GetCategories(),
                Settings = _homeRepository.GetSettings()
            };
            return View(model);
        }
    }
}