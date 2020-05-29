using Microsoft.AspNetCore.Mvc;
using Repository.Repository.HomeRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspFinal.ViewComponents
{
    public class TestmonialViewComponent:ViewComponent
    {
        private readonly IHomeRepository _homeRepository;
        public TestmonialViewComponent(IHomeRepository homeRepository)
        {
            _homeRepository = homeRepository;
        }
        public IViewComponentResult Invoke()
        {
            var testmonial = _homeRepository.GetTestimonials();
            return View(testmonial);
        }
    }
}
