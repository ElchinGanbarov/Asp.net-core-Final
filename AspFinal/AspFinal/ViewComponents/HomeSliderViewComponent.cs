using AspFinal.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repository.HomeRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspFinal.ViewComponents
{
    public class HomeSliderViewComponent:ViewComponent
    {
        private readonly IHomeRepository _homeRepository;
        private readonly IMapper _mapper;
        public HomeSliderViewComponent(IHomeRepository homeRepository,IMapper mapper)
        {
            _homeRepository = homeRepository;
            _mapper = mapper;
        }
        public IViewComponentResult Invoke()
        {
            var homeSliders = _homeRepository.GetHomeSliders();
            var model = _mapper.Map<IEnumerable<HomeSlider>, IEnumerable<HomeSliderViewModel>>(homeSliders);
            return View(model);
        }
    }
}
