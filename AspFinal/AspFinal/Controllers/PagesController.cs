using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspFinal.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Repository.CategoryRepository;
using Repository.Repository.HomeRepository;

namespace AspFinal.Controllers
{
    public class PagesController : Controller
    {
        private readonly IHomeRepository _homeRepository;
        public PagesController(IHomeRepository homeRepository)
        {
            _homeRepository = homeRepository;
        }
        public IActionResult About()
        {
            var model = new HomeViewModel
            {
                Categories = _homeRepository.GetCategories(),
                Settings = _homeRepository.GetSettings(),
                Agents=_homeRepository.GetAgents(),
                Brands=_homeRepository.GetBrands()
                
            };
            return View(model);
        }
        public IActionResult FAQ()
        {
            var model = new HomeViewModel
            {
                Categories = _homeRepository.GetCategories(),
                Settings = _homeRepository.GetSettings()
            };
            return View(model);
        }
        public IActionResult ServiceSingle()
        {
            var model = new HomeViewModel
            {
                Categories = _homeRepository.GetCategories(),
                Settings = _homeRepository.GetSettings()
            };
            return View(model);
        }
        public IActionResult Contact()
        {
            var model = new HomeViewModel
            {
                Categories = _homeRepository.GetCategories(),
                Settings = _homeRepository.GetSettings()
            };
            return View(model);
        }
        public IActionResult Error404()
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