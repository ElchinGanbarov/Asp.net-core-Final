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
        //About Page View Model
        public IActionResult About()
        {
            var model = new AboutUsViewModel
            {
                Settings = _homeRepository.SingleSetting(),
                Agents = _homeRepository.GetAgents(),
                Brands = _homeRepository.GetBrands(),
                AboutUs = _homeRepository.GetSingleAbout()
            };
                  return View(model);
        }
        //FAQ Page View Model
        public IActionResult FAQ()
        {
            var model = _homeRepository.GetFaqs(4);
            return View(model);
        }
        //ServiceSingle Page Model
        public IActionResult ServiceSingle()
        {
            var model = new HomeViewModel
            {
                Categories = _homeRepository.GetCategories(),
                Settings = _homeRepository.GetSettings()
            };
            return View(model);
        }
        //Contact Page View Model
        public IActionResult Contact()
        {
            var model = new DetailViewModel
            {
                ContactUs = _homeRepository.GetContactUs(),
                Settings=_homeRepository.GetSettings()
            };

            return View(model);
        }
        //Contact Model Added Database
        [HttpPost]
        public IActionResult Contact(ContactViewModel contact)
        {
            if (ModelState.IsValid)
            {
                var home = _mapper.Map<ContactViewModel, Contact>(contact);
                _homeRepository.CreateComment(home);
                return Ok(contact);


            }


            return View("~/Views/Pages/Contact.cshtml", new DetailViewModel
            {
                Contact = contact,
                ContactUs = _homeRepository.GetContactUs(),
                Settings = _homeRepository.GetSettings()
            });



        }
        //Error 404 Page View Model//
        public IActionResult Error404()
        {
        
            return View();
        }
    }
}