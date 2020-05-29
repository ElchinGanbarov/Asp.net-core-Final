using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspFinal.Models;
using AspFinal.Models.AboutUsFolder;
using AspFinal.Models.Contact;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repository.HomeRepository;

namespace AspFinal.Controllers
{
    public class PagesController : Controller
    {
        private readonly IHomeRepository _homeRepository;
        private readonly IMapper _mapper;
        public PagesController(IHomeRepository homeRepository,IMapper mapper)
        {
            _mapper = mapper;
            _homeRepository = homeRepository;
        }
        public IActionResult About()
        {
            var model = new AboutUsViewModel
            {
                Settings = _homeRepository.SingleSetting(),
                Agents = _homeRepository.GetAgents(),
                Brands = _homeRepository.GetBrands(),
                AboutUs = _homeRepository.GetSingleAbout()
            };
            //var model = new HomeViewModel
            //{
            //    Categories = _homeRepository.GetCategories(),
            //    Settings = _homeRepository.GetSettings(),
            //    Agents = _homeRepository.GetAgents(),
            //    Brands = _homeRepository.GetBrands()

            //};
            return View(model);
        }
        public IActionResult FAQ()
        {
            var model = _homeRepository.GetFaqs(4);
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
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Contact()
        {
            var model = new DetailViewModel
            {
                ContactUs = _homeRepository.GetContactUs(),
                Settings=_homeRepository.GetSettings()
            };

            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Comment(ContactViewModel comment)
        {
            if (ModelState.IsValid)
            {
                var home = _mapper.Map<ContactViewModel, Contact>(comment);
                _homeRepository.CreateComment(home);
                return RedirectToAction(/*"~/Views/Shared/Comment/_Comment.cshtml"*/ "index","home");
            }


            return View("~/Views/Pages/Contact.cshtml", new DetailViewModel
            {
                Comment = comment
            });
        }
        public IActionResult Error404()
        {
        
            return View();
        }
    }
}