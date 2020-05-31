using AspFinal.Models;
using Microsoft.AspNetCore.Mvc;
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
        //Home View Index Page
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
