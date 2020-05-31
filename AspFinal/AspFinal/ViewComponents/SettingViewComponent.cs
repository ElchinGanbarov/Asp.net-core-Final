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
    public class SettingViewComponent : ViewComponent
    {
        private readonly IHomeRepository _homeRepository;
        public SettingViewComponent(IHomeRepository homeRepository)
        {
            _homeRepository = homeRepository;
        }
        //Setting View Component
        public IViewComponentResult Invoke()
        {
            var homeSlider = _homeRepository.GetSettings();
            return View(homeSlider);
        }
    }
}
