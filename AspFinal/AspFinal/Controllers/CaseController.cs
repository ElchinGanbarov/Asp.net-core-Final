using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspFinal.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Repository.HomeRepository;

namespace AspFinal.Controllers
{
    public class CaseController : Controller
    {
        private readonly IHomeRepository _homeRepository;
        public CaseController(IHomeRepository homeRepository)
        {
            _homeRepository = homeRepository;
        }
        public IActionResult CaseStudies()
        {
            var model = new HomeViewModel
            {
                Categories = _homeRepository.GetCategories(),
                Settings = _homeRepository.GetSettings(),
                Agents = _homeRepository.GetAgents()
            };
            return View(model);
        }
        public IActionResult CaseSingle()
        {
            var model = new HomeViewModel
            {
                Categories = _homeRepository.GetCategories(),
                Settings = _homeRepository.GetSettings(),
                
            };
            ViewBag.Agents = _homeRepository.GetCaseAgent();
            return View(model);
        }
    }
}