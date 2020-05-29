using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AspFinal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Repository.Repository.HomeRepository;

namespace AspFinal.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeRepository _homeRepository;
        public HomeController(IHomeRepository homeRepository)
        {
            _homeRepository = homeRepository;
        }
        public IActionResult Index()
        {
            var model = new HomeViewModel
            {
                AboutUs = _homeRepository.GetAboutUs(),
                Categories = _homeRepository.GetCategories(),
                Settings = _homeRepository.GetSettings(),
                LikeableAreas = _homeRepository.GetLikeableAreas()

            };
            return View(model);
        }

    }
}
